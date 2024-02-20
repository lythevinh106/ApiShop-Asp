using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;

namespace Service.Application.Category.Queries
{
    public class AllCategoryQuery : IRequest<List<CategoryResponse>>
    {


        public AllCategoryQuery()
        {

        }

        public class Handler : BaseHandler, IRequestHandler<AllCategoryQuery, List<CategoryResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<CategoryResponse>> Handle(AllCategoryQuery request, CancellationToken cancellationToken)
            {
                var categoryRepo = _unitOfWork.CategoryRepository;

                var listCategory = categoryRepo.All().ToList();

                return listCategory.Select(c => _mapper.Map<CategoryResponse>(c)).ToList();
            }
        }
    }
}