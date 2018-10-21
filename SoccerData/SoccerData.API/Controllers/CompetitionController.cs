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
    public class CompetitionController: Controller
    {
        private ISoccerRepository _soccerRepository;

        public CompetitionController(ISoccerRepository repo)
        {
            _soccerRepository = repo;
        }

        [HttpGet()]
        public IActionResult GetCompetitions()
        {
            var competitions = _soccerRepository.GetCompetitions();
            return Ok(competitions);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompetition(int id)
        {
            var competition = _soccerRepository.GetCompetition(id);
            if (competition == null)
            {
                return NotFound();
            }

            return Ok(competition);
        }
    }
}
