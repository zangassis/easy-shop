namespace EasyShop.Models.Dtos;

public record ProductDto(Guid? Id, string? Name, string? Supplier, string? Category, string? QuantityPerUnit, decimal? PricePerUnit, decimal? UnitsInStock, bool Available);