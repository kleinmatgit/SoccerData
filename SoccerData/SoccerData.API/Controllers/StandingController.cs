using Microsoft.AspNetCore.Mvc;
using SoccerData.API.Services;
using SoccerData.API.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Controllers
{
    [Route("api/competitions")]
    public class StandingController: Controller
    {
        ISoccerRepository _soccerRepository;

        public StandingController(ISoccerRepository repo)
        {
            _soccerRepository = repo;
        }

        [HttpGet("{competitionId}/standings")]
        public IActionResult GetStandings(int competitionId)
        {
            var competition = _soccerRepository.GetCompetition(competitionId);
            if (competition == null)
            {
                return NotFound();
            }

            return Ok(_soccerRepository.GetStandings(competitionId));
        }
    }
}
