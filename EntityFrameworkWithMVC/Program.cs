using Day_18___EntityFrameworkWithMVC.Extra;
using Day_18___EntityFrameworkWithMVC.MyDbContext;
using Microsoft.EntityFrameworkCore;

namespace Day_18___EntityFrameworkWithMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Entity Framework
            builder.Services.AddDbContext<StudentMS>(
             option => option.UseSqlServer(@"Data Source=.;Database=StudentMS;Integrated Security=True;")
             );


            // Dependency Injection and Inversion of Control
            builder.Services.AddSingleton<IDependency, Dependency1>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}