using Microsoft.AspNetCore.Mvc;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Controllers
{
    public class ContactDetailController : Controller
    {
        private readonly RestaurentMSDbContext _context;

        private ContactDetailController(RestaurentMSDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ContactDetail> contactDetails = _context.contactDetails;
            return View(contactDetails);
        }

       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactDetail contact)
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
        public IActionResult Delete(int? id)
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
    }
}
