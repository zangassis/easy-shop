namespace EasyShop.Models.Dtos;

public class ProductDto
{
    public Guid? Id { get; set; }
    public string? Identifier { get; set; }
    public string? Seller { get; set; }
    public string? Category { get; set; }
    public string? QuantityPerUnit { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? UnitsInStock { get; set; }
    public bool? Available { get; set; }
}