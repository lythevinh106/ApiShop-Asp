using ApiShop.Presentation.Controllers;
using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.View.MailLayout;
using Service.Application.User.Commands;
using Service.Application.User.Queries;
using Service.Notification;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : GenericBaseController
    {

        private readonly IConfiguration _configuration;
        private readonly IAccountRepository _accountRepository;
        public UserController(IMediator mediator, IMapper mapper, IConfiguration configuration, IAccountRepository accountRepository) : base(mediator, mapper)
        {
            _configuration = configuration;
            _accountRepository = accountRepository;

        }



        [HttpGet("FetchUser")]
        public async Task<ActionResult<PaggingResponse<UserResponse>>> GetAllUser([FromQuery] FetchUserDataRequest fetchUserDataRequest)
        {
            PaggingResponse<UserResponse> results = await _imediator.Send(new FetchUserQuery(fetchUserDataRequest));
            return Ok(results);
        }

        [HttpGet("AllUser")]
        public async Task<ActionResult<List<UserResponse>>> AllUser()
        {
            List<UserResponse> results = await _imediator.Send(new GetAllUserQuery());
            return Ok(results);
        }





        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUser(string id)
        {


            UserResponse newUser = await _imediator.Send(new GetUserByIdQuery(id));

            return Ok(newUser);
        }

        [HttpPost]

        public async Task<ActionResult<bool>> CreateUser(RegisterUser registerUser)
        {
            UserResponse newUser = await _imediator.Send(new CreateUserCommand(registerUser));

            if (newUser != null)
            {
                string token = await _accountRepository.GenerateConfirmTokenEmail(newUser.Email);
                var link = Url.Action(nameof(ConfirmMailToken), "User", new { token = token, email = registerUser.Email }, Request.Scheme);

                string fileContentRegister = MailLayoutHelper.GetMailLayoutRegister(link);

                _imediator.Publish(new SendMailNotificaltion("Xác Thực Tài Khoản", fileContentRegister, newUser.Email));





                return Ok(true);
            }
            return false;
            return BadRequest("Lỗi Khi Tạo Tài Khoản");

        }


        [HttpGet("ConfirmMailToken")]
        public async Task<IActionResult> ConfirmMailToken([FromQuery] string token, string email)

        {
            var result = await _accountRepository.ConfirmEmail(email, token);

            if (result)
            {
                return Ok("Da Xac Nhan Email Thanh Cong-Hay quay ve trang cua chung toi de dang nhap");
            }

            return NotFound();
        }


        [HttpPost("SingIn")]

        public async Task<ActionResult> SingIn(SingInUser singInUser)
        {
            SingInResponse singInResponse = await _imediator.Send(new LoginUserQuery(singInUser));

            return Ok(singInResponse);

        }



        [HttpPut("{id}")]

        public async Task<ActionResult<UserResponse>> UpdateUser(string id, UserRequest UserRequest)
        {
            UserResponse newUser = await _imediator.Send(new UpdateUserComnnand(id, UserRequest));

            return Ok(newUser);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<UserResponse>> DeleteUser(string id)
        {
            UserResponse userRemove = await _imediator.Send(new DeleteUserCommand(id));

            return Ok(userRemove);
        }


    }
}
