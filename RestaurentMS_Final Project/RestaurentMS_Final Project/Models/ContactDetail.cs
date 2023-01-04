using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class ContactDetail : TimeStampClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        [StringLength(20, ErrorMessage = "Name should be less than or equal to 20 characters.")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Enter Your EmailID")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Enter Your Message")]
        [StringLength(255, ErrorMessage = "Message should be less than or equal to 255 characters.")]
        public string Message { get; set; }

    }
}
