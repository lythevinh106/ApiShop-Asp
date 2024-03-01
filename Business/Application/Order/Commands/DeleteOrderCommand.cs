using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.Order.Commands
{
    public class DeleteOrderCommand : IRequest<OrderDeleteResponse>
    {
        private readonly string _orderId;

        public DeleteOrderCommand(string orderId)
        {
            _orderId = orderId;
        }

        public class Handler : BaseHandler, IRequestHandler<DeleteOrderCommand, OrderDeleteResponse>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<OrderDeleteResponse> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.OrderRepository.CheckExist(c => c.Id == request._orderId))
                {
                    throw new ConflicDataException("Đơn Hàng Không tồn tại trong hệ thống ");
                }

                Model.Modules.OrderModel.Order order = await _unitOfWork.OrderRepository.Get(request._orderId);

                Model.Modules.OrderModel.Order orderRemove = _unitOfWork.OrderRepository.Delete(order);

                _unitOfWork.SaveChanges();
                return _mapper.Map<OrderDeleteResponse>(orderRemove);
            }
        }
    }
}