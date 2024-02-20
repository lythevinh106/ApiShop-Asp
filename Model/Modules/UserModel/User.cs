using Microsoft.AspNetCore.Identity;
using Model.Contracts;
using Model.Modules.OrderModel;

namespace Model.Modules.UserModel
{
    public class User : IdentityUser, ISeedable
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;


        public string Address { get; set; } = null!;

        public DateTime Time { get; set; } = DateTime.Now;
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
                     UserName = "nguyen" + new Random().Next(1, 50).ToString(),
                     PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                     Email = $"user{new Random().Next(1, 50)}@gmail.com",
                     Address = "Dia chi " + new Random().Next(1, 50).ToString()

                 })

               ); ;


            return Users;

        }


    }



}
