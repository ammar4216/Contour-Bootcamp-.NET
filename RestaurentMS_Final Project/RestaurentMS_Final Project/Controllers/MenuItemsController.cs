using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly RestaurentMSDbContext _context;

        public MenuItemsController(RestaurentMSDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            IEnumerable<MenuItem> menuItems = _context.menuItems;
            return View(menuItems);
        }

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


    }
}
