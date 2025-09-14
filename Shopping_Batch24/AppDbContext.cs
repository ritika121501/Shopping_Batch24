using Microsoft.EntityFrameworkCore;
using Shopping_Batch24.Models;

namespace Shopping_Batch24
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Category {  get; set; }
        public DbSet<Product> Product {  get; set; }

    }
}
