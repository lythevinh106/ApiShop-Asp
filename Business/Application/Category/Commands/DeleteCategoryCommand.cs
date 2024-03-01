using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using Service.ServiceTools.Blob;

namespace Service.Application.Category.Commands
{
    public class DeleteCategoryCommand : IRequest<CategoryResponse>
    {
        private readonly string _categoryId;

        public DeleteCategoryCommand(string categoryId)
        {
            _categoryId = categoryId;
        }

        public class Handler : BaseHandler, IRequestHandler<DeleteCategoryCommand, CategoryResponse>
        {
            private readonly IBlob _blob;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {
                _blob = blob;
            }

            public async Task<CategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.CategoryRepository.CheckExist(c => c.Id == request._categoryId))
                {
                    throw new ConflicDataException("Danh Mục Không tồn tại trong hệ thống ");
                }

                Model.Modules.CategoryModel.Category category = await _unitOfWork.CategoryRepository.Get(request._categoryId);

                Model.Modules.CategoryModel.Category categoryRemove = _unitOfWork.CategoryRepository.Delete(category);

                _unitOfWork.SaveChanges();
                return _mapper.Map<CategoryResponse>(categoryRemove);
            }
        }
    }
}