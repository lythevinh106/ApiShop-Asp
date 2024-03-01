//using DtoShared.ModulesDto;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text.Json;
//namespace DtoShared.AuthenticationGeneric
//{
//    public class AuthenticationGeneric
//    {

//        public static ClaimsPrincipal SetClaimPrincipal(UserResponseClient model)
//        {
//            return new ClaimsPrincipal(new ClaimsIdentity(
//                new List<Claim>
//                {
//                    new(ClaimTypes.NameIdentifier, model.Id!),
//                    new Claim(ClaimTypes.Name,model.Email),

//                    new Claim("firstName",model.FirstName),
//                    new Claim("lastName",model.LastName),

//                    new Claim(ClaimTypes.Email, model.Email),
//                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                }, "JwtAuth"));
//        }

//        public static UserResponseClient GetClaimsFromToken(string jwtToken)
//        {
//            var handler = new JwtSecurityTokenHandler();

//            var token = handler.ReadJwtToken(jwtToken);
//            var claims = token.Claims;

//            //string Id = claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value!;
//            //string FirstName = claims.First(c => c.Type == ClaimTypes["firstName"]).Value!;
//            //string Email = claims.First(c => c.Type == ClaimTypes.Email).Value!;
//            //string Role = claims.First(c => c.Type == ClaimTypes.Role).Value!;

//            return new UserResponseClient
//            {

//                Id = "sadddddd213",
//                FirstName = "nguyen van 1",
//                LastName = "acccc",
//                Email = "lythevinh106@gmail.com"
//            };
//        }

//        public static JsonSerializerOptions JsonOptions()
//        {
//            return new JsonSerializerOptions
//            {
//                AllowTrailingCommas = true,
//                PropertyNameCaseInsensitive = true,
//                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,

//            };
//        }
//        public static string SerializeObj<T>(T modelObject) => JsonSerializer.Serialize(modelObject, JsonOptions());
//        public static T DeserializeJsonString<T>(string jsonString) => JsonSerializer.Deserialize<T>(jsonString, JsonOptions())!;
//        public static IList<T> DeserializeJsonStringList<T>(string jsonString) => JsonSerializer.Deserialize<IList<T>>(jsonString, JsonOptions())!;

//        public static StringContent GenerateStringContent(string serialiazedObj) => new(serialiazedObj, System.Text.Encoding.UTF8, "application/json");
//    }

//}

