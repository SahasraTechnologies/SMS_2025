using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SMS.UI.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public DateTime GetDateTimeNow() 
        { 
            return DateTime.UtcNow; 
        }

        public IActionResult NotFound() 
        {
            return View();
        }

        public IActionResult Exception()
        {
            return View();
        }
    }
}
