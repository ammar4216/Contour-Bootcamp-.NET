using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class Reservation 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"/^923\d{9}$|^03\d{9}$/", ErrorMessage = "Please Enter a Valid Phone Number in Pakistan Format")]
        public string CustomerPhone { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public int NumberOfPersons { get; set; }

    }
}
