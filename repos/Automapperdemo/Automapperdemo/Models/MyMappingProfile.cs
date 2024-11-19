using AutoMapper;
using Automapperdemo.Models;

namespace AutomapperDemo.Models
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {
            //Configure the Mappings
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
        }
    }
}