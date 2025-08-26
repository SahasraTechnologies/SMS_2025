using SMS.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Services.Interfaces
{
    public interface IAppUserService
    {
        bool ValidateUser(UserDto userDto);
    }
}
