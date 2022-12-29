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

        // Read Menu Categories
        public IActionResult Index()
        {
            IEnumerable<MenuCategory> menuObj = _context.menuCategories;
            return View(menuObj);
        }

        //Create Menu Category
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuCategory menuObj)
        {
            var record = _context.menuCategories.Where(x => x.MenuCategoryName == menuObj.MenuCategoryName).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if(record != null)
                {
                    TempData["ResultNotOK"] = "Menu Category already Exist!!";
                    return View();
                }
                else
                {
                    _context.menuCategories.Add(menuObj);
                    _context.SaveChanges();
                    TempData["ResultOk"] = "Menu Category Added Successfully!";
                    return RedirectToAction("Index");
                } 
            }

            return View(menuObj);
        }


        // Edit Menu Categories
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuCategory menu)
        {
            if (ModelState.IsValid)
            {
                _context.menuCategories.Update(menu);
                _context.SaveChanges();
                TempData["ResultOk"] = "Menu Category Updated Successfully!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

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
            TempData["ResultOk"] = "Menu Category Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
