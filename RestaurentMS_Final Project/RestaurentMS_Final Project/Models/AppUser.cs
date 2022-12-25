using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RestaurentMS_Final_Project.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
