using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{
    public class CategoryRequest
    {
        [DisplayName("Tên Danh Mục")]
        [Required(ErrorMessage = "  {0} là bắt buộc ")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "{0} phải Từ {2} tới {1} kí tự ")]
        public string Name { get; set; }
    }


    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
