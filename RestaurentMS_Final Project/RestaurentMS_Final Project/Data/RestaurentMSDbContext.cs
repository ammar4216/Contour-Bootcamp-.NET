using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Data
{
    public class RestaurentMSDbContext : IdentityDbContext<AppUser>
    {
        public RestaurentMSDbContext(DbContextOptions<RestaurentMSDbContext> options) : base(options) { }


        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<MenuItem> menuItems { get; set; }

        public DbSet<MenuCategory> menuCategories { get; set; }

        public DbSet<PaymentType> paymentTypes { get; set; }

        public DbSet<Reservation> reservations { get; set; }

        public DbSet<OrderDetail> orderDetail { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<ContactDetail> contactDetails { get; set; }
    }
}
