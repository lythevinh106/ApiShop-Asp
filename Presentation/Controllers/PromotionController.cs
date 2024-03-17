using ApiShop.Presentation.Controllers;
using AutoMapper;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Application.Promotion.Commands;
using Service.Application.Promotion.Queries;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PromotionController : GenericBaseController
    {
        public PromotionController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }






        [HttpGet("FetchPromotion")]
        public async Task<ActionResult<PaggingResponse<PromotionResponse>>> FetchAllPromotion([FromQuery] FetchDataPromotionRequest fetchDataPromotionRequest)
        {
            PaggingResponse<PromotionResponse> results = await _imediator.Send(new FetchPromotionQuery(fetchDataPromotionRequest));
            return Ok(results);
        }

        [AllowAnonymous]
        [HttpGet("FetchPromotionClient")]
        public async Task<ActionResult<PaggingResponse<PromotionResponse>>> FetchAllPromotionClient([FromQuery] FetchDataPromotionRequest fetchDataPromotionRequest)
        {
            PaggingResponse<PromotionResponse> results = await _imediator.Send(new FetchPromotionQueryClient(fetchDataPromotionRequest));
            return Ok(results);
        }


        [HttpGet("all")]
        public async Task<ActionResult<List<PromotionResponse>>> GetAllPromotion()
        {
            List<PromotionResponse> results = await _imediator.Send(new AllPromotionQuery());
            return Ok(results);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PromotionResponse>> GetPromotion(string id)
        {


            PromotionResponse newPromotion = await _imediator.Send(new GetPromotionByIdQuery(id));

            return Ok(newPromotion);
        }

        [HttpPost]

        public async Task<ActionResult<PromotionResponse>> CreatePromotion(PromotionRequest PromotionRequest)
        {
            PromotionResponse newPromotion = await _imediator.Send(new CreatePromotionCommand(PromotionRequest));

            return Ok(newPromotion);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<PromotionResponse>> UpdatePromotion(string id, PromotionRequest PromotionRequest)
        {
            PromotionResponse newPromotion = await _imediator.Send(new UpdatePromotionComnnand(id, PromotionRequest));

            return Ok(newPromotion);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<PromotionResponse>> DeletePromotion(string id)
        {
            PromotionResponse PromotionRemove = await _imediator.Send(new DeletePromotionCommand(id));

            return Ok(PromotionRemove);
        }

    }
}
