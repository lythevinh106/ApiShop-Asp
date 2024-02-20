using System.ComponentModel.DataAnnotations;

namespace Model.Modules.UserRefreshTokenModel
{
    public class UserRefreshToken
    {
        [Key]
        public string UserId { get; set; }
        public string Token { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; }

        public virtual Model.Modules.UserModel.User User { get; set; }




    }


}
