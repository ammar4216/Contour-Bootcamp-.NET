using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class MenuCategory : TimeStampClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MenuCategoryName { get; set; }

    }
}
