using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using ShopBlazor.Pages.Product;

namespace ShopBlazor.Services.Product
{
    public interface IProductApi
    {

        Task<ProductResponse> GetProductByID(string id);
        Task<ProductResponse> UpdateProduct(string id, ProductUpdateRequestClient productUpdateRequestClient);
        Task<ProductResponse> CreateProduct(ProductCreateRequestClient productCreateRequestClient);
        Task<ProductResponse> DeleteProductById(string id);
        Task<PaggingResponse<ProductResponse>> FetchProduct(FetchDataProductRequest fetchDataProductRequest);
        Task<List<ProductResponse>> All();


    }
}
