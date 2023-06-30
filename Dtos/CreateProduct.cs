namespace EasyShop.Dtos;

public record CreateProduct(string? name, string? supplier, string? category, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);