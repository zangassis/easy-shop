namespace EasyShop.Data.Profiles;
using AutoMapper;
using EasyShop.Dtos;
using EasyShop.Models;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
        .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
        .ForMember(des => des.name, opt => opt.MapFrom(src => src.Name))
        .ForMember(des => des.supplier, opt => opt.MapFrom(src => src.Supplier))
        .ForMember(des => des.quantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
        .ForMember(des => des.pricePerUnit, opt => opt.MapFrom(src => src.PricePerUnit))
        .ForMember(des => des.unitsInStock, opt => opt.MapFrom(src => src.UnitsInStock));
    }
}