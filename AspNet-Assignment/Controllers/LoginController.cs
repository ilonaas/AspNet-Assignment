using AspNet_Assignment.Models.Identity;
using AspNet_Assignment.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Assignment.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<CustomIdentityUser> _signInManager;

        public LoginController(SignInManager<CustomIdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, false, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Felaktig e-postadress och lösenord");
            }

            return View(viewModel);
        }
    }
}
