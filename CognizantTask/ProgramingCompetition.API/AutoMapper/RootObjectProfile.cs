using AutoMapper;
using ProgramingCompetition.DAL.Models;
using ProgramingCompetition.Shared.DTOs.Cards;
using ProgramingCompetition.Shared.DTOs.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingCompetition.API.AutoMapper
{
    public class RootObjectProfile :Profile
    {
        public RootObjectProfile()
        {
            CreateMap<RootObject, RootObjectCard>().ReverseMap();
            CreateMap<RootObject, RootObjectListItem>().ReverseMap();
            CreateMap<RootObjectListItem, Challenge>().ReverseMap().IncludeMembers(x => x.Rootobject);


        }
    }
}
