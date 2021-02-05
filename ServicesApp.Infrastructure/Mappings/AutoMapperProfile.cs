using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ServicesApp.Core.Queries;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Commands;

namespace SocialMedia.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<RegisterCommand, User>();
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<CreateSubcategoryCommand, Subcategory>();
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<Order, OrderDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<Subcategory, SubcategoryDTO>();
        }
    }
}