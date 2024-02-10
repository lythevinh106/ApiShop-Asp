namespace DtoShared.FetchData
{
    public class FetchDataCategoryRequest : FetchDataRequest
    {
        public SortCategoryOption? Sort { get; set; } = null;
    }

    public enum SortCategoryOption
    {

        IdAscending,
        IdDescending,
    }
}
