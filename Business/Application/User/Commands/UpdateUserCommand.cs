using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Service.Errors;
using System.Transactions;

namespace Service.Application.User.Commands
{
    public class UpdateUserComnnand : IRequest<UserResponse>
    {
        private readonly UserRequest _userRequest;

        private readonly string _userId;

        public UpdateUserComnnand(string userId, UserRequest userRequest)
        {
            _userRequest = userRequest;

            _userId = userId;
        }

        public class Handler : IRequestHandler<UpdateUserComnnand, UserResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<UserResponse> Handle(UpdateUserComnnand request, CancellationToken cancellationToken)
            {

                if (!await _userRepository.CheckExist(p => p.Id == request._userId))
                {
                    throw new ConflicDataException("User Không tồn tại trong hệ thống ");
                }

                //var user = _mapper.Map<Model.Modules.UserModel.User>(request._userRequest);

                //var oldUser1 = await _userRepository.Get(request._userId).As;

                //var oldListUser = await _userRepository.Find(u => u.Id == request._userId);
                //var oldUser = oldListUser[0];

                var oldUser = await _userRepository.Get(request._userId);
                oldUser.LastName = request._userRequest.LastName;
                oldUser.FirstName = request._userRequest.FirstName;
                oldUser.Address = request._userRequest.Address;




                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {


                        //var newUser = _mapper.Map<Model.Modules.UserModel.User>(request._userRequest);
                        Model.Modules.UserModel.User user = await _userRepository.Update(oldUser);

                        if (user == null)
                        {
                            throw new Exception("Update Failed");
                        }


                        scope.Complete();

                        return _mapper.Map<UserResponse>(user);
                    }
                    catch (Exception ex)
                    {
                        scope.Dispose();
                        throw new Exception(ex.Message.ToString());
                    }
                }
            }
        }
    }
}