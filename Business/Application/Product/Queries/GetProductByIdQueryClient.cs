using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.Product.Queries
{
    public class GetProductByIdQueryClient : IRequest<ProductResponseClient>
    {
        private readonly string _productId;

        public GetProductByIdQueryClient(string productId)
        {
            _productId = productId;
        }

        public class Handler : BaseHandler, IRequestHandler<GetProductByIdQueryClient, ProductResponseClient>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<ProductResponseClient> Handle(GetProductByIdQueryClient request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.ProductReponsitory.CheckExist(c => c.Id == request._productId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }

                Model.Modules.ProductModel.Product product = await _unitOfWork.ProductReponsitory.Get(request._productId);



                return new ProductResponseClient
                {
                    Price = product.Price,
                    Name = product.Name,
                    Id = product.Id,
                    Description = product.Description,
                    Image = product.Image,
                    Time = product.Time.ToString(),
                    Promotion = _mapper.Map<PromotionResponse>(product.Promotion),
                    Category = _mapper.Map<CategoryResponse>(product.Category)


                };
            }
        }
    }
}
