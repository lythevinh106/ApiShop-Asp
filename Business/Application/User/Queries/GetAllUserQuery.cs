using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;

namespace Service.Application.User.Queries
{
    public class GetAllUserQuery : IRequest<List<UserResponse>>
    {

        public GetAllUserQuery()
        {

        }

        public class Handler : IRequestHandler<GetAllUserQuery, List<UserResponse>>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<List<UserResponse>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
            {
                var userRepo = _userRepository;

                IQueryable<Model.Modules.UserModel.User> quertListUser = await userRepo.All();




                return quertListUser.Select(u => _mapper.Map<UserResponse>(u)).ToList();
            }
        }
    }
}
