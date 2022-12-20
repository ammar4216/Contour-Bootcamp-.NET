using Microsoft.EntityFrameworkCore;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Data
{
    public class RestaurentMSDbContext : DbContext
    {
        public RestaurentMSDbContext(DbContextOptions<RestaurentMSDbContext> options) : base(options) { }   

        public DbSet<MenuItem> menuItems { get; set; }

        public DbSet<MenuCategory> menuCategories { get; set; }
    }
}
