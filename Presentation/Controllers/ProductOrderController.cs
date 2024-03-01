using ApiShop.Presentation.Controllers;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductOrderController : GenericBaseController
    {
        public ProductOrderController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {

        }


        //[HttpGet("FetchProduct")]
        //public async Task<ActionResult<PaggingResponse<ProductResponse>>> GetAllProduct([FromQuery] FetchDataProductRequest fetchDataProductRequest)
        //{
        //    PaggingResponse<ProductResponse> results = await _imediator.Send(new FetchProductQuery(fetchDataProductRequest));
        //    return Ok(results);
        //}



        //[HttpGet("{id}")]
        //public async Task<ActionResult<ProductResponse>> GetProduct(string id)
        //{


        //    ProductResponse newProduct = await _imediator.Send(new GetProductByIdQuery(id));
        //    return Ok(newProduct);
        //}

        //[HttpPost]

        //public async Task<ActionResult<ProductResponse>> CreateProduct([FromForm] ProductRequest productRequest)
        //{
        //    ProductResponse newProduct = await _imediator.Send(new CreateProductCommand(productRequest));

        //    return Ok(newProduct);
        //}


        //[HttpPut("{id}")]

        //public async Task<ActionResult<ProductResponse>> UpdateProduct(string id, [FromForm] ProductUpdate productRequest)
        //{
        //    ProductResponse newProduct = await _imediator.Send(new UpdateProductComnnand(id, productRequest));

        //    return Ok(newProduct);
        //}

        //[HttpDelete("{id}")]

        //public async Task<ActionResult<ProductResponse>> DeleteProduct(string id)
        //{
        //    ProductResponse productRemove = await _imediator.Send(new DeleteProductCommand(id));

        //    return Ok(productRemove);
        //}







    }
}
