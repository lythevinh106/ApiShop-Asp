using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model;
using Model.Modules.UserModel;
using Model.Modules.UserRefreshTokenModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository, IAccountRepository
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DBApiContext _context;
        public UserRepository(
           UserManager<User> userManager


           , SignInManager<User> signInManager,
           IConfiguration configuration,

           RoleManager<IdentityRole> roleManager,
           DBApiContext context
         )
        {

            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;



        }

        public async Task<User> Add(RegisterUser registerUser)
        {
            var user = new User()
            {

                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                Email = registerUser.Email,
                UserName = registerUser.Email,
                Address = registerUser.Address,

            };

            var result = await _userManager.CreateAsync(user, registerUser.Password);


            if (result.Succeeded)
            {
                var resultGenerate = await GenerateAuthListClaim(registerUser, user);

                if (resultGenerate)
                {
                    return user;
                }



            };
            return null;

        }

        public Task<RoleClaims> AddOrUpdateRoleClaim(RoleClaims roleClaims)
        {
            throw new NotImplementedException();
        }

        public Task<RoleResponse> AddRole(RoleRequest roleRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddUserInRole(string userName, string nameRole)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<User>> All()
        {
            var users = _userManager.Users;

            return users;
        }
        public async Task<PagedList<User>> FectchData(FetchDataRequest fetchDataRequest, IQueryable<User> query)
        {

            return PagedList<User>
                .ToPagedList(query, fetchDataRequest.PageNumber, fetchDataRequest.PageSize);

        }

        public IQueryable<User> Sort(Expression<Func<User, string>> field, IQueryable<User> query, bool ascending = true)
        {
            if (ascending) return query.OrderBy(field);

            return query.OrderByDescending(field);
        }


        public Task<bool> CheckExist(Expression<Func<User, bool>> predicate)
        {
            return _userManager.Users.AnyAsync(predicate);
        }


        public async Task<User> Get(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }


        public async Task<User> Delete(User user)
        {

            IdentityResult result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {

                return user;
            }
            return null;


        }
        public async Task<User> Update(User user)
        {
            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return user;
            }
            return null;
        }


        public async Task<List<User>> Find(Expression<Func<User, bool>> predicate)
        {
            return await _userManager.Users.AsNoTracking().Where(predicate).ToListAsync();
        }



        public Task<bool> CheckAccountRegisted(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckExistRole(string Namerole)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckExistUser(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckUserInRole(string userName, string nameRole)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ConfirmEmail(string Email, string token)
        {
            var user = await _userManager.FindByEmailAsync(Email);

            if (user != null)
            {
                var resultConfirm = await _userManager.ConfirmEmailAsync(user, token);

                if (resultConfirm.Succeeded)
                {

                    return true;
                }
            }

            return false;
        }



        public async Task<bool> GenerateAuthListClaim(RegisterUser registerUser, User user)
        {
            var authClaims = new List<Claim> {

                 new Claim(ClaimTypes.Name,user.Email),

                new Claim("firstName",user.FirstName),
                new Claim("lastName",user.LastName),

                new Claim("userId",user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),


            };

            try
            {
                foreach (var authclaim in authClaims)
                {
                    await _userManager.AddClaimAsync(user, authclaim);

                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("xay ra lỗi khi thêm claim");


            }

            return false;
        }

        public async Task<string> GenerateConfirmTokenEmail(string Email)
        {

            var user = await _userManager.FindByEmailAsync(Email);

            string TokenConfirmMail = await _userManager.GenerateEmailConfirmationTokenAsync(user);



            return TokenConfirmMail;


        }

        public string GenerateRefreshToken()
        {
            throw new NotImplementedException();
        }

        public UserRefreshToken GenerateUserRefreshToken(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SignInAsync(SingInUser singInUser)
        {

            var result = await _signInManager.PasswordSignInAsync(singInUser.Email,
                singInUser.Password, false, false);


            var user = await _userManager.FindByEmailAsync(singInUser.Email);

            if (!result.Succeeded)
            {
                return String.Empty;
            }


            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes
                (_configuration["JWT:Serect"])
            );
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(500),
                claims: await _userManager.GetClaimsAsync(user),



                 //signingCredentials: new SigningCredentials(

                 //    authenKey,
                 //    SecurityAlgorithms.HmacSha512


                 //    )

                 signingCredentials: new SigningCredentials(

                    authenKey,
                    SecurityAlgorithms.HmacSha256



                    )






              );


            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<IdentityResult> SignUpAsync(RegisterUser registerUser)
        {
            throw new NotImplementedException();
        }


    }


}
