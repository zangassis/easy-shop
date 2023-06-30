namespace EasyShop.Dtos;

public record UpdateProduct(string? name, string? supplier, string? category, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);