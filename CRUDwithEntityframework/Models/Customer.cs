using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDwithEntityframework.Models
{
    public class Customer
    {
        // Server Side Validation Implementation
        [Key]
        public int Customer_Id { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        [StringLength(15, ErrorMessage = "Name should be less than or equal to 15 characters.")]
        public string Customer_Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter Your DOB.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [CRUDwithEntityframework.Models.CustomValidation.ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime DOB { get; set; }


        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number. Please Enter Phone Number in US Format (4447778888)")]
        public string Phone_Number { get; set; }


        [Required(ErrorMessage = "Enter Your EmailID")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Customer_Email { get; set; }

    }
}
