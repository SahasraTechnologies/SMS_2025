using Microsoft.AspNetCore.Mvc;
using SMS.Core;
using SMS.Models;
using SMS.Models.Login;

namespace SMS.UI.Controllers
{
    public class AppUserController : BaseController
    {
        [HttpGet]
        public IActionResult UserList()
        {
            ViewData["PageName"] = "Application Users";
            var response = new ViewDto<UserInfoDto>
            {
                Columns = DataTableHelper.GetDataTableColumns<UserInfoDto>(),
                //Data = new UserInfoDto(), // Represents the form model
                Data = new UserInfoDto(1, "krishna", "krishna@example.com", "Admin", "9876543210")
            };
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> GetListData(string searchTerm = null)
        {
            var data = new List<UserInfoDto>
                        {
                            new UserInfoDto(1, "krishna", "krishna@example.com", "Admin", "9876543210"),
                            new UserInfoDto(2, "arjun", "arjun@example.com", "User", "9876501234"),
                            new UserInfoDto(3, "sita", "sita@example.com", "Manager", "9876505678"),
                            new UserInfoDto(4, "ram", "ram@example.com", "User", "9876508765"),
                            new UserInfoDto(5, "geeta", "geeta@example.com", "Admin", "9876512345"),
                            new UserInfoDto(6, "rahul", "rahul@example.com", "User", "9876519876"),
                            new UserInfoDto(7, "tina", "tina@example.com", "Manager", "9876523456"),
                            new UserInfoDto(8, "mike", "mike@example.com", "User", "9876526789"),
                            new UserInfoDto(9, "usha", "usha@example.com", "Admin", "9876532109"),
                            new UserInfoDto(10, "sanju", "sanju@example.com", "User", "9876534567")
                        };

            return Ok(ApiResponse.Success(data, AppConstants.Success));
        }
    }
}
