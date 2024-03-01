namespace DtoShared.FetchData
{
    public class FetchDataProductRequest : FetchDataRequest
    {
        public int? Price { get; set; } = null;

        public string? CategoryId { get; set; } = null;



        //private SortProductOption? _sort;
        public SortProductOption? Sort { get; set; } = null;
        public SortProductOption? SortTime { get; set; } = null;



    }

    public enum SortProductOption
    {
        Ascending,
        Descending,
    }
}
