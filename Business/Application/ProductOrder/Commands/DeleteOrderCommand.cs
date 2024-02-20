//using AutoMapper;
//using DataAccess.Infrastructure;
//using DtoShared.ModulesDto;
//using MediatR;
//using System.ComponentModel.DataAnnotations;

//namespace Service.Application.ProductOrder.Commands
//{
//    public class DeleteOrderCommand : IRequest<OrderResponse>
//    {
//        private readonly string _orderId;

//        public DeleteOrderCommand(string orderId)
//        {
//            _orderId = orderId;
//        }

//        public class Handler : BaseHandler, IRequestHandler<DeleteOrderCommand, OrderResponse>
//        {
//            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
//            {
//            }

//            public async Task<OrderResponse> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
//            {
//                if (!await _unitOfWork.OrderRepository.CheckExist(c => c.Id == request._orderId))
//                {
//                    throw new ValidationException("Order does not exist.");
//                }

//                Model.Modules.OrderModel.Order order = await _unitOfWork.OrderRepository.Get(request._orderId);

//                Model.Modules.OrderModel.Order orderRemove = _unitOfWork.OrderRepository.Delete(order);

//                _unitOfWork.SaveChanges();
//                return _mapper.Map<OrderResponse>(orderRemove);
//            }
//        }
//    }
//}