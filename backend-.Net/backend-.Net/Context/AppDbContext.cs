using backend_.Net.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_.Net.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Objeto> objeto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Objeto>(entity =>
            {
                entity.ToTable("objeto");
            });
        }
    }
}
