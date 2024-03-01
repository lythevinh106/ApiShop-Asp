using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Product.Commands
{
    public class CreateProductCommand : IRequest<ProductResponse>
    {
        private readonly ProductRequest
            _productRequest;

        public CreateProductCommand(ProductRequest productRequest)
        {
            _productRequest = productRequest;
        }



        public class Handler : BaseHandler, IRequestHandler<CreateProductCommand, ProductResponse>
        {
            private readonly IBlob _blob;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper


                )
            {
                _blob = blob;
            }

            public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {

                if (!await _unitOfWork.CategoryRepository.CheckExist(c => c.Id == request._productRequest.CategoryId))
                {
                    throw new ConflicDataException("Danh Mục Không tồn tại trong hệ thống ");
                }

                if (!request._productRequest.PromotionId.IsNullOrEmpty())
                {
                    if (!await _unitOfWork.PromotionRepository.CheckExist(c => c.Id == request._productRequest.PromotionId))
                    {
                        throw new ConflicDataException("Danh Mục Không tồn tại trong hệ thống ");
                    }
                }




                Model.Modules.ProductModel.Product newProduct = _mapper.Map<Model.Modules.ProductModel.Product>(request._productRequest);


                newProduct.Id = Guid.NewGuid().ToString();

                await using (Stream fileStream = request._productRequest.Image.OpenReadStream())
                {


                    string contentType = request._productRequest.Image.ContentType;
                    var result = await _blob.UploadBlobFile(fileStream, request._productRequest.Image.FileName, contentType);
                    newProduct.Image = result;

                }



                Model.Modules.ProductModel.Product product = await _unitOfWork.ProductReponsitory.Add(newProduct);

                _unitOfWork.SaveChanges();

                return _mapper.Map<ProductResponse>(product);
            }
        }
    }
}
