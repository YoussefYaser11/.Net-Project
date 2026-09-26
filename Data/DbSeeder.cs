using ProductManagementNet.Models;

namespace ProductManagementNet.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (db.Products.Any()) return;

        db.Products.AddRange(
            new Product { Name = "Apple", Description = "Fresh Apple", Price = 70 },
            new Product { Name = "Banana", Description = "Fresh Banana", Price = 30 }
        );

        db.SaveChanges();
    }
}
