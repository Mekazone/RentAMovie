﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RentAMovie.Models;
using RentAMovie.Dtos;

namespace RentAMovie.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            //Dto to Domain
            //ForMember in this case is used to tell AutoMapper to ignore Id while mapping. In some cases, it causes an exception
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore()); 
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}