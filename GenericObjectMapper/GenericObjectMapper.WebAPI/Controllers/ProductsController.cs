using GenericObjectMapper.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GenericObjectMapper.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetProductDetailList")]
        public ActionResult GetProductDetailList()
        {
            var result = _productService.GetProductDetailList();
            return StatusCode(result.Success ? 200 : 400, result); 
        }

        [HttpGet("{productId}")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetProductDetail(productId);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}