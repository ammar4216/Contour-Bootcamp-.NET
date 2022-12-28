 using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Name should be greater than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        public string? returnUrl { get; set; }

        public IEnumerable<SelectListItem>? RoleList { get; set; }
        public string? RoleSelected { get; set; }



    }
}
