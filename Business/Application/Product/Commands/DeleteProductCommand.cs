using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using Hangfire;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Product.Commands
{
    public class DeleteProductCommand : IRequest<ProductResponse>
    {
        private readonly string _productId;

        public DeleteProductCommand(string productId)
        {
            _productId = productId;
        }

        public class Handler : BaseHandler, IRequestHandler<DeleteProductCommand, ProductResponse>
        {

            private readonly IBlob _blob;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {

                _blob = blob;
            }

            public async Task<ProductResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.ProductReponsitory.CheckExist(c => c.Id == request._productId))
                {
                    throw new ConflicDataException("Sản Phẩm Không tồn tại trong hệ thống ");
                }

                Model.Modules.ProductModel.Product product = await _unitOfWork.ProductReponsitory.Get(request._productId);

                Model.Modules.ProductModel.Product productRemove = _unitOfWork.ProductReponsitory.Delete(product);

                string oldBlobFileName = await _blob.getBlobFileNameFromUrl(productRemove.Image);


                string jobId = BackgroundJob.Enqueue<IBlob>(b => b.DeleteBlobAsync(oldBlobFileName));





                _unitOfWork.SaveChanges();
                return _mapper.Map<ProductResponse>(productRemove);
            }
        }
    }
}
