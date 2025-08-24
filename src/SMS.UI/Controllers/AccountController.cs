using Microsoft.AspNetCore.Mvc;
using SMS.Models.Login;

namespace SMS.UI.Controllers
{
    public class AccountController : BaseController
    {
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

            }
            return View(userdto);
        }
    }
}
