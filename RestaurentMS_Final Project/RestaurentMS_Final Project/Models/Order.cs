using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class Order 
    {
        [Key]
        public int Id { get; set; }

        public int MenuItemId { get; set; }

        public int PaymentId { get; set; }


        public IList<MenuItem> menuItem { get; set; }  

        public PaymentType payment { get; set; }



    }
}
