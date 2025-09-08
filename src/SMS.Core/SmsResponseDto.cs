using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core
{
    public class SmsResponseDto<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string Message { get; set; } = "Success";
        public List<string>? Errors { get; set; }

        public static SmsResponseDto<T> Success(T data, string message = "Success") => new()
        {
            IsSuccess = true,
            Message = message,
            Data = data
        };

        public static SmsResponseDto<T> Fail(string message, List<string>? errors = null) => new()
        {
            IsSuccess = false,
            Message = message,
            Errors = errors,
            Data = default
        };
    }
}
