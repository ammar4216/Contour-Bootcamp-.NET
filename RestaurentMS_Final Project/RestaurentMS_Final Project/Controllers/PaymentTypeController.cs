using Microsoft.AspNetCore.Mvc;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Controllers
{
    public class PaymentTypeController : Controller
    {
        private readonly RestaurentMSDbContext _context;

        public PaymentTypeController(RestaurentMSDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<PaymentType> paymentObj = _context.paymentTypes;
            return View(paymentObj);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PaymentType paymentObj)
        {
            var record = _context.paymentTypes.Where(x => x.PaymentTypeName == paymentObj.PaymentTypeName).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (record != null)
                {
                    return View();
                }
                else
                {
                    _context.paymentTypes.Add(paymentObj);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(paymentObj);
        }




        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var deletePayment = _context.paymentTypes.Find(id);

            if (deletePayment == null)
            {
                return NotFound();
            }
            return View(deletePayment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePayment(int? id)
        {
            var deleterecord = _context.paymentTypes.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.paymentTypes.Remove(deleterecord);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
