using CRUDwithEntityframework.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDwithEntityframework.MyDbContext
{
    public class CustomerMS : DbContext
    {

        public CustomerMS(DbContextOptions<CustomerMS> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Customer> customers { get; set; }

        public DbSet<Address> addresses { get; set; }
    }
}
