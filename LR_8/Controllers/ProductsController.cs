using LR_8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LR_8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var orangeProduct = new Product()
            {
                Id = 0,
                Name = "Orange",
                Price = 10,
                CreatedDate = DateTime.Today.AddDays(-3)
            };
            var cherryProduct = new Product()
            {
                Id = 1,
                Name = "Cherry",
                Price = 15,
                CreatedDate = DateTime.Today.AddDays(-2)
            };
            var watermelonProduct = new Product()
            {
                Id = 2,
                Name = "Watermelon",
                Price = 17,
                CreatedDate = DateTime.Today.AddDays(-1)
            };
            var products = new List<Product>() { orangeProduct, cherryProduct, watermelonProduct };
            return View(products);
        }
    }
}
