using DtoShared.Enums;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{
    public class OrderResponse
    {

        public StatusOrder Status { get; set; } = StatusOrder.Pending;

        public string UserId { get; set; }

        public string ProductId { get; set; }

        public int quantity { get; set; }


        public DateTime Time { get; set; }





    }


    public class OrderDeleteResponse
    {


        public string UserId { get; set; }

        public DateTime Time { get; set; }

    }


    public class OrderRequest
    {

        [Display(Name = "Trạng thái hàng hóa ")]

        [Required(ErrorMessage = "{0} là bắt buộc ")]
        public StatusOrder Status { get; set; } = StatusOrder.Pending;


        [Display(Name = "Id của người dùng")]

        [Required(ErrorMessage = "{0} là bắt buộc ")]

        public string UserId { get; set; }

        [Display(Name = "ID Sản Phẩm")]
        [Required(ErrorMessage = "{0} là bắt buộc ")]

        public string ProductId { get; set; }


        [Display(Name = "số lượng sản phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public int quantity { get; set; }




    }

    public class OrderUpdate
    {
        [Display(Name = "Trạng thái hàng hóa ")]

        [Required(ErrorMessage = "{0} là bắt buộc ")]


        [EnumDataType(typeof(StatusOrder), ErrorMessage = "{0} không hợp lệ ")]
        public StatusOrder Status { get; set; }


        [Display(Name = "ID Sản Phẩm")]
        [Required(ErrorMessage = "{0} là bắt buộc ")]

        public string ProductId { get; set; }


        [Display(Name = "số lượng sản phẩm")]

        public int? quantity { get; set; } = null;
    }


    public class CountOrderInfo
    {

        public decimal? dailyProfit { get; set; }
        public int? dailySoldNumber { get; set; }
        public decimal? monthlyProfit { get; set; }
        public int? monthlySoldNumber { get; set; }

    }



    //public class AnalysisDataInfoGroupByCategory
    //{

    //    public string? nameCategory { get; set; }
    //    public AnalysisDataInfo data { get; set; }


    //}


    public class AnalysisDataInfo
    {
        public string? nameCategory { get; set; }
        public decimal? profit { get; set; }
        public int? soldNumber { get; set; }


    }

    public class AnalysisDataLineInfo
    {
        public DateTime? time { get; set; }

        public int? orderNumber { get; set; }


    }


    public class GroupAnalysisDataLineInfo
    {

        public Dictionary<string, List<AnalysisDataLineInfo>> Data { get; set; }



    }






    public class ProductOrderWithUserResponse
    {


        public string OrderId { get; set; }

        public ProductResponse Product { get; set; }
        public UserResponse User { get; set; }


        public StatusOrder Status { get; set; }
        public int quantity { get; set; }

        public DateTime Time { get; set; }

    }
}
