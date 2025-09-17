using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.Login
{
    public class UserInfoDto
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Role { get; set; }

        [Display(Name = "Phone")]
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
