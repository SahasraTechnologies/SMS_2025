using Microsoft.AspNetCore.Mvc;
using SMS.Models.Login;
using SMS.Services;
using SMS.Services.Interfaces;

namespace SMS.UI.Controllers
{
    public class AccountController : BaseController
    {
        IAppUserService _userService;
        public AccountController(IAppUserService appUserService) 
        { 
            _userService = appUserService;
        }
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string EmailOrUserName, string Password)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Login(UserDto userdto)
        {
            if (ModelState.IsValid)
            {
                //AppUserService _userService = new AppUserService();
                bool isValidUser= _userService.ValidateUser(userdto);

                if (isValidUser) 
                { 
                    return RedirectToAction("Index","Home");
                }
            }
            return View(userdto);
        }
    }
}
