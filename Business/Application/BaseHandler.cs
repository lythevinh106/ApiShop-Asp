using AutoMapper;
using DataAccess.Infrastructure;

namespace Service.Application
{
    public class BaseHandler
    {
        protected IUnitOfWork _unitOfWork;
        protected IMapper _mapper;


        public BaseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
    }
}
