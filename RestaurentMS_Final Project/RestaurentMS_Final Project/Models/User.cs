using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class User : TimeStampClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Name should be greater than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter CNIC Number")]
        public string CNIC { get; set; }

        [Required(ErrorMessage = "Please Enter Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }

        public int AddressId { get; set; }

        public int RoleId { get; set; }

        public Address address { get; set; }

        public Roles roles { get; set; }


    }
}
