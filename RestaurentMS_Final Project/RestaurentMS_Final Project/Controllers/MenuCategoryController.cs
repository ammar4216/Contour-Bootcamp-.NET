using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Controllers
{
    public class MenuCategoryController : Controller
    {
        private readonly RestaurentMSDbContext _context;

        public MenuCategoryController(RestaurentMSDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Index()
        {
            IEnumerable<MenuCategory> menuObj = _context.menuCategories;
            return View(menuObj);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuCategory menuObj)
        {
            var record = _context.menuCategories.Where(x => x.MenuCategoryName == menuObj.MenuCategoryName).FirstOrDefault();
            if (ModelState.IsValid)
            {
                    _context.menuCategories.Add(menuObj);
                    _context.SaveChanges();
                    TempData["success"] = "Menu Category added Successfully!";
                    return RedirectToAction("Index");
            }

            return View(menuObj);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var updateMenuCategory = _context.menuCategories.Find(id);

            if(updateMenuCategory == null)
            {
                return NotFound();
            }
            return View(updateMenuCategory);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuCategory menu)
        {
            if (ModelState.IsValid)
            {
                _context.menuCategories.Update(menu);
                _context.SaveChanges();
                TempData["success"] = "Menu Category updated successfully!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var deleteMenuCategory = _context.menuCategories.Find(id);

            if (deleteMenuCategory == null)
            {
                return NotFound();
            }
            return View(deleteMenuCategory);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMenuCategory(int? id)
        {
            var deleterecord = _context.menuCategories.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.menuCategories.Remove(deleterecord);
            _context.SaveChanges();
            TempData["success"] = "Menu Category deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
