using EasyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Data;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
                new Product(Guid.NewGuid(), "Wireless Mouse ABX", "ABX", "Electronics", "1 unit", 999.99m, 100, true),
                new Product(Guid.NewGuid(), "Computer Monitor FHD 1080P", "NewHD", "Electronics", "1 unit", 899.99m, 50, true),
                new Product(Guid.NewGuid(), "Athletic Running Tennis Shoes", "BestShoes", "Shoes", "1 pair", 129.99m, 200, true)
        );
    }
}
