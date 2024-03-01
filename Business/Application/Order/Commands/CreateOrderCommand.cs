using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Model.Modules.ProductOrderModel;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Order.Commands
{
    public class CreateOrderCommand : IRequest<OrderResponse>
    {
        private readonly OrderRequest
            _orderRequest;

        public CreateOrderCommand(OrderRequest orderRequest)
        {
            _orderRequest = orderRequest;
        }

        public class Handler : BaseHandler, IRequestHandler<CreateOrderCommand, OrderResponse>
        {
            private readonly IBlob _blob;
            private readonly IUserRepository _userRepository;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob, IUserRepository userRepository) : base(unitOfWork, mapper

                )
            {
                _blob = blob;
                _userRepository = userRepository;
            }

            public async Task<OrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {

                if (!await _unitOfWork.ProductReponsitory.CheckExist(p => p.Id == request._orderRequest.ProductId))
                {

                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");

                }

                if (!await _userRepository.CheckExist(u => u.Id == request._orderRequest.UserId))
                {
                    throw new ConflicDataException("User Không tồn tại trong hệ thống ");


                }


                Model.Modules.OrderModel.Order newOrder = new Model.Modules.OrderModel.Order()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = request._orderRequest.UserId,
                    Time = DateTime.Now,

                };



                ProductOrder newProductOrder = new ProductOrder()
                {

                    ProductId = request._orderRequest.ProductId,
                    OrderId = newOrder.Id,
                    Quantity = request._orderRequest.quantity,
                    Time = newOrder.Time,

                };
                Model.Modules.OrderModel.Order order = await _unitOfWork.OrderRepository.Add(newOrder);
                ProductOrder productOrder = await _unitOfWork.ProductOrderRepository.Add(newProductOrder);


                _unitOfWork.SaveChanges();

                return new OrderResponse()
                {

                    UserId = request._orderRequest.UserId,
                    ProductId = request._orderRequest.ProductId,
                    Status = request._orderRequest.Status,
                    quantity = request._orderRequest.quantity,
                    Time = newOrder.Time


                };
            }
        }
    }
}