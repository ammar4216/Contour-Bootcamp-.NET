using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class LoginViewModel
    {
        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }
        [Required(ErrorMessage = "Username Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
