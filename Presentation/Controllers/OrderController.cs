using ApiShop.Presentation.Controllers;
using AutoMapper;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Application.Order.Commands;
using Service.Application.Order.Queries;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : GenericBaseController
    {
        public OrderController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
        [HttpGet("FetchOrder")]
        public async Task<ActionResult<PaggingResponse<ProductOrderWithUserResponse>>> GetAllOrder([FromQuery] FetchDataOrderRequest fetchDataOrderRequest)
        {
            PaggingResponse<ProductOrderWithUserResponse> results = await _imediator.Send(new FetchOrderQuery(fetchDataOrderRequest));
            return Ok(results);
        }



        [HttpGet("getProductOrder")]
        public async Task<ActionResult<ProductOrderWithUserResponse>> GetOrder(string productId, string orderId)
        {


            ProductOrderWithUserResponse newOrder = await _imediator.Send(new GetOrderByIdQuery(productId, orderId));
            return Ok(newOrder);
        }


        [HttpGet("CountSoldInfo")]
        public async Task<ActionResult<ProductOrderWithUserResponse>> CountSoldInfo()
        {


            CountOrderInfo info = await _imediator.Send(new CountInfoQuery());
            return Ok(info);
        }


        [HttpGet("AnalysisData/{dayNumber}")]
        public async Task<ActionResult<List<AnalysisDataInfo>>> AnalysisData(int dayNumber)
        {

            var results = await _imediator.Send(new AnalysisDataQuery(dayNumber));
            return Ok(results);
        }

        [HttpGet("AnalysisDataLine/{dayNumber}")]
        public async Task<ActionResult<GroupAnalysisDataLineInfo>> AnalysisDataLine(int dayNumber)
        {


            if (dayNumber >= 30)
            {
                dayNumber = 30;
            }
            if (dayNumber <= 0)
            {
                dayNumber = 1;
            }

            var results = await _imediator.Send(new AnalysisDataQueryLine(dayNumber));
            return Ok(results);
        }



        [HttpPost]

        public async Task<ActionResult<OrderResponse>> CreateOrder(OrderRequest OrderRequest)
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

        public async Task<ActionResult<OrderDeleteResponse>> DeleteOrder(string id)
        {
            OrderDeleteResponse OrderRemove = await _imediator.Send(new DeleteOrderCommand(id));

            return Ok(OrderRemove);
        }


    }
}
