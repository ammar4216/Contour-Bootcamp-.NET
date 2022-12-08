using AuthenticationWithJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationWithJWT.Data
{
    public class IdentityAuthDB : DbContext
    {
        public IdentityAuthDB(DbContextOptions<IdentityAuthDB> options) : base(options)
        {

        }

        public DbSet<Login> identityAuthDBs { get; set; }
    }
}
