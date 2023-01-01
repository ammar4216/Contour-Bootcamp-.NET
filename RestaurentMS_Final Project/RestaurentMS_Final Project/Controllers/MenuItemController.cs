using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly RestaurentMSDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MenuItemController(RestaurentMSDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var menuItems = await _context.menuItems.ToListAsync();
            return View(menuItems);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var menuItem = await _context.menuItems.FirstOrDefaultAsync(m => m.Id == id);

            var menuItemModel = new MenuItem()
            {
                Id = menuItem.Id,
                MenuItemName = menuItem.MenuItemName,
                MenuItemPrice = menuItem.MenuItemPrice,
                MenuImage = menuItem.MenuImage,
            };

            if(menuItemModel == null)
            {
                return NotFound();
            }

            return View(menuItem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Speaker speaker = new Speaker
                {
                    SpeakerName = model.SpeakerName,
                    Qualification = model.Qualification,
                    Experience = model.Experience,
                    SpeakingDate = model.SpeakingDate,
                    SpeakingTime = model.SpeakingTime,
                    Venue = model.Venue,
                    ProfilePicture = uniqueFileName
                };

                db.Add(speaker);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
