using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using verisoftAPI.Business.Abstracts;

namespace verisoftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }



        [HttpGet]
        [Route("AllProducts")]
        public IActionResult Index()
        {
           var products= productService.getAllProducts();
            return Json(products);
        }
        [HttpGet]
        [Route("ProductDetail")]
        public IActionResult GetDetail(int id)
        {
            var product = productService.getProduct(id);
            return Json(product);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct([FromForm] Product product)
        {

            productService.addProduct(product);


            return Ok();
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct([FromForm] Product product)
        {

            productService.updateProduct(product);


            return Ok();
        }





    }
}
