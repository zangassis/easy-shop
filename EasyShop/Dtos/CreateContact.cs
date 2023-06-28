namespace Dtos;

public record CreateContact(string? name, string? supplier, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);