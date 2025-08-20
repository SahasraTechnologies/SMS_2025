using Microsoft.AspNetCore.Mvc;

namespace SMS.UI.Controllers
{
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
