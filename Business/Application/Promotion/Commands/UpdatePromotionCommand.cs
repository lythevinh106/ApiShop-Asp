using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Promotion.Commands
{
    public class UpdatePromotionComnnand : IRequest<PromotionResponse>
    {
        private readonly PromotionRequest _PromotionRequest;

        private readonly string _PromotionId;

        public UpdatePromotionComnnand(string PromotionId, PromotionRequest PromotionRequest)
        {
            _PromotionRequest = PromotionRequest;

            _PromotionId = PromotionId;
        }

        public class Handler : BaseHandler, IRequestHandler<UpdatePromotionComnnand, PromotionResponse>
        {
            private readonly IBlob _blob;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {
                _blob = blob;
            }

            public async Task<PromotionResponse> Handle(UpdatePromotionComnnand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.PromotionRepository.CheckExist(p => p.Id == request._PromotionId))
                {
                    throw new ConflicDataException("Khuyến Mãi Không tồn tại trong hệ thống ");
                }

                var newPromotion = _mapper.Map<Model.Modules.PromotionModel.Promotion>(request._PromotionRequest);

                newPromotion.Id = request._PromotionId;

                Model.Modules.PromotionModel.Promotion Promotion = _unitOfWork.PromotionRepository.Update(newPromotion);
                _unitOfWork.SaveChanges();

                return _mapper.Map<PromotionResponse>(Promotion);
            }
        }
    }
}