using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Model.Modules.ProductOrderModel;
using Service.Errors;

namespace Service.Application.Order.Commands
{
    public class UpdateOrderComnnand : IRequest<OrderResponse>
    {
        private readonly OrderUpdate _orderUpdate;

        private readonly string _orderId;

        public UpdateOrderComnnand(string orderId, OrderUpdate orderUpdate)
        {
            _orderUpdate = orderUpdate;

            _orderId = orderId;
        }

        public class Handler : BaseHandler, IRequestHandler<UpdateOrderComnnand, OrderResponse>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository) : base(unitOfWork, mapper)
            {
                _userRepository = userRepository;
            }

            public async Task<OrderResponse> Handle(UpdateOrderComnnand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.OrderRepository.CheckExist(p => p.Id == request._orderId))
                {
                    throw new ConflicDataException("Đơn Hàng Không tồn tại trong hệ thống ");
                }

                if (!await _unitOfWork.ProductOrderRepository.CheckExist(p => p.ProductId == request._orderUpdate.ProductId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }

                var oldOrder = _unitOfWork.OrderRepository.Find(p => p.Id == request._orderId).ToList()[0];

                oldOrder.Status = request._orderUpdate.Status;
                Model.Modules.OrderModel.Order order = _unitOfWork.OrderRepository.Update(oldOrder);

                var oldProductOrder = _unitOfWork.ProductOrderRepository.Find(p => p.ProductId == request._orderUpdate.ProductId).ToList()[0];

                if (request._orderUpdate.quantity.HasValue)
                {
                    oldProductOrder.Quantity = request._orderUpdate.quantity.Value;
                    ProductOrder productOrder = _unitOfWork.ProductOrderRepository.Update(oldProductOrder);
                }

                _unitOfWork.SaveChanges();

                return new OrderResponse()
                {
                    UserId = order.UserId,
                    ProductId = request._orderUpdate.ProductId,
                    Status = order.Status,
                    quantity = oldProductOrder.Quantity,
                    Time = order.Time
                };
            }
        }
    }
}