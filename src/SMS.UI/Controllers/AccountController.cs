using Microsoft.AspNetCore.Mvc;

namespace SMS.UI.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
