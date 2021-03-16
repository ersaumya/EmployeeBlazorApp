using AutoMapper;
using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EditEmployeeModel>()
                .ForMember(dest =>dest.ConfirmEmail,opt=>opt.MapFrom(src=>src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}
