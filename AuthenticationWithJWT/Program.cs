using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using AuthenticationWithJWT.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationWithJWT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<IdentityAuthDB>(
                option => option.UseSqlServer(@"Data Source=.;Database=IdentityAuthDB;Integrated Security=True;")
                );

            builder.Services.AddAuthorization(
                option => option.AddPolicy("IsAdmin", policy =>
                {
                    policy.RequireClaim("MyRole", "Admin");
                }
                ));

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dsagfdsgdsgdsgdsgdsgdagdsgdsfeawfascxzcfaess")),
            };
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                var token = context.Request.Cookies["Token"];
                context.Request.Headers.Add("Authorization", "Bearer " + token);
                await next();
            });

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