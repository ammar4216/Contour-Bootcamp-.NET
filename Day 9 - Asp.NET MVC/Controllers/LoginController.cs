using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_9___Asp.NET_MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult submit(string Email, string Password)
        {
            ViewBag.Email = Email;
            ViewBag.Password = Password;

            if (Email == "admin@gmail.com" || Password == "admin")
            {
                return View("welcome");
            }
            else
            {
                return View();
            }
            

            
        }
    }
}