using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgramingCompetition.DAL;
using ProgramingCompetition.DAL.Models;
using ProgramingCompetition.Shared.DTOs.Cards;
using ProgramingCompetition.Shared.DTOs.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingCompetition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengesController : ControllerBase
    {
        private readonly ILogger<ChallengesController> _logger;
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public ChallengesController(
            ILogger<ChallengesController> logger,
            AppDbContext dbContext,
            IMapper mapper)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
        }       
        [HttpGet]
        public async Task<ActionResult<List<ChallengeListItem>>> Get()
        {
            _logger.LogInformation("Getting all coding tasks");

            var challenges = await _dbContext.Challenges.ToListAsync();
            return _mapper.Map<List<ChallengeListItem>>(challenges);
            
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ChallengeCard>> Get(int id)
        {
            var challenge = await _dbContext.Challenges.FirstOrDefaultAsync(x => x.Id == id);

            if (challenge == null)
            {
                return NotFound();
            }

            return _mapper.Map<ChallengeCard>(challenge);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ChallengeCard challengeCard)
        {
            var challenge = _mapper.Map<Challenge>(challengeCard);
            _dbContext.Challenges.Add(challenge); 
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}

//fake data
//return new List<ChallengeListItem>() { new ChallengeListItem()
//{
//    Id = 1,
//    UserName = "Todd",
//    TaskTypes = new List<ClassificatorTaskTypeListItem>(){ new ClassificatorTaskTypeListItem { Id = 1, TaskTitle = "SomeTitle", TaskDescription = "SomeDescription" } },
//    Rootobject = new RootObjectListItem { Id = Guid.NewGuid(), SolutionScript = "SomeSolutionScript"},
//}};           