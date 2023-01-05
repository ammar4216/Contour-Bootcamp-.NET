using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage ="Email Address Required")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
    }
}
