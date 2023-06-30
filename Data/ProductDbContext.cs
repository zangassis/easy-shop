using EasyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Data;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
