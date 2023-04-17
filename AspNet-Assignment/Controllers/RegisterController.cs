using AspNet_Assignment.Models.Identity;
using AspNet_Assignment.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Assignment.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;

        public RegisterController(UserManager<CustomIdentityUser> useManager, SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = useManager; 
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {

                CustomIdentityUser customIdentityUser = registerViewModel;

                var registationResult = await _userManager.CreateAsync(customIdentityUser, registerViewModel.Password);
                if (registationResult.Succeeded)
                {
                    var loginResult = await _signInManager.PasswordSignInAsync(customIdentityUser, registerViewModel.Password, false, false);
                    if (loginResult.Succeeded)
                        return RedirectToAction("Index", "Home");
                    else
                        return RedirectToAction("Index", "Login");
                }
            }
            return View(registerViewModel);
        }
    }
}
