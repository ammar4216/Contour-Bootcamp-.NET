using RestaurentMS_Final_Project.ViewModels;

namespace RestaurentMS_Final_Project.Interfaces
{
    public interface IOrderService
    {
        public bool AddOrder(OrderViewModel orderViewModel);
    }
}
