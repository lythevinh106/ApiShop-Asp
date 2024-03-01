using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.Promotion.Queries
{
    public class GetPromotionByIdQuery : IRequest<PromotionResponse>
    {
        private readonly string _promotion;

        public GetPromotionByIdQuery(string promotion)
        {
            _promotion = promotion;
        }

        public class Handler : BaseHandler, IRequestHandler<GetPromotionByIdQuery, PromotionResponse>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PromotionResponse> Handle(GetPromotionByIdQuery request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.PromotionRepository.CheckExist(c => c.Id == request._promotion))
                {
                    throw new ConflicDataException("Khuyến Mãi Không tồn tại trong hệ thống ");
                }

                Model.Modules.PromotionModel.Promotion promotion = await _unitOfWork.PromotionRepository.Get(request._promotion);

                return _mapper.Map<PromotionResponse>(promotion);
            }
        }
    }
}
