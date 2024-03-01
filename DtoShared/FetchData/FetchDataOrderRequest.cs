using DtoShared.Enums;

namespace DtoShared.FetchData
{
    public class FetchDataOrderRequest : FetchDataRequest
    {

        public SortOrderOption? Sort { get; set; } = null;
        public StatusOrder? SearchWithFilter { get; set; } = null;
    }

    public enum SortOrderOption
    {
        Ascending,
        Descending,
    }

}
