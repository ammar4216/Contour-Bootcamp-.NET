using Day_9___Asp.NET_MVC.Models;
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

        public ActionResult submit(Login login)
        {
            ViewBag.Email = login.Email;
            ViewBag.Password = login.Password;

            if (login.Email == "admin@gmail.com" || login.Password == "admin")
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