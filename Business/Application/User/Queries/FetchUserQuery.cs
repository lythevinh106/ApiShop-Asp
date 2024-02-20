using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.User.Queries
{
    public class FetchUserQuery : IRequest<PaggingResponse<UserResponse>>
    {
        private readonly FetchUserDataRequest _fetchUserDataRequest;

        public FetchUserQuery(FetchUserDataRequest fetchUserDataRequest)
        {
            _fetchUserDataRequest = fetchUserDataRequest;
        }

        public class Handler : IRequestHandler<FetchUserQuery, PaggingResponse<UserResponse>>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public Handler(IMapper mapper, IUserRepository userRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<PaggingResponse<UserResponse>> Handle(FetchUserQuery request, CancellationToken cancellationToken)
            {
                var userRepo = _userRepository;

                IQueryable<Model.Modules.UserModel.User> quertListUser = await userRepo.All();

                if (!request._fetchUserDataRequest.Search.IsNullOrEmpty())
                {
                    quertListUser = quertListUser
                    .Where(p =>
                         p.FirstName.Contains(request._fetchUserDataRequest.Search)
                      || p.LastName.Contains(request._fetchUserDataRequest.Search

                     )
                    );
                }

                if (request._fetchUserDataRequest.Sort.HasValue

                    )
                {
                    if (request._fetchUserDataRequest.Sort.Value.ToString() == SortCategoryOption.Ascending.ToString())
                    {
                        quertListUser = userRepo.Sort(c => (c.Time.ToString()), quertListUser, false);
                    }
                    if (request._fetchUserDataRequest.Sort.Value.ToString() == SortCategoryOption.Descending.ToString())
                    {
                        quertListUser = userRepo.Sort(c => (c.Time.ToString()), quertListUser, true);
                    }
                }

                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchUserDataRequest);

                PagedList<Model.Modules.UserModel.User> dataResponse = await userRepo.FectchData(fetchDataRequest, quertListUser);

                PaggingResponse<UserResponse> results = new PaggingResponse<UserResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => _mapper.Map<UserResponse>(p)).ToList()
                };

                return results;
            }
        }
    }
}