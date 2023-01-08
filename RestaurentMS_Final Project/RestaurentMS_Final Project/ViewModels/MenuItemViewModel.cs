using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class MenuItemViewModel 
    {
        [Required(ErrorMessage = "Please Enter Menu Item Name")]
        public string MenuItemName { get; set; }

        [Required(ErrorMessage = "Please Enter Menu Item Price")]
        public decimal MenuItemPrice { get; set; }

        [Required(ErrorMessage = "Please Select Menu Category")]
        public int menuCategoryId { get; set; }

        public IList<SelectListItem> menu { get; set; } = new List<SelectListItem>();

    }
}
