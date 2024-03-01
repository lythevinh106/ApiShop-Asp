using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;

namespace Service.Application.Promotion.Queries
{
    public class AllPromotionQuery : IRequest<List<PromotionResponse>>
    {


        public AllPromotionQuery()
        {

        }

        public class Handler : BaseHandler, IRequestHandler<AllPromotionQuery, List<PromotionResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<PromotionResponse>> Handle(AllPromotionQuery request, CancellationToken cancellationToken)
            {
                var promotionRepo = _unitOfWork.PromotionRepository;

                var listPromotion = promotionRepo.All().ToList();

                return listPromotion.Select(c => _mapper.Map<PromotionResponse>(c)).ToList();
            }
        }
    }
}