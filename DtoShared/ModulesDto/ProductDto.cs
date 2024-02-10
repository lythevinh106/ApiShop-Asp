using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{
    public class ProductRequest
    {
        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }

        [DisplayName("Giá Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [Range(0, 100000000, ErrorMessage = "{0} không được vượt quá 100,000,000")]
        public decimal Price { get; set; }

        [DisplayName("Hình Ảnh")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Image { get; set; }

        [DisplayName("Mô Tả")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public string Description { get; set; }

        [DisplayName("ID Danh Mục Sản Phẩm")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        public int CategoryId { get; set; }
    }

    public class ProductResponse
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}