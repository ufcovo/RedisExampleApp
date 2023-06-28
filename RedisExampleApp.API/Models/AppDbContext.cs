using Microsoft.EntityFrameworkCore;

namespace RedisExampleApp.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Pencil 1", Price = 10 },
                new Product() { Id = 2, Name = "Pencil 2", Price = 11 },
                new Product() { Id = 3, Name = "Pencil 3", Price = 12 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
