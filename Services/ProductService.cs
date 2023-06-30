
using EasyShop.Data;
using EasyShop.Dtos;
using EasyShop.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace EasyShop.Services;

public class ProductService
{
    private readonly ProductDbContext _db;
    private readonly IMapper _mapper;

    public ProductService(ProductDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> FindAll()
    {
        var products = await _db.Products.ToListAsync();
        var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products).ToList();
        return productsDto;
    }

    public async Task<ProductDto> FindById(Guid id)
    {
        var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }

    public async Task<Guid> Create(CreateUpdateProduct productDto)
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

    public async Task Update(CreateUpdateProduct productDto, Guid id)
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