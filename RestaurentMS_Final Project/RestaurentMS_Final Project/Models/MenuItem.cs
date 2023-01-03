
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class MenuItem 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MenuItemName { get; set; }

        [Required]
        public double MenuItemPrice { get; set; }

        public int menuCategoryId { get; set; }
        public IList<MenuCategory> menuCategory { get; set; }

        public IList<Order> orders { get; set; }    
        
    }
}
