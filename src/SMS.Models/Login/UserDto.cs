using System.ComponentModel.DataAnnotations;

namespace SMS.Models.Login
{
    public class UserDto
    {
        [Required(ErrorMessage ="Please enter Email or UserName"), Display(Name = "Email Or Username")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string EmailOrUserName { get; set; }
        
        [Required(ErrorMessage = "Please enter Password"), Display(Name = "Password")]
        public string Password { get; set; }
    }
}
