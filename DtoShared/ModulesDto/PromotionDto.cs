using DtoShared.Validation;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{

    public class PromotionRequest
    {
        [Display(Name = "Tên Khuyến Mãi ")]

        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]

        public string Name { get; set; }

        [Display(Name = "Mô Tả Khuyến Mãi ")]

        [Required(ErrorMessage = "  {0} là bắt buộc ")]

        public string Description { get; set; }



        [Display(Name = "Giá Trị Khuyến Mãi ")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(1, 100, ErrorMessage = "{0} phải nằm trong khoảng từ 1 đến 100")]
        public int Value { get; set; }


        [Display(Name = "Ngày Bắt Đầu Khuyến Mãi")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]

        public DateTime TimeStart { get; set; }

        [Display(Name = "Ngày Kết Thúc Khuyến Mãi")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]

        [CompareGreaterThan("TimeStart", "Ngày Kết Thúc phải lớn hơn ngày bắt đầu")]

        public DateTime TimeEnd { get; set; }


    }


    public class PromotionResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public DateTime Time { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

    }




}
