using Microsoft.AspNetCore.Mvc;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Controllers
{
    public class UserController : Controller
    {
        private readonly RestaurentMSDbContext _context;
        public UserController(RestaurentMSDbContext context)
        {
            _context = context;
        }

        // Read User List
        public IActionResult Index()
        {
            
            IEnumerable<AppUser> userObj = _context.AppUser;
            return View(userObj);
        }

        // Edit User
        public IActionResult Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var updateUser = _context.AppUser.Find(id);

            if (updateUser == null)
            {
                return NotFound();
            }
            return View(updateUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AppUser user)
        {
            if (ModelState.IsValid)
            {
                _context.AppUser.Update(user);
                _context.SaveChanges();
                TempData["ResultOk"] = "User Updated Successfully!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        // Delete User
        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deleteUser = _context.AppUser.Find(id);

            if (deleteUser == null)
            {
                return NotFound();
            }
            return View(deleteUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(string? id)
        {
            var deleterecord = _context.AppUser.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.AppUser.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "User Record Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
