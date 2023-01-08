using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class Order 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public decimal FinalTotal { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }


        public int PaymentId { get; set; }

        public IList<OrderDetail>? OrderDetail { get; set; }  

        public PaymentType Payment { get; set; }



    }
}
