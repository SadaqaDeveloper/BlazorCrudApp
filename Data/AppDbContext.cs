using BlazorCrudApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
