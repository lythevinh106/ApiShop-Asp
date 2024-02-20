using DtoShared.ModulesDto;
using Microsoft.AspNetCore.Identity;
using Model.Modules.UserModel;
using Model.Modules.UserRefreshTokenModel;

namespace DataAccess.Infrastructure
{
    public interface IAccountRepository
    {


        public Task<IdentityResult> SignUpAsync(RegisterUser registerUser);
        public Task<string> SignInAsync(SingInUser singInUser);



        public UserRefreshToken GenerateUserRefreshToken(string userId);


        public string GenerateRefreshToken();


        public Task<bool> GenerateAuthListClaim(RegisterUser registerUser, User user);

        public Task<bool> CheckAccountRegisted(string email);


        public Task<string> GenerateConfirmTokenEmail(string Email);

        public Task<bool> ConfirmEmail(string Email, string token);


        public Task<RoleResponse> AddRole(RoleRequest roleRequest);

        public Task<bool> AddUserInRole(string userName, string nameRole);


        public Task<bool> CheckExistRole(string Namerole);

        public Task<bool> CheckUserInRole(string userName, string nameRole);

        public Task<bool> CheckExistUser(string userName);


        public Task<RoleClaims> AddOrUpdateRoleClaim(RoleClaims roleClaims);
    }
}
