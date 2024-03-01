using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;

namespace ShopBlazor.Services.Promotion
{
    public interface IPromotionApi
    {

        Task<PromotionResponse> GetPromotionByID(string id);
        Task<PromotionResponse> UpdatePromotion(string id, PromotionRequest promotionRequest);
        Task<PromotionResponse> CreatePromotion(PromotionRequest promotionRequest);
        Task<PromotionResponse> DeletePromotionById(string id);
        Task<PaggingResponse<PromotionResponse>> FetchPromotion(FetchDataPromotionRequest fetchDataPromotionRequest);
        Task<List<PromotionResponse>> All();


    }
}
