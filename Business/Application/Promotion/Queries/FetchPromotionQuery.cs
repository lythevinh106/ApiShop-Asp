using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.Promotion.Queries
{
    public class FetchPromotionQuery : IRequest<PaggingResponse<PromotionResponse>>
    {

        private readonly FetchDataPromotionRequest _fetchDataPromotionRequest;

        public FetchPromotionQuery(FetchDataPromotionRequest fetchDataPromotionRequest)
        {
            _fetchDataPromotionRequest = fetchDataPromotionRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchPromotionQuery, PaggingResponse<PromotionResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<PromotionResponse>> Handle(FetchPromotionQuery request, CancellationToken cancellationToken)
            {
                var promotionRepo = _unitOfWork.PromotionRepository;

                IQueryable<Model.Modules.PromotionModel.Promotion> quertListPromotion = promotionRepo.All();


                if (!request._fetchDataPromotionRequest.Search.IsNullOrEmpty())
                {
                    quertListPromotion = quertListPromotion
                    .Where(p => p.Name.Contains(request._fetchDataPromotionRequest.Search));
                }
                if (request._fetchDataPromotionRequest.Sort.HasValue

                    )
                {
                    if (request._fetchDataPromotionRequest.Sort.Value.ToString() == SortPromotionOption.Ascending.ToString())
                    {
                        quertListPromotion = promotionRepo.Sort(c => (c.Time.ToString()), quertListPromotion, false);
                    }
                    if (request._fetchDataPromotionRequest.Sort.Value.ToString() == SortPromotionOption.Descending.ToString())
                    {
                        quertListPromotion = promotionRepo.Sort(c => (c.Time.ToString()), quertListPromotion, true);
                    }
                }



                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchDataPromotionRequest);


                PagedList<Model.Modules.PromotionModel.Promotion> dataResponse = promotionRepo.FectchData(fetchDataRequest, quertListPromotion);



                PaggingResponse<PromotionResponse> results = new PaggingResponse<PromotionResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => _mapper.Map<PromotionResponse>(p)).ToList()
                };


                return results;
            }




        }
    }
}
