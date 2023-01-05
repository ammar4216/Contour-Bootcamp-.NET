using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;
using System.Diagnostics;

namespace RestaurentMS_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RestaurentMSDbContext _context;

        public HomeController(ILogger<HomeController> logger, RestaurentMSDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Contact Form
        public IActionResult ContactIndex()
        {
            IEnumerable<ContactDetail> contactDetails = _context.contactDetails;
            return View(contactDetails);
        }


        public IActionResult ContactCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactCreate(ContactDetail contact)
        {
            if (ModelState.IsValid)
            {
                _context.contactDetails.Add(contact);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactDelete(int? id)
        {
            var user = _context.contactDetails.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            _context.contactDetails.Remove(user);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}