using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;

namespace ShopBlazor.Services.Order
{
    public interface IOrderApi
    {



        Task<ProductOrderWithUserResponse> GetOrderByID(string productId, string orderId);
        Task<OrderResponse> UpdateOrder(string id, OrderUpdate orderRequest);
        Task<OrderResponse> CreateOrder(OrderRequest categoryRequest);
        Task<OrderDeleteResponse> DeleteOrderById(string id);
        Task<PaggingResponse<ProductOrderWithUserResponse>> FetchOrder(FetchDataOrderRequest fetchDataOrderRequest);


        Task<List<AnalysisDataInfo>> AnalysisData(int dayNumber);
        Task<GroupAnalysisDataLineInfo> AnalysisDataLine(int dayNumber);

        Task<CountOrderInfo> CountSoldInfo();

        // Task<List<OrderResponse>> All();
    }
}
