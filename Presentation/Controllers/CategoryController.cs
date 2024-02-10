using ApiShop.Presentation.Controllers;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class CategoryController : GenericBaseController
    {
        public CategoryController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

    }
}
