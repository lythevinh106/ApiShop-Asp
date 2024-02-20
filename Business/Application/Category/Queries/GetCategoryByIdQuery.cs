using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Service.Application.Category.Queries
{
    public class GetCategoryByIdQuery : IRequest<CategoryResponse>
    {
        private readonly string _category;

        public GetCategoryByIdQuery(string category)
        {
            _category = category;
        }

        public class Handler : BaseHandler, IRequestHandler<GetCategoryByIdQuery, CategoryResponse>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<CategoryResponse> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
            {
                if (!await _unitOfWork.CategoryRepository.CheckExist(c => c.Id == request._category))
                {
                    throw new ValidationException("Category does not exist.");
                }

                Model.Modules.CategoryModel.Category category = await _unitOfWork.CategoryRepository.Get(request._category);

                return _mapper.Map<CategoryResponse>(category);
            }
        }
    }
}
