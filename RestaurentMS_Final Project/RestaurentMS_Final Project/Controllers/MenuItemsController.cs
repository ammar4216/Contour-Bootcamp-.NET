using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;
using System.Data;

namespace RestaurentMS_Final_Project.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly RestaurentMSDbContext _context;

        public MenuItemsController(RestaurentMSDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Index()
        {
            
            IEnumerable<MenuItem> menuItems = _context.menuItems;
            return View(menuItems);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var data = _context.menuCategories.ToList();

            var MyMenuItem = new MenuItemViewModel() { menu = new List<SelectListItem>() };

            foreach (var item in data)
            {
                MyMenuItem.menu.Add(new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.MenuCategoryName
                }
                    );

            }
            return View(MyMenuItem);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuItemViewModel menuItemViewModel)
        {
            
            if (ModelState.IsValid)
            {
                var menuItems = new MenuItem
                {
                    MenuItemName = menuItemViewModel.MenuItemName,
                    MenuItemPrice = menuItemViewModel.MenuItemPrice,
                    menuCategoryId = menuItemViewModel.menuCategoryId
                };
                
                    _context.menuItems.Add(menuItems);
                    _context.SaveChanges();
                    TempData["success"] = "Menu Item added successfully!";
                    return RedirectToAction("Index");

            }

            return View(menuItemViewModel);
        }

        // Edit
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    var updateMenuItem = _context.menuItems.Find(id);

        //    var data = _context.menuCategories.ToList();

        //    var MyMenuItem = new MenuItemViewModel() { menu = new List<SelectListItem>() };

        //    var menuItemViewModel = new MenuItemViewModel()
        //    {
        //        MenuItemName = updateMenuItem.MenuItemName,
        //        MenuItemPrice = updateMenuItem.MenuItemPrice,


        //    };
        //    return View();
        //}

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(int? Id)
        {
            var menu = _context.menuItems.FirstOrDefault(u => u.Id == Id);
            if (menu == null)
            {
                return NotFound();
            }
            _context.menuItems.Remove(menu);
            _context.SaveChanges();
            TempData["success"] = "Menu Item deleted successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
