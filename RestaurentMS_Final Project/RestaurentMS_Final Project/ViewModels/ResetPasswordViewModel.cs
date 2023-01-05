using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword { get; set; }
        public string Code { get; set; }
    }
}
