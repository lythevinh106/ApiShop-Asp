using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.Product.Queries
{
    public class GetProductByIdQuery : IRequest<ProductResponse>
    {
        private readonly string _productId;

        public GetProductByIdQuery(string productId)
        {
            _productId = productId;
        }

        public class Handler : BaseHandler, IRequestHandler<GetProductByIdQuery, ProductResponse>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.ProductReponsitory.CheckExist(c => c.Id == request._productId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }

                Model.Modules.ProductModel.Product product = await _unitOfWork.ProductReponsitory.Get(request._productId);

                return _mapper.Map<ProductResponse>(product);
            }
        }
    }
}
