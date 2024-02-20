using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Service.Application.User.Commands
{
    public class CreateUserCommand : IRequest<UserResponse>
    {
        private readonly RegisterUser
            _registerUser;

        public CreateUserCommand(RegisterUser registerUser)
        {
            _registerUser = registerUser;
        }



        public class Handler : IRequestHandler<CreateUserCommand, UserResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {

                if (await _userRepository.CheckExist(c => c.Email == request._registerUser.Email))
                {
                    throw new ValidationException("Email  is existed.");
                }



                Model.Modules.UserModel.User user = await _userRepository.Add(request._registerUser);

                if (user != null)
                {



                    return _mapper.Map<UserResponse>(user);
                }
                else
                {
                    throw new Exception("Create User Failed");
                }



            }
        }
    }
}
