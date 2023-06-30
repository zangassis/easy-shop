namespace EasyShop.Dtos;

public record ProductDto(Guid? id, string? name, string? supplier, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);