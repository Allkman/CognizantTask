using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgramingCompetition.DAL;
using ProgramingCompetition.DAL.Models;
using ProgramingCompetition.Shared.DTOs.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingCompetition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootObjectController : ControllerBase
    {
        private readonly ILogger<RootObjectController> _logger;
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public RootObjectController(ILogger<RootObjectController> logger, AppDbContext dbContext, IMapper mapper)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RootObjectCard rootObject)
        {
            var obj = _mapper.Map<RootObject>(rootObject);
            _dbContext.RootObjects.Add(obj);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
