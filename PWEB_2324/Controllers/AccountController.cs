using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PWEB_2324.Models;

namespace PWEB_2324.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager <IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login(string url)
        {
            return View(new LoginModel()
            {
                Url = url
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginM)
        {
            if (!ModelState.IsValid)
                return View(loginM);

            var user = await _userManager.FindByNameAsync(loginM.UserName);

            if(user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginM.Password, false, false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginM.Url))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(loginM.Url);
                }
            }
            ModelState.AddModelError("", "Login falhou!");
            return View(loginM);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginModel registroM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = registroM.UserName };
                var result = await _userManager.CreateAsync(user, registroM.Password);

                if (result.Succeeded)
                {
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    this.ModelState.AddModelError("Registro", "Falha ao registrar o usuário");
                }
            }
            return View(registroM);
        }
    }
}
