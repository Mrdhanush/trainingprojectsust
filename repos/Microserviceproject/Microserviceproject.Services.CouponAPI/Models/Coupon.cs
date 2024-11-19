using AutoMapper;
using Azure;
using Microserviceproject.Services.CouponAPI.Data;
using Microserviceproject.Services.CouponAPI.Models.Dto;
using Microserviceproject.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Microserviceproject.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }

    }
}
