using Microsoft.AspNetCore.Mvc;

namespace AspNet_Assignment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
