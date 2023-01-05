using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Payment Type Name")]
        public string PaymentTypeName { get; set; }
    }
}
