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
    public class ChallengeProfile : Profile
    {
        public ChallengeProfile()
        {
            CreateMap<Challenge, ChallengeCard>().IncludeMembers(s => s.Rootobject).ReverseMap();
            CreateMap<ChallengeCard, Challenge>().IncludeMembers(s => s.Rootobject).ReverseMap();
            CreateMap<RootObject, ChallengeCard>();
            CreateMap<Challenge, ChallengeListItem>().ReverseMap();
        }
    }
}
