using Microsoft.AspNetCore.Mvc.Rendering;

namespace RestaurentMS_Final_Project.Interfaces
{
    public interface IMenuItemRepo
    {
        public IEnumerable<SelectListItem> GetAllMenuItems();
    }
}
