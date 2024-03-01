using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.User.Queries
{
    public class LoginUserQuery : IRequest<SingInResponse>
    {
        private readonly SingInUser _singInUser;

        public LoginUserQuery(SingInUser singInUser)
        {
            _singInUser = singInUser;
        }

        public class Handler : IRequestHandler<LoginUserQuery, SingInResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;
            private readonly IAccountRepository _accountRepository;

            public Handler(IMapper mapper, IUserRepository userRepository, IAccountRepository accountRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _accountRepository = accountRepository;
            }

            public async Task<SingInResponse> Handle(LoginUserQuery request, CancellationToken cancellationToken)
            {
                if (!await _userRepository.CheckExist(c => c.Email == request._singInUser.Email))
                {
                    throw new ConflicDataException("User Không tồn tại trong hệ thống ");
                }

                var result = await _accountRepository.SignInAsync(request._singInUser);

                if (result.IsNullOrEmpty()) throw new UnauthorizedAccessException("Sai ten Tai khoan or mat khau");

                return new SingInResponse
                {
                    jwtToken = result,
                };


            }
        }
    }
}