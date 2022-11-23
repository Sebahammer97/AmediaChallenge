using AmediaChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace AmediaChallenge.DatabaseContext
{
    public partial class AmediaDbContext : DbContext
    {
        public AmediaDbContext() { }

        public AmediaDbContext(DbContextOptions<AmediaDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(prop => prop.is_active).HasDefaultValue(true);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(prop => prop.is_active).HasDefaultValue(true);
            });
        }

        #region Entities
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        #endregion
    }
}
