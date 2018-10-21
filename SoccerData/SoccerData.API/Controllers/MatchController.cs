using Microsoft.AspNetCore.Mvc;
using SoccerData.API.Services;
using SoccerData.API.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Controllers
{
    [Route("api/matches")]
    public class MatchController: Controller
    {
        ISoccerRepository _soccerRepository;

        public MatchController(ISoccerRepository repo)
        {
            _soccerRepository = repo;
        }

        [HttpGet("{id}")]
        public IActionResult GetMatch(int id)
        {
            var match = _soccerRepository.GetMatch(id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}
