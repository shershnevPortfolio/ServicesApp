using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ServicesApp.Core.Commands;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;

namespace SocialMedia.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<RegisterCommand, User>();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<CreateOrderCommand, Order>();
        }
    }
}