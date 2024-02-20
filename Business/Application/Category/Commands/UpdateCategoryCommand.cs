using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.ServiceTools.Blob;
using System.ComponentModel.DataAnnotations;

namespace Service.Application.Category.Commands
{
    public class UpdateCategoryComnnand : IRequest<CategoryResponse>
    {
        private readonly CategoryRequest _categoryRequest;

        private readonly string _categoryId;

        public UpdateCategoryComnnand(string categoryId, CategoryRequest categoryRequest)
        {
            _categoryRequest = categoryRequest;

            _categoryId = categoryId;
        }

        public class Handler : BaseHandler, IRequestHandler<UpdateCategoryComnnand, CategoryResponse>
        {
            private readonly IBlob _blob;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper)
            {
                _blob = blob;
            }

            public async Task<CategoryResponse> Handle(UpdateCategoryComnnand request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.CategoryRepository.CheckExist(p => p.Id == request._categoryId))
                {
                    throw new ValidationException("Category does not exist.");
                }

                var newCategory = _mapper.Map<Model.Modules.CategoryModel.Category>(request._categoryRequest);

                newCategory.Id = request._categoryId;

                Model.Modules.CategoryModel.Category Category = _unitOfWork.CategoryRepository.Update(newCategory);
                _unitOfWork.SaveChanges();

                return _mapper.Map<CategoryResponse>(Category);
            }
        }
    }
}