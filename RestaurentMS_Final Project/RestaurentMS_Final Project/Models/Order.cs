namespace RestaurentMS_Final_Project.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int OrderCreatedPersonId { get; set; }

        public int MenuCategoryId { get; set; }

        public int MenuItemId { get; set; }

        public int PaymentId { get; set; }

        public DateTime OrderCreatedAt { get; set; }

        public User OrderCreatedUser { get; set; }

        public MenuCategory menuCategory { get; set; }  

        public MenuItem menuItem { get; set; }  

        public PaymentType payment { get; set; }



    }
}
