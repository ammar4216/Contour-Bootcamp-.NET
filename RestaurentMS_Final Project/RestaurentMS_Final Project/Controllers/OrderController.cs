using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Interfaces;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Controllers
{
    public class OrderController : Controller
    {
        private readonly RestaurentMSDbContext _context;
        private readonly IPaymentRepo _payment;
        private readonly IMenuItemRepo _menu;
        private readonly IOrderService _orderService;

        public OrderController(RestaurentMSDbContext context, IPaymentRepo payment, IMenuItemRepo menu, IOrderService orderService)
        {
            _context = context; 
            _payment = payment;
            _menu = menu;
            _orderService = orderService;
        }

        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Index()
        {
            IEnumerable<Order> orders = _context.orders;
            return View(orders);
        }


        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create() {

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (_payment.GetAllPaymentTypes(), _menu.GetAllMenuItems());

            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal UnitPrice = _context.menuItems.Single(model => model.Id == itemId).MenuItemPrice;
            return Json(UnitPrice);
        }


        [HttpPost]
        [Authorize(Roles = "Admin,Employee")]
        public JsonResult Create([FromBody] OrderViewModel orderViewModel)
        {

            bool isStatus = _orderService.AddOrder(orderViewModel);
            string SuccessMessage = String.Empty;

            if (isStatus)
            {
                SuccessMessage = "Your Order Has Been Successfully Placed.";
            }
            else
            {
                SuccessMessage = "There Is Some Issue While Placing the Order.";
            }

            return Json(SuccessMessage);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? Id)
        {
            var order = _context.orders.FirstOrDefault(u => u.Id == Id);
            if (order == null)
            {
                return NotFound();
            }
            _context.orders.Remove(order);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
