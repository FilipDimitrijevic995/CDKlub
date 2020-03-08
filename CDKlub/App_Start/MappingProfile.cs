using AutoMapper;
using CDKlub.Dtos;
using CDKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDKlub.App_Start
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