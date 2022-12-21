using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class MenuItem : TimeStampClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MenuItemName { get; set; }

        [Required]
        public double MenuItemPrice { get; set; }

        public int menuCategoryId { get; set; }
        public MenuCategory menuCategory { get; set; }
    }
}
