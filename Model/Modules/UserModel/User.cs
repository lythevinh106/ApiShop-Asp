using Microsoft.AspNetCore.Identity;
using Model.Contracts;
using Model.Modules.OrderModel;

namespace Model.Modules.UserModel
{
    public class User : IdentityUser, ISeedable
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;


        public virtual List<Order> Orders { get; set; }
        // public virtual UserRefreshToken.Models.UserRefreshToken UserRefreshToken { get; set; }

        public System.Collections.IList Seed()
        {
            var Users = new List<User>(
                 SeedGuid.ListGuid.Select(idx => new User
                 {
                     Id = idx,
                     FirstName = "nguyen",
                     LastName = new Random().Next(1, 50).ToString(),
                     PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                     Email = $"user{new Random().Next(1, 50)}@gmail.com",

                 })

               );
            return Users;

        }


    }


    public class UserInfo
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
