using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Promotion.Commands
{
    public class DeletePromotionCommand : IRequest<PromotionResponse>
    {
        private readonly string _promotionId;

        public DeletePromotionCommand(string promotionId)
        {
            _promotionId = promotionId;
        }

        public class Handler : BaseHandler, IRequestHandler<DeletePromotionCommand, PromotionResponse>
        {
            private readonly IBlob _blob;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {
                _blob = blob;
            }

            public async Task<PromotionResponse> Handle(DeletePromotionCommand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.PromotionRepository.CheckExist(c => c.Id == request._promotionId))
                {
                    throw new ConflicDataException("Khuyến Mãi Không tồn tại trong hệ thống ");
                }

                Model.Modules.PromotionModel.Promotion promotion = await _unitOfWork.PromotionRepository.Get(request._promotionId);

                Model.Modules.PromotionModel.Promotion promotionRemove = _unitOfWork.PromotionRepository.Delete(promotion);

                _unitOfWork.SaveChanges();
                return _mapper.Map<PromotionResponse>(promotionRemove);
            }
        }
    }
}