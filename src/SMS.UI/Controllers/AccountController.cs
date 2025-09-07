using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SMS.Models.Login;
using SMS.Services;
using SMS.Services.Interfaces;
using System.Security.Claims;
using System.Security.Principal;
namespace SMS.UI.Controllers
{
    public class AccountController : Controller
    {
        IAppUserService _userService;
    
        public AccountController(IAppUserService appUserService) 
        { 
            _userService = appUserService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            // Check if the user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string EmailOrUserName, string Password)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Login(UserRequestDto userdto)
        {
            if (ModelState.IsValid)
            {
                //AppUserService _userService = new AppUserService();
                var userData = _userService.ValidateUser(userdto);

                if (userData.Success) 
                {
                    //Get User Info From Database

                    // Create claims
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Upn, userData.Data.Id.ToString()),
                        new Claim(ClaimTypes.Name, userData.Data.UserName),
                        new Claim(ClaimTypes.Email, userData.Data.Email),
                        new Claim(ClaimTypes.GivenName, userData.Data.UserName),
                        new Claim(ClaimTypes.Role, "Admin") // Use dynamic role if available
                    };
                    // Create claims identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(claimsIdentity);
                    // Configure authentication properties
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true, // Persistent across sessions
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30) // Expiry
                    };

                    // Sign in the user
                    HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        principal,
                        authProperties
                    );

                    return RedirectToAction("Index","Home");
                }
            }
            return View(userdto);
        }


        [HttpPost]
        public IActionResult Logout()
        {
            //HttpContext.Session.Remove("User");
            //HttpContext.Session.Clear();
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
