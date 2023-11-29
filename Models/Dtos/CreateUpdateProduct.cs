namespace EasyShop.Models.Dtos;

public record CreateUpdateProduct(string? Identifier, string? Seller, string? Category, string? QuantityPerUnit, decimal? PricePerUnit, decimal? UnitsInStock, bool Available);