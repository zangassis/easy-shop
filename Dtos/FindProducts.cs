namespace EasyShop.Dtos;

public record FindProducts(Guid? id, string? name, string? supplier, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);