using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POCClient.Functionality;
using POCClient.Models;

namespace POCClient.Controllers
{
    [Route("Azureapi/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProduct iProduct;
        public ProductController(IProduct _iProduct) // DI for ProductRepository 
        {
            iProduct = _iProduct;
        }

        [HttpGet]
        [Route("ProductList")]
        public IActionResult getProductList() {
        
            return Ok(iProduct.getProducts());
        }

        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {
            return Ok(iProduct.createProduct(product));
        }
    }
}
