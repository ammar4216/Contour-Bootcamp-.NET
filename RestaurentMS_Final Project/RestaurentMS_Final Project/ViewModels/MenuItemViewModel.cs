using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class MenuItemViewModel 
    {
        [Required]
        public string MenuItemName { get; set; }

        [Required]
        public decimal MenuItemPrice { get; set; }

        public int menuCategoryId { get; set; }
        public IList<SelectListItem>? menu { get; set; }

    }
}
