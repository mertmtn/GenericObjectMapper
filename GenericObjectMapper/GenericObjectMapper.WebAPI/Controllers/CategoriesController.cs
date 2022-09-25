using GenericObjectMapper.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GenericObjectMapper.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {

        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        } 

        [HttpGet("{categoryId}")]
        public IActionResult GetById(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}