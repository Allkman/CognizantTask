using AutoMapper;
using ProgramingCompetition.DAL.Models;
using ProgramingCompetition.Shared.DTOs.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingCompetition.API.AutoMapper
{
    public class ClassificatorTaskTypeProfile : Profile
    {
        public ClassificatorTaskTypeProfile()
        {
            CreateMap<ClassificatorTaskType, ClassificatorTaskTypeListItem>().ReverseMap();

        }
    }
}
