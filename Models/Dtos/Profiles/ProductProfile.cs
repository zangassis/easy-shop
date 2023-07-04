namespace EasyShop.Models.Dtos.Profiles;
using AutoMapper;
using EasyShop.Models.Dtos;
using EasyShop.Models;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
        .ForMember(des => des.Id, opt => opt.MapFrom(src => src.Id))
        .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Name))
        .ForMember(des => des.Supplier, opt => opt.MapFrom(src => src.Supplier))
        .ForMember(des => des.QuantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
        .ForMember(des => des.PricePerUnit, opt => opt.MapFrom(src => src.PricePerUnit))
        .ForMember(des => des.UnitsInStock, opt => opt.MapFrom(src => src.UnitsInStock))
        .ForMember(des => des.Available, opt => opt.MapFrom(src => src.Available));
    }
}