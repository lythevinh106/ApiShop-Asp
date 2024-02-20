using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.Order.Queries
{
    public class FetchOrderQuery : IRequest<PaggingResponse<OrderResponse>>
    {

        private readonly FetchDataOrderRequest _fetchDataOrderRequest;

        public FetchOrderQuery(FetchDataOrderRequest fetchDataOrderRequest)
        {
            _fetchDataOrderRequest = fetchDataOrderRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchOrderQuery, PaggingResponse<OrderResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<OrderResponse>> Handle(FetchOrderQuery request, CancellationToken cancellationToken)
            {
                var orderRepo = _unitOfWork.OrderRepository;

                IQueryable<Model.Modules.OrderModel.Order> quertListOrder = orderRepo.All();


                if (!request._fetchDataOrderRequest.Search.IsNullOrEmpty())
                {
                    quertListOrder = quertListOrder
                    .Where(p => p.Id.Contains(request._fetchDataOrderRequest.Search));
                }


                if (request._fetchDataOrderRequest.Sort.HasValue

                    )
                {
                    if (request._fetchDataOrderRequest.Sort.Value.ToString() == SortOrderOption.Ascending.ToString())
                    {
                        quertListOrder = orderRepo.Sort(p => (p.Time.ToString()), quertListOrder, false);
                    }
                    if (request._fetchDataOrderRequest.Sort.Value.ToString() == SortOrderOption.Descending.ToString())
                    {
                        quertListOrder = orderRepo.Sort(p => (p.Time.ToString()), quertListOrder, true);
                    }
                }

                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchDataOrderRequest);

                PagedList<Model.Modules.OrderModel.Order> dataResponse = orderRepo.FectchData(fetchDataRequest, quertListOrder);



                PaggingResponse<OrderResponse> results = new PaggingResponse<OrderResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => _mapper.Map<OrderResponse>(p)).ToList()
                };


                return results;
            }




        }
    }
}
