using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Model.Modules.ProductOrderModel;
using Service.Errors;

namespace Service.Application.Order.Queries
{
    public class GetOrderByIdQuery : IRequest<ProductOrderWithUserResponse>
    {
        private readonly string _orderId;
        private readonly string _productId;

        public GetOrderByIdQuery(string productId, string orderId)
        {
            _orderId = orderId;
            _productId = productId;
        }

        public class Handler : BaseHandler, IRequestHandler<GetOrderByIdQuery, ProductOrderWithUserResponse>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<ProductOrderWithUserResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.OrderRepository.CheckExist(c => c.Id == request._orderId))
                {
                    throw new ConflicDataException("Đơn Hàng Không tồn tại trong hệ thống ");
                }

                if (!await _unitOfWork.ProductOrderRepository.CheckExist(po => po.ProductId == request._productId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }



                ProductOrder productOrder = await _unitOfWork.ProductOrderRepository.GetProductOrderByID(request._productId, request._orderId);

                return new ProductOrderWithUserResponse()
                {
                    OrderId = productOrder.OrderId,

                    Product = _mapper.Map<ProductResponse>(productOrder.Product),
                    User = _mapper.Map<UserResponse>(productOrder.Order.User),
                    quantity = productOrder.Quantity,
                    Status = productOrder.Order.Status,
                    Time = productOrder.Order.Time,


                };
            }
        }
    }
}
