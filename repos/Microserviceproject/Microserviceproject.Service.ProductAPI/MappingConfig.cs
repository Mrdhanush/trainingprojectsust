using AutoMapper;
using Microserviceproject.Service.ProductAPI.Models.Dto;
using Microserviceproject.Services.ProductAPI.Models;


namespace Mango.Services.ProductAPI

{

    public class MappingConfig

    {

        public static MapperConfiguration RegisterMaps()

        {

            var mappingConfig = new MapperConfiguration(config =>

            {

                config.CreateMap<ProductDto, Product>().ReverseMap();

            });

            return mappingConfig;

        }

    }

}







