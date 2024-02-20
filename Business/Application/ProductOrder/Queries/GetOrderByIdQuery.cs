//using AutoMapper;
//using DataAccess.Infrastructure;
//using DtoShared.ModulesDto;
//using MediatR;
//using System.ComponentModel.DataAnnotations;

//namespace Service.Application.ProductOrder.Queries
//{
//    public class GetOrderByIdQuery : IRequest<OrderResponse>
//    {
//        private readonly string _orderId;

//        public GetOrderByIdQuery(string orderId)
//        {
//            _orderId = orderId;
//        }

//        public class Handler : BaseHandler, IRequestHandler<GetOrderByIdQuery, OrderResponse>
//        {
//            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
//            {
//            }

//            public async Task<OrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
//            {
//                if (!await _unitOfWork.OrderRepository.CheckExist(c => c.Id == request._orderId))
//                {
//                    throw new ValidationException("Order does not exist.");
//                }

//                Model.Modules.OrderModel.Order order = await _unitOfWork.OrderRepository.Get(request._orderId);

//                return _mapper.Map<OrderResponse>(order);
//            }
//        }
//    }
//}
