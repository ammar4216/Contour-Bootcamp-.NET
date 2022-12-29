using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Name should be greater than 3 characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string? returnUrl { get; set; }

    }
}
