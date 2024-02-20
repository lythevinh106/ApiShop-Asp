//using AutoMapper;
//using DataAccess.Infrastructure;
//using DtoShared.ModulesDto;
//using MediatR;
//using Service.ServiceTools.Blob;

//namespace Service.Application.ProductProductOrder.Commands
//{
//    public class CreateProductOrderCommand : IRequest<ProductOrderResponse>
//    {
//        private readonly ProductOrderRequest
//            _productProductOrderRequest;

//        public CreateProductOrderCommand(ProductOrderRequest productProductOrderRequest)
//        {
//            _productProductOrderRequest = productProductOrderRequest;
//        }

//        public class Handler : BaseHandler, IRequestHandler<CreateProductOrderCommand, ProductOrderResponse>
//        {
//            private readonly IBlob _blob;

//            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper

//                )
//            {
//                _blob = blob;
//            }

//            public async Task<ProductOrderResponse> Handle(CreateProductOrderCommand request, CancellationToken cancellationToken)
//            {
//                Model.Modules.ProductOrderModel.ProductOrder newProductOrder = _mapper.Map<Model.Modules.ProductOrderModel.ProductOrder>(request._productProductOrderRequest);

//                Model.Modules.ProductOrderModel.ProductOrder productProductOrder = await _unitOfWork.ProductOrderRepository.Add(newProductOrder);

//                _unitOfWork.SaveChanges();

//                return _mapper.Map<ProductOrderResponse>(productProductOrder);
//            }
//        }
//    }
//}