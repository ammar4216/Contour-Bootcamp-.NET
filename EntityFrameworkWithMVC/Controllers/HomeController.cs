using Day_18___EntityFrameworkWithMVC.Extra;
using Day_18___EntityFrameworkWithMVC.Models;
using Day_18___EntityFrameworkWithMVC.MyDbContext;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day_18___EntityFrameworkWithMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        // Dependency Injection and Inversion of Control
        private StudentMS _studentMS;

        public HomeController(ILogger<HomeController> logger, StudentMS studentMS)
        {
            _studentMS = studentMS;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Insert
            Address[] myArray =
            {
                new Address() { City = "Sydney", Country = "Australia" },
                new Address() { City = "Berlin", Country = "Germany" },
                new Address() { City = "Islamabad", Country = "Pakistan" },
                new Address() { City = "New Delhi", Country = "India" },
                new Address() { City = "New York", Country = "USA" }
            };
           

            for (var i = 0; i < myArray.Length; i++)
            {
                _studentMS.addresses.Add(myArray[i]);
            }

            //_studentMS.SaveChanges();


            // Fetch
            var result = _studentMS.addresses.ToList();

            foreach (var address in result)
            {
                Console.WriteLine(address.City);
                Console.WriteLine(address.Country);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}