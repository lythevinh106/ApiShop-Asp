using DtoShared.Validation;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{
    public class ProductRequest
    {
        [Display(Name = "Tên Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }

        [Display(Name = "Giá Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(0, 100000000, ErrorMessage = "{0} không được vượt quá 100,000,000")]
        public decimal Price { get; set; }

        [Display(Name = "Hình Ảnh")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]

        [FileExtension(new string[] { ".jpg", ".jpeg", ".png" })]
        public virtual IFormFile Image { get; set; }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Description { get; set; }

        [Display(Name = "ID Danh Mục Sản Phẩm")]

        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string CategoryId { get; set; }
    }


    public class ProductUpdate
    {
        [Display(Name = "Tên Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }

        [Display(Name = "Giá Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(0, 100000000, ErrorMessage = "{0} không được vượt quá 100,000,000")]
        public decimal Price { get; set; }

        [Display(Name = "Hình Ảnh")]

        [FileExtension(new string[] { ".jpg", ".jpeg", ".png" })]
        public virtual IFormFile? Image { get; set; }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Description { get; set; }

        [Display(Name = "ID Danh Mục Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string CategoryId { get; set; }

    }






    public class ProductResponse
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }

        public string Time { get; set; }
    }
}