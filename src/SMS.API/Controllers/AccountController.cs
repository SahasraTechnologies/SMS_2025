using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        public AccountController() { }
        [HttpGet("qwe")]
        //[HttpGet]
        public IActionResult ABC()
        {
            return Ok("Success");
        }
        [HttpGet("tyu")]
        //[HttpGet]
        public IActionResult XYZ()
        {
            return Ok("Falied");
        }
    }
}
