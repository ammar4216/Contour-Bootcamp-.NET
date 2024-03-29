using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurentMS_Final_Project.Data;
using RestaurentMS_Final_Project.Helpers;
using RestaurentMS_Final_Project.Interfaces;
using RestaurentMS_Final_Project.Models;
using RestaurentMS_Final_Project.Services;

namespace RestaurentMS_Final_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RestaurentMSDbContext>(
               op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );

            builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<RestaurentMSDbContext>().AddDefaultTokenProviders();

            //builder.Services.ConfigureApplicationCookie(
            //    opt =>
            //    {
            //        opt.ExpireTimeSpan = TimeSpan.FromMinutes(60);
            //        opt.LoginPath = "/Account/Login";
            //        opt.SlidingExpiration = true;

            //    }

            //    ) ;

            builder.Services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // SendGrid Email Service
            builder.Services.AddTransient<ISendGridEmail, SendGridEmail>();
           

            //Custom Services
            builder.Services.AddScoped<IPaymentRepo, PaymentTypeService>();
            builder.Services.AddScoped<IMenuItemRepo, MenuItemService>();
            builder.Services.AddTransient<IOrderService, OrderService>();
            builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration.GetSection("SendGrid"));




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}