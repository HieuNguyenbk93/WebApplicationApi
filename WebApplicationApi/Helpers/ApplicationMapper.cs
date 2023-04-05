﻿using AutoMapper;
using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Department, DepartmentModel>().ReverseMap();
        }
        
    }
}
