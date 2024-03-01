using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Product.Commands
{
    public class UpdateProductComnnand : IRequest<ProductResponse>
    {

        private readonly ProductUpdate _productRequest;

        private readonly string _productId;
        public UpdateProductComnnand(string productId, ProductUpdate productRequest)
        {

            _productRequest = productRequest;

            _productId = productId;

        }

        public class Handler : BaseHandler, IRequestHandler<UpdateProductComnnand, ProductResponse>
        {

            private readonly IBlob _blob;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {
                _blob = blob;
            }

            public async Task<ProductResponse> Handle(UpdateProductComnnand request, CancellationToken cancellationToken)
            {



                if (!await _unitOfWork.CategoryRepository.CheckExist(c => c.Id == request._productRequest.CategoryId))
                {
                    throw new ConflicDataException("Danh Mục Không tồn tại trong hệ thống ");
                }

                if (!await _unitOfWork.ProductReponsitory.CheckExist(p => p.Id == request._productId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }

                var oldProduct = _unitOfWork.ProductReponsitory.Find(p => p.Id == request._productId).ToList()[0];



                var newProduct = _mapper.Map<Model.Modules.ProductModel.Product>(request._productRequest);

                newProduct.Id = request._productId;
                newProduct.Time = oldProduct.Time;








                if (request._productRequest.Image != null)
                {

                    await using (Stream fileStream = request._productRequest.Image.OpenReadStream())
                    {

                        string contentType = request._productRequest.Image.ContentType;
                        var result = await _blob.UploadBlobFile(fileStream, request._productRequest.Image.FileName, contentType);

                        await _blob.DeleteBlobAsync(await _blob.getBlobFileNameFromUrl(oldProduct.Image));

                        newProduct.Image = result;

                    }
                }
                else
                {


                    newProduct.Image = oldProduct.Image;
                }




                Model.Modules.ProductModel.Product product = _unitOfWork.ProductReponsitory.Update(newProduct);
                _unitOfWork.SaveChanges();

                return _mapper.Map<ProductResponse>(product);
            }
        }


    }
}
