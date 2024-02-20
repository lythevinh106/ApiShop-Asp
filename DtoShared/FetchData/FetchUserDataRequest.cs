namespace DtoShared.FetchData
{
    public class FetchUserDataRequest : FetchDataRequest
    {


        public SortUserOption? Sort { get; set; } = null;



    }

    public enum SortUserOption
    {
        Ascending,
        Descending,
    }
}
