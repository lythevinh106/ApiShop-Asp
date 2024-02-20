using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;

namespace ShopBlazor.Services.Category
{
    public interface ICategoryApi
    {

        Task<CategoryResponse> GetCategoryByID(string id);
        Task<CategoryResponse> UpdateCategory(string id, CategoryRequest categoryRequest);
        Task<CategoryResponse> CreateCategory(CategoryRequest categoryRequest);
        Task<CategoryResponse> DeleteCategoryById(string id);
        Task<PaggingResponse<CategoryResponse>> FetchCategory(FetchDataCategoryRequest fetchDataCategoryRequest);
        Task<List<CategoryResponse>> All();


    }
}
