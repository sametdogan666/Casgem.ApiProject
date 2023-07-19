using Casgem.Business.Abstract;
using Casgem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getlistproduct")]
        public IActionResult GetListProduct()
        {
            var results = _productService.GetList();

            return Ok(results);
        }

        [HttpGet("getlistproductwithcategories")]
        public IActionResult GetListProductWithCategories()
        {
            var results = _productService.GetProductWithCategoriesList();

            return Ok(results);
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(Product product)
        {
            _productService.Insert(product);

            return StatusCode(201, product);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            var result = _productService.GetById(id);
            _productService.Delete(result);

            return NoContent();
        }

        [HttpGet("getproductbyid/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var result = _productService.GetById(id);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.Update(product);

            return NoContent();
        }
    }
}
