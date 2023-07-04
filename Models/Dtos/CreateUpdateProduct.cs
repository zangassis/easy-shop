namespace EasyShop.Models.Dtos;

public record CreateUpdateProduct(string? Name, string? Supplier, string? Category, string? QuantityPerUnit, decimal? PricePerUnit, decimal? UnitsInStock, bool Available);