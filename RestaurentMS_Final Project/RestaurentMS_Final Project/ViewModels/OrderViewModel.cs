using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal FinalTotal { get; set; }

        public int PaymentTypeId { get; set; }

        public IEnumerable<OrderDetailViewModel> listOrderDetailViewModel { get; set; }

    }
}
