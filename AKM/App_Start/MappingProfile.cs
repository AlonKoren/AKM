using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AKM.Dtos;
using AKM.Models;
using AutoMapper;

namespace AKM.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}