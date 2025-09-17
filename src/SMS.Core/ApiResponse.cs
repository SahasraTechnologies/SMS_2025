using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core
{
    public static class ApiResponse
    {
        public static SmsResponseDto<T> Success<T>(T data, string message = "Success") => new()
        {
            Data = data,
            Message = message,
            IsSuccess = true,
        };

        public static SmsResponseDto<T> Fail<T>(string message) => new()
        {
            Data = default,
            Message = message,
            IsSuccess = false,
        };
    }
}
