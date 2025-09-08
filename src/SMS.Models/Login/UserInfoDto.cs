using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.Login
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }

        public UserInfoDto() { }
        public UserInfoDto(int id, string userName, string email, string role, string phone) 
        { 
            Id = id;
            UserName = userName;
            Email = email;
            Role = role;
            Phone = phone;
        }

    }
}
