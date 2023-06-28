namespace Dtos;

public record UpdateContact(string? name, string? supplier, string? quantityPerUnit, decimal? pricePerUnit, decimal? unitsInStock);