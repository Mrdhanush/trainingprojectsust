using AutoMapper;
using Microserviceproject.Services.CouponAPI.Models;
using Microserviceproject.Services.CouponAPI.Models.Dto;

namespace Microserviceproject.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<CouponDto, Coupon>();
                Config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}