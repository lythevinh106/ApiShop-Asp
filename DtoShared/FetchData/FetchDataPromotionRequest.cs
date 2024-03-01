namespace DtoShared.FetchData
{
    public class FetchDataPromotionRequest : FetchDataRequest
    {


        public SortPromotionOption? Sort { get; set; }

    }

    public enum SortPromotionOption
    {
        Ascending,
        Descending,
    }
}
