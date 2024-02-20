using DtoShared.Enums;

namespace DtoShared.ModulesDto
{
    public class OrderResponse
    {

        public StatusOrder Status { get; set; } = StatusOrder.Pending;

        public string UserId { get; set; }

        public DateTime Time { get; set; }
    }

    public class OrderRequest
    {

        public StatusOrder Status { get; set; } = StatusOrder.Pending;

        public string UserId { get; set; }


    }

    public class OrderUpdate
    {

        public StatusOrder Status { get; set; }


    }
}
