using Microsoft.AspNetCore.Mvc;

namespace SMS.UI.Controllers
{
    public class AppUserController : BaseController
    {
        [HttpGet]
        public IActionResult UserList()
        {
            ViewData["PageName"] = "Application Users";
            return View();
        }
    }
}
