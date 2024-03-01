using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace ShopBlazor.Pages.Product
{
    public class ProductUpdateRequestClient
    {
        [Display(Name = "Tên Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }

        [Display(Name = "Giá Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(0, (double)100000000, ErrorMessage = "{0} không được vượt quá 100,000,000")]
        public decimal Price { get; set; }

        [Display(Name = "Hình Ảnh")]
        public string? Image { get; set; } = null;

        public IBrowserFile? ImageFile
        {
            get; set;
        } = null;

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Description { get; set; }

        [Display(Name = " Danh Mục Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string CategoryId { get; set; }

        [Display(Name = " Chương Trình Khuyến Mãi")]
        public string? PromotionId { get; set; }
    }

    public class ProductCreateRequestClient
    {
        [Display(Name = "Tên Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }

        [Display(Name = "Giá Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(0, (double)100000000, ErrorMessage = "{0} không được vượt quá 100,000,000")]
        public decimal Price { get; set; }

        [Display(Name = "Hình Ảnh")]
        public string? Image { get; set; } = null;

        [Display(Name = "File Hình Ảnh")]

        [Required(ErrorMessage = "  {0} là bắt buộc ")]


        public IBrowserFile ImageFile
        {
            get; set;
        }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Description { get; set; }

        [Display(Name = " Danh Mục Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string CategoryId { get; set; }

        [Display(Name = " Chương Trình Khuyến Mãi")]
        public string? PromotionId { get; set; }
    }
}