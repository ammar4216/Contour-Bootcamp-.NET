using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly RestaurentMSDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public UserController(RestaurentMSDbContext context, UserManager<AppUser> userManager)
        {
            _userManager= userManager;
            _context = context;
        }

        // Read User List
        public IActionResult Index()
        {
            var userList = _context.AppUser.ToList();
            var userRole = _context.UserRoles.ToList();
            var roles = _context.Roles.ToList();


            foreach (var user in userList)
            {
                var role = userRole.FirstOrDefault(u => u.UserId == user.Id);
                if (role == null)
                {
                    user.Role = "None";
                }
                else
                {
                    user.Role = roles.FirstOrDefault(u => u.Id == role.RoleId).Name;
                }
            }

            return View(userList);
        }

        // Edit User
        public IActionResult Edit(string userId)
        {
            var user = _context.AppUser.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }
            var userRole = _context.UserRoles.ToList();
            var roles = _context.Roles.ToList();
            var role = userRole.FirstOrDefault(u => u.UserId == user.Id);
            if (role != null)
            {
                user.RoleId = roles.FirstOrDefault(u => u.Id == role.RoleId).Id;
            }
            user.RoleList = _context.Roles.Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id
            });
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AppUser user)
        {
            if (ModelState.IsValid)
            {
                var userDbValue = _context.AppUser.FirstOrDefault(u => u.Id == user.Id);
                if (userDbValue == null)
                {
                    return NotFound();
                }
                var userRole = _context.UserRoles.FirstOrDefault(u => u.UserId == userDbValue.Id);
                if (userRole != null)
                {
                    var previousRoleName = _context.Roles.Where(u => u.Id == userRole.RoleId).Select(e => e.Name).FirstOrDefault();
                    await _userManager.RemoveFromRoleAsync(userDbValue, previousRoleName);

                }

                await _userManager.AddToRoleAsync(userDbValue, _context.Roles.FirstOrDefault(u => u.Id == user.RoleId).Name);
                _context.SaveChanges();
                TempData["success"] = "User updated successfully!";
                return RedirectToAction(nameof(Index));
            }


            user.RoleList = _context.Roles.Select(u => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = u.Name,
                Value = u.Id
            });
            return View(user);
        }

        // Delete User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string userId)
        {
            var user = _context.AppUser.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }
            _context.AppUser.Remove(user);
            _context.SaveChanges();
            TempData["success"] = "User deleted successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
