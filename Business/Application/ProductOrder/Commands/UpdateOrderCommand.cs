//using AutoMapper;
//using DataAccess.Infrastructure;
//using DtoShared.ModulesDto;
//using MediatR;
//using System.ComponentModel.DataAnnotations;

//namespace Service.Application.ProductOrder.Commands
//{
//    public class UpdateOrderComnnand : IRequest<OrderResponse>
//    {
//        private readonly OrderUpdate _orderUpdate;

//        private readonly string _orderId;

//        public UpdateOrderComnnand(string orderId, OrderUpdate orderUpdate)
//        {
//            _orderUpdate = orderUpdate;

//            _orderId = orderId;
//        }

//        public class Handler : BaseHandler, IRequestHandler<UpdateOrderComnnand, OrderResponse>
//        {
//            private readonly IUserRepository _userRepository;

//            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository) : base(unitOfWork, mapper)
//            {
//                _userRepository = userRepository;
//            }

//            public async Task<OrderResponse> Handle(UpdateOrderComnnand request, CancellationToken cancellationToken)
//            {
//                if (!await _unitOfWork.OrderRepository.CheckExist(p => p.Id == request._orderId))
//                {
//                    throw new ValidationException("Order không tồn tại.");
//                }



//                var oldOrder = _unitOfWork.OrderRepository.Find(p => p.Id == request._orderId).ToList()[0];

//                //var newOrder = _mapper.Map<Model.Modules.OrderModel.Order>(request._orderUpdate);

//                oldOrder.Status = request._orderUpdate.Status;


//                Model.Modules.OrderModel.Order order = _unitOfWork.OrderRepository.Update(oldOrder);
//                _unitOfWork.SaveChanges();

//                return _mapper.Map<OrderResponse>(order);
//            }
//        }
//    }
//}