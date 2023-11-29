using FluentValidation;
using EasyShop.Models.Dtos;

namespace EasyShop.Validators;

public class ProductValidator : AbstractValidator<CreateUpdateProduct>
{
    public ProductValidator()
    {
        RuleFor(product => product.Identifier).NotEmpty().WithMessage("Identifier is required.");
        RuleFor(product => product.Seller).NotEmpty().WithMessage("Seller is required.");
        RuleFor(product => product.Category).NotEmpty().WithMessage("Category is required.");
        RuleFor(product => product.QuantityPerUnit).NotEmpty().WithMessage("QuantityPerUnit is required.");
        RuleFor(product => product.PricePerUnit).NotEmpty().WithMessage("PricePerUnit is required.");
        RuleFor(product => product.UnitsInStock).NotEmpty().WithMessage("UnitsInStock is required.");
    }
}