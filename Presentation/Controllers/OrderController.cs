using ApiShop.Presentation.Controllers;
using AutoMapper;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Application.Order.Commands;
using Service.Application.Order.Queries;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : GenericBaseController
    {
        public OrderController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
        [HttpGet("FetchOrder")]
        public async Task<ActionResult<PaggingResponse<OrderResponse>>> GetAllOrder([FromQuery] FetchDataOrderRequest fetchDataOrderRequest)
        {
            PaggingResponse<OrderResponse> results = await _imediator.Send(new FetchOrderQuery(fetchDataOrderRequest));
            return Ok(results);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<OrderResponse>> GetOrder(string id)
        {


            OrderResponse newOrder = await _imediator.Send(new GetOrderByIdQuery(id));
            return Ok(newOrder);
        }

        [HttpPost]

        public async Task<ActionResult<OrderResponse>> CreateOrder([FromForm] OrderRequest OrderRequest)
        {
            OrderResponse newOrder = await _imediator.Send(new CreateOrderCommand(OrderRequest));

            return Ok(newOrder);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<OrderResponse>> UpdateOrder(string id, OrderUpdate orderUpdate)
        {
            OrderResponse newOrder = await _imediator.Send(new UpdateOrderComnnand(id, orderUpdate));

            return Ok(newOrder);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<OrderResponse>> DeleteOrder(string id)
        {
            OrderResponse OrderRemove = await _imediator.Send(new DeleteOrderCommand(id));

            return Ok(OrderRemove);
        }


    }
}
