using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Mappings
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<FormClearance.Models.FormClearance, FormClearance.Models.Dtos.FormClearanceDto>().ReverseMap();
        }
    }
}
