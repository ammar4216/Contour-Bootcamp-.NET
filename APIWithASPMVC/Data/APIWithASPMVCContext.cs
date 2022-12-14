using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIWithASPMVC.Models;

namespace APIWithASPMVC.Data
{
    public class APIWithASPMVCContext : DbContext
    {
        public APIWithASPMVCContext (DbContextOptions<APIWithASPMVCContext> options)
            : base(options)
        {
        }

        public DbSet<APIWithASPMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
