using Microsoft.EntityFrameworkCore;
using SMS.Core;
using SMS.Entities.Models;
using SMS.Models.Login;
using SMS.Services.Interfaces;

namespace SMS.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly SmsContext _dbcontext;
        public AppUserService(SmsContext smsContext) 
        { 
            _dbcontext = smsContext;
        }
        public SmsResponseDto<UserInfoDto> ValidateUser(UserRequestDto userDto)
        {
            var response = new SmsResponseDto<UserInfoDto>();
            var user = _dbcontext.AppUsers.FirstOrDefault(u => u.Email == userDto.EmailOrUserName || u.Username == userDto.EmailOrUserName);

            if (user != null)
            {
                response.Success = true;
                response.Data = new UserInfoDto();
                response.Data.Phone =user.Phone;
                response.Data.UserName = user.Username;
                response.Data.Email = user.Email;
                response.Data.Id = user.UserId;
                return response;

            }
            response.Success = false;
            return response;
        }
    }
}
