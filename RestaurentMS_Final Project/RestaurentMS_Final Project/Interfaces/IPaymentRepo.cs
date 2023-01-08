using Microsoft.AspNetCore.Mvc.Rendering;

namespace RestaurentMS_Final_Project.Interfaces
{
    public interface IPaymentRepo
    {
        public IEnumerable<SelectListItem> GetAllPaymentTypes();
    }
}
