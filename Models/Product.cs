namespace EasyShop.Models;

public class Product
{
    public Product() { }

    public Product(Guid id, string? name, string? supplier, string? category, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock, bool? available)
    {
        Id = id;
        Name = name;
        Supplier = supplier;
        Category = category;
        QuantityPerUnit = quantityPerUnit;
        PricePerUnit = pricePerUnit;
        UnitsInStock = unitsInStock;
        Available = available;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Supplier { get; set; }
    public string? Category { get; set; }
    public string? QuantityPerUnit { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? UnitsInStock { get; set; }
    public bool? Available { get; set; }
}