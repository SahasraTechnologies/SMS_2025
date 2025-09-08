using Microsoft.EntityFrameworkCore;
using SMS.Core;
using SMS.Entities.Models;
using SMS.Models.Login;
using SMS.Repo;
using SMS.Services.Interfaces;
using System.Linq.Expressions;

namespace SMS.Services
{
    public class AppUserService : IAppUserService
    {
        //private readonly SmsContext _dbcontext;
        private readonly IBaseRepo<AppUser> _baseRepo;
        public AppUserService(
            //SmsContext smsContext, 
            IBaseRepo<AppUser> baseRepo
            ) 
        { 
            //_dbcontext = smsContext;
            _baseRepo = baseRepo;
        }
        //public SmsResponseDto<UserInfoDto> ValidateUser(UserRequestDto userDto)
        //{
        //    var response = new SmsResponseDto<UserInfoDto>();
        //    var user = _dbcontext.AppUsers.FirstOrDefault(u => u.Email == userDto.EmailOrUserName || u.Username == userDto.EmailOrUserName);

        //    if (user != null)
        //    {
        //        response.IsSuccess = true;
        //        response.Data = new UserInfoDto();
        //        response.Data.Phone =user.Phone;
        //        response.Data.UserName = user.Username;
        //        response.Data.Email = user.Email;
        //        response.Data.Id = user.UserId;
        //        return response;

        //    }
        //    response.IsSuccess = false;
        //    return response;
        //}

        public SmsResponseDto<UserInfoDto> ValidateUser(UserRequestDto userDto)
        {
            Expression<Func<AppUser, bool>> predicate = user => user.Email.Contains(userDto.EmailOrUserName) || user.Username.Contains(userDto.EmailOrUserName);
            var repoResponse = _baseRepo.FirstOrDefaultAsync(predicate).Result;
            
            var response = new SmsResponseDto<UserInfoDto>();
            if (repoResponse != null)
            {
                response.IsSuccess = true;
                response.Data = new UserInfoDto(repoResponse.Data.UserId, repoResponse.Data.Username, repoResponse.Data.Email, null, repoResponse.Data.Phone);

                //response.Data = new UserInfoDto();
                //response.Data.Phone = repoResponse.Data.Phone;
                //response.Data.UserName = repoResponse.Data.Username;
                //response.Data.Email = repoResponse.Data.Email;
                //response.Data.Id = repoResponse.Data.UserId;

                return response;

            }
            response.IsSuccess = false;
            return response;
        }
    }
}
