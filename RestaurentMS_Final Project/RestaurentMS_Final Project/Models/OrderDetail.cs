using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int MenuItemId { get; set; }

        public int OrderId { get; set; }



        [Required]
        public decimal ItemPrice { get; set; }

        [Required]
        public double Quantity { get; set; }


        public decimal Discount { get; set; }

        [Required]
        public decimal Total { get; set; }


        public MenuItem? MenuItem { get; set; }

        public Order? Orders { get; set; }
    }
}
