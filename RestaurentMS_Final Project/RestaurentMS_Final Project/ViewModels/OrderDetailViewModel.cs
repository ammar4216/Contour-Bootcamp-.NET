namespace RestaurentMS_Final_Project.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }

        public int MenuItemId { get; set; }


        public decimal ItemPrice { get; set; }

        public double Quantity { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }
    }
}
