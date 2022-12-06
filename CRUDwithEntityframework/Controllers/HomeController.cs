using CRUDwithEntityframework.Models;
using CRUDwithEntityframework.MyDbContext;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDwithEntityframework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CustomerMS _customerMS;

        public HomeController(ILogger<HomeController> logger, CustomerMS customerMS)
        {
            _customerMS = customerMS;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer model)
        {

            if (ModelState.IsValid)
            {
                _customerMS.customers.Add(model);

                _customerMS.SaveChanges();

            }
            else
            {

                return View("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Read()
        {
                var data = _customerMS.customers.ToList();
                return View(data);
        }

        [HttpGet]
        public ActionResult Update(int customer_id)
        {
    
                var data = _customerMS.customers.Where(x => x.Customer_Id == customer_id).SingleOrDefault();
                return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int customer_id, Customer model)
        {

                var data = _customerMS.customers.FirstOrDefault(x => x.Customer_Id == customer_id);

                if (data != null)
                {
                    data.Customer_Name = model.Customer_Name;
                    data.DOB = model.DOB;
                    data.Phone_Number = model.Phone_Number;
                    data.Customer_Email = model.Customer_Email;
                _customerMS.SaveChanges();

                    return RedirectToAction("Read");
                }
                else
                    return View();
            }


        //public IActionResult Privacy()
        //{
        //    return View();
        //}



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}