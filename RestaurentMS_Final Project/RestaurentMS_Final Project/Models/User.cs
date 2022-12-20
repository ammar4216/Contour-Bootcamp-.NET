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


        public string Email { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter CNIC Number")]
        public string CNIC { get; set; }

        [Required(ErrorMessage = "Please Enter Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"/^923\d{9}$|^03\d{9}$/", ErrorMessage = "Please Enter a Valid Phone Number in Pakistan Format")]
        public string ContactNo { get; set; }

        public int AddressId { get; set; }

        public int RoleId { get; set; }

        public Address address { get; set; }

        public Roles roles { get; set; }


    }
}
