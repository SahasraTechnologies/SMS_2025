using System.ComponentModel.DataAnnotations;

namespace SMS.Models.Login
{
    public class UserRequestDto
    {
        [Required(ErrorMessage ="Please enter Valid Email or UserName"), Display(Name = "Email Or Username")]
        public string EmailOrUserName { get; set; }
        
        [Required(ErrorMessage = "Please enter Password"), Display(Name = "Password")]
        public string Password { get; set; }
    }
}
