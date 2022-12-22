using Microsoft.EntityFrameworkCore;
using RestaurentMS_Final_Project.Models;

namespace RestaurentMS_Final_Project.Data
{
    public class RestaurentMSDbContext : DbContext
    {
        public RestaurentMSDbContext(DbContextOptions<RestaurentMSDbContext> options) : base(options) { }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return (await base.SaveChangesAsync(acceptAllChangesOnSuccess,
                          cancellationToken));
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var utcNow = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                if (entry.Entity is TimeStampClass trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.UpdatedAt = utcNow;
                            entry.Property("CreatedOn").IsModified = false;
                            break;

                        case EntityState.Added:
                            trackable.CreatedAt = utcNow;
                            trackable.UpdatedAt = utcNow;
                            break;
                    }
                }
            }
        }

        public DbSet<MenuItem> menuItems { get; set; }

        public DbSet<MenuCategory> menuCategories { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<Address> addresses { get; set; }

        public DbSet<Roles> roles { get; set; }

        public DbSet<PaymentType> paymentTypes { get; set; }

        public DbSet<Reservation> reservations { get; set; }

        public DbSet<Order> orders { get; set; }
    }
}
