using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;

namespace Service.Application.User.Queries
{
    public class GetUserByIdQuery : IRequest<UserResponse>
    {
        private readonly string _user;

        public GetUserByIdQuery(string user)
        {
            _user = user;
        }

        public class Handler : IRequestHandler<GetUserByIdQuery, UserResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<UserResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                if (!await _userRepository.CheckExist(c => c.Id == request._user))
                {
                    throw new ConflicDataException("User Không tồn tại trong hệ thống ");
                }

                Model.Modules.UserModel.User user = await _userRepository.Get(request._user);

                return _mapper.Map<UserResponse>(user);
            }
        }
    }
}
