using Day_18___EntityFrameworkWithMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_18___EntityFrameworkWithMVC.MyDbContext
{
    public class StudentMS : DbContext
    {
        public StudentMS(DbContextOptions<StudentMS> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Student> students { get; set; }    

        public DbSet<Address> addresses { get; set; }
    }
}
