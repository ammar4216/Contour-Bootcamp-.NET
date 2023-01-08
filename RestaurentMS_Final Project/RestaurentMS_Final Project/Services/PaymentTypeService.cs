using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Interfaces;

namespace RestaurentMS_Final_Project.Services
{
    public class PaymentTypeService : IPaymentRepo
    {
        private readonly RestaurentMSDbContext _context;

        public PaymentTypeService(RestaurentMSDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetAllPaymentTypes()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                from obj in _context.paymentTypes
                select new SelectListItem
                {
                    Value = obj.Id.ToString(),
                    Text = obj.PaymentTypeName,
                    Selected = true
                }

                ).ToList();

            return objSelectListItems;
        }

    }
}
