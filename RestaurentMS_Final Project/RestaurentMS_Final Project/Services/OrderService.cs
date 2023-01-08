using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Interfaces;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Services
{
    public class OrderService : IOrderService
    {
        private readonly RestaurentMSDbContext _context;

        public OrderService(RestaurentMSDbContext context)
        {
            _context = context;
        }

        public bool AddOrder(OrderViewModel orderViewModel)
        {
            try
            {
                Order order = new Order()
                {
                    CustomerName = orderViewModel.CustomerName,
                    FinalTotal = orderViewModel.FinalTotal,
                    OrderDate = orderViewModel.OrderDate,
                    OrderNumber = String.Format("{0:ddmmyyyyhhmmss}", DateTime.Now),
                    PaymentId = orderViewModel.PaymentTypeId
                };

                _context.orders.Add(order);
                _context.SaveChanges();

                foreach(var item in orderViewModel.listOrderDetailViewModel)
                {
                    var orderdetail = new OrderDetail()
                    {
                        MenuItemId= item.MenuItemId,
                        OrderId = order.Id,
                        Discount = item.Discount,
                        Total= item.Total,
                        ItemPrice = item.ItemPrice,
                        Quantity = item.Quantity,

                    };

                    _context.orderDetail.Add(orderdetail);
                    _context.SaveChanges();
                    
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
