using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.Category.Queries
{
    public class FetchCategoryQuery : IRequest<PaggingResponse<CategoryResponse>>
    {

        private readonly FetchDataCategoryRequest _fetchDataCategoryRequest;

        public FetchCategoryQuery(FetchDataCategoryRequest fetchDataCategoryRequest)
        {
            _fetchDataCategoryRequest = fetchDataCategoryRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchCategoryQuery, PaggingResponse<CategoryResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<CategoryResponse>> Handle(FetchCategoryQuery request, CancellationToken cancellationToken)
            {
                var categoryRepo = _unitOfWork.CategoryRepository;

                IQueryable<Model.Modules.CategoryModel.Category> quertListCateogry = categoryRepo.All();


                if (!request._fetchDataCategoryRequest.Search.IsNullOrEmpty())
                {
                    quertListCateogry = quertListCateogry
                    .Where(p => p.Name.Contains(request._fetchDataCategoryRequest.Search));
                }
                if (request._fetchDataCategoryRequest.Sort.HasValue

                    )
                {
                    if (request._fetchDataCategoryRequest.Sort.Value.ToString() == SortCategoryOption.Ascending.ToString())
                    {
                        quertListCateogry = categoryRepo.Sort(c => (c.Time.ToString()), quertListCateogry, false);
                    }
                    if (request._fetchDataCategoryRequest.Sort.Value.ToString() == SortCategoryOption.Descending.ToString())
                    {
                        quertListCateogry = categoryRepo.Sort(c => (c.Time.ToString()), quertListCateogry, true);
                    }
                }



                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchDataCategoryRequest);


                PagedList<Model.Modules.CategoryModel.Category> dataResponse = categoryRepo.FectchData(fetchDataRequest, quertListCateogry);



                PaggingResponse<CategoryResponse> results = new PaggingResponse<CategoryResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => _mapper.Map<CategoryResponse>(p)).ToList()
                };


                return results;
            }




        }
    }
}
