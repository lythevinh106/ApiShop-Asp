using System.ComponentModel.DataAnnotations;

namespace DtoShared.Enums
{
    public enum StatusOrder
    {
        [Display(Name = "đang chờ")]
        Pending = 0,
        [Display(Name = "thành công")]
        Success = 1,
        [Display(Name = "đã hủy")]
        Cancle = -1,
    }
}
