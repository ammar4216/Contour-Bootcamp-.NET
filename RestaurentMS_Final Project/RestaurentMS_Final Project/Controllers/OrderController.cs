using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Interfaces;
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
        public IActionResult Index()
        {

            //var menuItems = _context.menuItems.ToList();

            //var payments = _context.paymentTypes.ToList();


            //OrderViewModel orders = new OrderViewModel()
            //{
            //    MenuItems = menuItems,
            //    payment = new List<SelectListItem>()
            //};

            //foreach (var item in payments)
            //{
            //    orders.payment.Add(new SelectListItem()
            //    {
            //        Value = item.Id.ToString(),
            //        Text = item.PaymentTypeName
            //    }
            //    );

            //}

            //return View(orders);

            return View();
        }



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
        public JsonResult Create(OrderViewModel orderViewModel)
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

    }
}
