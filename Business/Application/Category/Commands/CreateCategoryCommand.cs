using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.ServiceTools.Blob;

namespace Service.Application.Category.Commands
{
    public class CreateCategoryCommand : IRequest<CategoryResponse>
    {
        private readonly CategoryRequest
            _categoryRequest;

        public CreateCategoryCommand(CategoryRequest categoryRequest)
        {
            _categoryRequest = categoryRequest;
        }



        public class Handler : BaseHandler, IRequestHandler<CreateCategoryCommand, CategoryResponse>
        {
            private readonly IBlob _blob;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlob blob) : base(unitOfWork, mapper


                )
            {
                _blob = blob;
            }

            public async Task<CategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
            {

                //if (!await _unitOfWork.CategoryRepository.CheckExist(c => c.Id == request._categoryRequest.CategoryId))
                //{
                //    throw new ValidationException("Category does not exist.");
                //}



                Model.Modules.CategoryModel.Category newCategory = _mapper.Map<Model.Modules.CategoryModel.Category>(request._categoryRequest);
                newCategory.Id = Guid.NewGuid().ToString();

                Model.Modules.CategoryModel.Category Category = await _unitOfWork.CategoryRepository.Add(newCategory);

                _unitOfWork.SaveChanges();

                return _mapper.Map<CategoryResponse>(Category);
            }
        }
    }
}
