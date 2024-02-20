using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
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

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper

                )
            {
                _blob = blob;
            }

            public async Task<OrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                Model.Modules.OrderModel.Order newOrder = _mapper.Map<Model.Modules.OrderModel.Order>(request._orderRequest);

                Model.Modules.OrderModel.Order order = await _unitOfWork.OrderRepository.Add(newOrder);

                _unitOfWork.SaveChanges();

                return _mapper.Map<OrderResponse>(order);
            }
        }
    }
}