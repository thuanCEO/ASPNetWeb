
using AutoMapper;
using UOW.Core.Entities;
using UOW.Service.DTO;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AccountDTO, Account>().ReverseMap();
        CreateMap<CategoryDTO, Category>().ReverseMap();
        CreateMap<CustomerDTO, Customer>().ReverseMap();
        CreateMap<OrderDTO, Order>().ReverseMap();
        CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();
        CreateMap<ProductDTO, Product>().ReverseMap();
        CreateMap <SupplierDTO, Supplier>().ReverseMap();
    }
}
