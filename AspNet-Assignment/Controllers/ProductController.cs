using AspNet_Assignment.Models.Products;
using AspNet_Assignment.Service;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Assignment.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]       
        public async Task<IActionResult> Index(ProductEntity entity)
        {
            await _productService.AddProductAsync(entity);
            return View();
        }

        public async Task<IActionResult> Products()
        {
            var products = await _productService.GetAllAsync();
            return View(products);
        }
    }
}
