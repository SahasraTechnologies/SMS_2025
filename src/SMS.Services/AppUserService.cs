using SMS.Models.Login;
using SMS.Services.Interfaces;

namespace SMS.Services
{
    public class AppUserService : IAppUserService
    {
        //public bool ValidateUser(UserDto userDto)
        //{
        //    return true;
        //}
        public bool ValidateUser(UserDto userDto)
        {
            return true;
        }
    }
}
