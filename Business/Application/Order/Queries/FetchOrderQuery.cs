using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Model.Modules.ProductOrderModel;

namespace Service.Application.Order.Queries
{
    public class FetchOrderQuery : IRequest<PaggingResponse<ProductOrderWithUserResponse>>
    {

        private readonly FetchDataOrderRequest _fetchDataOrderRequest;

        public FetchOrderQuery(FetchDataOrderRequest fetchDataOrderRequest)
        {
            _fetchDataOrderRequest = fetchDataOrderRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchOrderQuery, PaggingResponse<ProductOrderWithUserResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<ProductOrderWithUserResponse>> Handle(FetchOrderQuery request, CancellationToken cancellationToken)
            {
                var orderRepo = _unitOfWork.OrderRepository;
                var productOrderRepo = _unitOfWork.ProductOrderRepository;

                IQueryable<ProductOrder> quertListProductOrder = productOrderRepo.All();


                //if (!request._fetchDataOrderRequest.Search.IsNullOrEmpty())
                //{
                //    quertListProductOrder = quertListProductOrder
                //    .Where(p => p.Id.Contains(request._fetchDataOrderRequest.Search));
                //}


                if (request._fetchDataOrderRequest.Sort.HasValue

                    )
                {
                    if (request._fetchDataOrderRequest.Sort.Value.ToString() == SortOrderOption.Ascending.ToString())
                    {
                        quertListProductOrder = productOrderRepo.Sort(p => (p.Time.ToString()), quertListProductOrder, false);
                    }
                    if (request._fetchDataOrderRequest.Sort.Value.ToString() == SortOrderOption.Descending.ToString())
                    {
                        quertListProductOrder = productOrderRepo.Sort(p => (p.Time.ToString()), quertListProductOrder, true);
                    }
                }



                if (request._fetchDataOrderRequest.SearchWithFilter.HasValue

                    )
                {

                    quertListProductOrder = quertListProductOrder.Where(lod => lod.Order.Status == request._fetchDataOrderRequest.SearchWithFilter);


                }





                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchDataOrderRequest);

                PagedList<ProductOrder> dataResponse = productOrderRepo.FectchData(fetchDataRequest, quertListProductOrder);



                PaggingResponse<ProductOrderWithUserResponse> results = new PaggingResponse<ProductOrderWithUserResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(po => new ProductOrderWithUserResponse
                    {

                        Status = po.Order.Status,
                        Time = po.Order.Time,


                        Product = _mapper.Map<ProductResponse>(po.Product),
                        User = _mapper.Map<UserResponse>(po.Order.User),

                        OrderId = po.OrderId






                    }).ToList()
                };


                return results;
            }




        }
    }
}
