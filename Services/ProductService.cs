
using EasyShop.Data;
using EasyShop.Dtos;
using EasyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Services;

public class ProductService
{
    private readonly ProductDbContext _db;

    public ProductService(ProductDbContext db)
    {
        _db = db;
    }

    public async Task<List<Product>> FindAll() =>
        await _db.Products.ToListAsync();
    public async Task<Product> FindById(Guid id) =>
        await _db.Products.FirstOrDefaultAsync(p => p.Id == id);

    public async Task<Guid> Create(CreateProduct productDto)
    {
        var productEntity = new Product(Guid.NewGuid(),
                                    productDto.name,
                                    productDto.supplier,
                                    productDto.category,
                                    productDto.quantityPerUnit,
                                    productDto.pricePerUnit,
                                    productDto.unitsInStock,
                                    false);

        await _db.AddAsync(productEntity);
        await _db.SaveChangesAsync();
        return productEntity.Id;
    }

    public async Task Update(UpdateProduct productDto, Guid id)
    {
        var productEntity = await _db.Products.SingleOrDefaultAsync(t => t.Id == id);
        productEntity.Name = productDto.name;
        productEntity.Supplier = productDto.supplier;
        productEntity.Category = productDto.category;
        productEntity.QuantityPerUnit = productDto.quantityPerUnit;
        productEntity.PricePerUnit = productDto.pricePerUnit;
        productEntity.UnitsInStock = productDto.unitsInStock;

        _db.Update(productEntity);
        await _db.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var productEntity = await _db.Products.SingleOrDefaultAsync(t => t.Id == id);
        _db.Remove(productEntity);
        await _db.SaveChangesAsync();
    }
}