using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginForm()
        {
            return View();
        }

        public IActionResult Submit(Models.User user)
        {
            ViewBag.Email = user.Email;
            ViewBag.Password = user.Password;

            return View();
        }

      
    }
}
