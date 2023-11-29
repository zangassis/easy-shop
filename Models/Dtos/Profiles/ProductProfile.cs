namespace EasyShop.Models.Dtos.Profiles;
using AutoMapper;
using EasyShop.Models.Dtos;
using EasyShop.Models;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
        .ForMember(des => des.Identifier, opt => opt.MapFrom(src => src.Name))
        .ForMember(des => des.Seller, opt => opt.MapFrom(src => src.Supplier))
        .ReverseMap();
    }
}