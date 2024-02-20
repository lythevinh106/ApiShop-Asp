using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Service.Application.User.Commands
{
    public class DeleteUserCommand : IRequest<UserResponse>
    {
        private readonly string _userId;

        public DeleteUserCommand(string userId)
        {
            _userId = userId;
        }

        public class Handler : IRequestHandler<DeleteUserCommand, UserResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<UserResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {




                //if (!await _userRepository.CheckExist(c => c.Id == request._userId))
                //{
                //    throw new ValidationException("Cateogry does not exist.");
                //}

                //Model.Modules.UserModel.User user = await _userRepository.Get(request._userId);

                //Model.Modules.UserModel.User userRemove = await _userRepository.Delete(user);
                //return _mapper.Map<UserResponse>(userRemove);


                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        if (!await _userRepository.CheckExist(c => c.Id == request._userId))
                        {
                            throw new ValidationException("Cateogry does not exist.");
                        }

                        Model.Modules.UserModel.User user = await _userRepository.Get(request._userId);
                        Model.Modules.UserModel.User userRemove = await _userRepository.Delete(user);

                        scope.Complete();
                        return _mapper.Map<UserResponse>(userRemove);

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