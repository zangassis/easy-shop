using FluentValidation;
using EasyShop.Models.Dtos;

namespace EasyShop.Validators;

public class ProductValidator : AbstractValidator<CreateUpdateProduct>
{
    public ProductValidator()
    {
        RuleFor(product => product.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(product => product.Supplier).NotEmpty().WithMessage("Supplier is required.");
        RuleFor(product => product.Category).NotEmpty().WithMessage("Category is required.");
        RuleFor(product => product.QuantityPerUnit).NotEmpty().WithMessage("QuantityPerUnit is required.");
        RuleFor(product => product.PricePerUnit).NotEmpty().WithMessage("PricePerUnit is required.");
        RuleFor(product => product.UnitsInStock).NotEmpty().WithMessage("UnitsInStock is required.");
    }
}