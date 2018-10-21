using Microsoft.AspNetCore.Mvc;
using SoccerData.API.Models;
using SoccerData.API.Services;
using SoccerData.API.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Controllers
{
    [Route("api/competitions")]
    public class MatchdayController : Controller
    {
        ISoccerRepository _soccerRepository;

        public MatchdayController(ISoccerRepository repo)
        {
            _soccerRepository = repo;
        }

        [HttpGet("{competitionId}/matches")]
        public IActionResult GetMatches(int competitionId, int matchday)
        {
            var competition = _soccerRepository.GetCompetition(competitionId);
            if (competition == null)
            {
                return NotFound();
            }

            // check matchday
            if (matchday > competition.CurrentMatchday || matchday < 1)
            {
                return BadRequest();
            }

            var matches = _soccerRepository.GetMatchday(competitionId, matchday);
            if (matches == null)
            {
                return NotFound();
            }

            return Ok(matches);
        }
    }
}
