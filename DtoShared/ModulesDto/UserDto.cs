using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DtoShared.ModulesDto
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Time { get; set; }
    }

    public class RegisterUser
    {
        [Display(Name = "Ho")]
        [StringLength(200, ErrorMessage = "{0} k dc dai qua  200 ki tu")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string FirstName { get; set; }

        [Display(Name = "Ten")]
        [StringLength(200, ErrorMessage = "{0} k dc dai qua  200 ki tu")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string LastName { get; set; }

        //[Display(Name = "Giới Tính")]
        //[Required(ErrorMessage = "{0} phai Có ")]
        //[CheckSex]
        //public Sex? Sex { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "{0} Khong dung dinh dang")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Dia chỉ")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string Address { get; set; }



    }

    public class UserRequest
    {
        [Display(Name = "Ho")]
        [StringLength(200, ErrorMessage = "{0} k dc dai qua  200 ki tu")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string FirstName { get; set; }

        [Display(Name = "Ten")]
        [StringLength(200, ErrorMessage = "{0} k dc dai qua  200 ki tu")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string LastName { get; set; }

        [Display(Name = "Dia chỉ")]
        [Required(ErrorMessage = "{0} phai nhap ")]
        public string Address { get; set; }
    }

    public class SingInUser
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "{0} Khong dung dinh dang")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }


    public class SingInResponse
    {

        public string jwtToken { get; set; }



    }
    public class RoleRequest
    {
        public string Name { get; set; }
    }

    public class RoleClaims
    {
        [Required]
        public string RoleId { get; set; }

        [DisplayName("ListClaim")]
        public List<ClaimsInRole>? Claims { get; set; }
    }

    public class ClaimsInRole
    {
        [DisplayName("Permission")]
        public string? Module { get; set; }

        [DisplayName("Permission")]
        public List<string>? Permissions { get; set; }
    }

    public class RoleResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}