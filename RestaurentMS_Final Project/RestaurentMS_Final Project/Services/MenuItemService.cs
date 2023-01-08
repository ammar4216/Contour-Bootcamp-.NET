using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Interfaces;

namespace RestaurentMS_Final_Project.Services
{
    public class MenuItemService : IMenuItemRepo
    {
        private readonly RestaurentMSDbContext _context;

        public MenuItemService(RestaurentMSDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetAllMenuItems()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                from obj in _context.menuItems
                select new SelectListItem
                {
                    Value = obj.Id.ToString(),
                    Text = obj.MenuItemName,
                    Selected = true
                }

                ).ToList();

            return objSelectListItems;
        }
    }
}
