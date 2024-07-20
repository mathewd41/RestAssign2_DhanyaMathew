using AutoMapper;
using RestAssign2_DhanyaMathew.Dtos;
using RestAssign2_DhanyaMathew.Entities;

namespace RestAssign2_DhanyaMathew.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}