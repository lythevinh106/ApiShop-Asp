using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiShop.Presentation.Controllers
{
    public class GenericBaseController : ControllerBase
    {

        protected IMediator _imediator;
        protected IMapper _mapper;
        public GenericBaseController(IMediator mediator, IMapper mapper)
          => (_imediator, _mapper) = (mediator, mapper);
    }
}
