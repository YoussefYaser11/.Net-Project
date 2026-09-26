using Microsoft.EntityFrameworkCore;
using ProductManagementNet.Models;

namespace ProductManagementNet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
