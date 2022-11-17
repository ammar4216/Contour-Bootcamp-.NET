using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_10___Models_in_MVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult submit(Models.Registration reg)
        {
            ViewBag.Name = reg.Name;
            ViewBag.Email = reg.Email;
            ViewBag.Password = reg.Password;
            ViewBag.Phone = reg.Phone;
            ViewBag.Address = reg.Address;


            return View();
        }
    }
}