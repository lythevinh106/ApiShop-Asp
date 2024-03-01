using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.ServiceTools.Blob;

namespace Service.Application.Promotion.Commands
{
    public class CreatePromotionCommand : IRequest<PromotionResponse>
    {
        private readonly PromotionRequest
            _promotionRequest;

        public CreatePromotionCommand(PromotionRequest promotionRequest)
        {
            _promotionRequest = promotionRequest;
        }



        public class Handler : BaseHandler, IRequestHandler<CreatePromotionCommand, PromotionResponse>
        {
            private readonly IBlob _blob;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper


                )
            {
                _blob = blob;
            }

            public async Task<PromotionResponse> Handle(CreatePromotionCommand request, CancellationToken cancellationToken)
            {

                //if (!await _unitOfWork.PromotionRepository.CheckExist(c => c.Id == request._promotionRequest.PromotionId))
                //{
                //    throw new ValidationException("Promotion does not exist.");
                //}



                Model.Modules.PromotionModel.Promotion newPromotion = _mapper.Map<Model.Modules.PromotionModel.Promotion>(request._promotionRequest);
                newPromotion.Id = Guid.NewGuid().ToString();

                Model.Modules.PromotionModel.Promotion Promotion = await _unitOfWork.PromotionRepository.Add(newPromotion);

                _unitOfWork.SaveChanges();

                return _mapper.Map<PromotionResponse>(Promotion);
            }
        }
    }
}
