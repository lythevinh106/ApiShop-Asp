using ApiShop.Presentation.Controllers;
using AutoMapper;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Application.Category.Commands;
using Service.Application.Category.Queries;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class CategoryController : GenericBaseController
    {
        public CategoryController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }



        [HttpGet("all")]
        public async Task<ActionResult<List<CategoryResponse>>> GetAllCategory()
        {
            List<CategoryResponse> results = await _imediator.Send(new AllCategoryQuery());
            return Ok(results);
        }


        [HttpGet("FetchCategory")]
        public async Task<ActionResult<PaggingResponse<CategoryResponse>>> GetAllCategory([FromQuery] FetchDataCategoryRequest fetchDataCategoryRequest)
        {
            PaggingResponse<CategoryResponse> results = await _imediator.Send(new FetchCategoryQuery(fetchDataCategoryRequest));
            return Ok(results);
        }




        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryResponse>> GetCategory(string id)
        {


            CategoryResponse newCategory = await _imediator.Send(new GetCategoryByIdQuery(id));

            return Ok(newCategory);
        }

        [HttpPost]

        public async Task<ActionResult<CategoryResponse>> CreateCategory(CategoryRequest CategoryRequest)
        {
            CategoryResponse newCategory = await _imediator.Send(new CreateCategoryCommand(CategoryRequest));

            return Ok(newCategory);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<CategoryResponse>> UpdateCategory(string id, CategoryRequest CategoryRequest)
        {
            CategoryResponse newCategory = await _imediator.Send(new UpdateCategoryComnnand(id, CategoryRequest));

            return Ok(newCategory);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<CategoryResponse>> DeleteCategory(string id)
        {
            CategoryResponse CategoryRemove = await _imediator.Send(new DeleteCategoryCommand(id));

            return Ok(CategoryRemove);
        }


    }

}
