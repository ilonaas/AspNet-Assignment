using AspNet_Assignment.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AspNet_Assignment.Models.Identity;

namespace AspNet_Assignment.Controllers
{
    [Authorize]
    public class LogoutController : Controller
    {
        private readonly SignInManager<CustomIdentityUser> _signInManager;

        public LogoutController(SignInManager<CustomIdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
