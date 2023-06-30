namespace EasyShop.Dtos;

public record CreateUpdateProduct(string? name, string? supplier, string? category, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);