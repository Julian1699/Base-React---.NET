using backend_.Net.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_.Net.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Objeto> Objeto { get; set; }

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
