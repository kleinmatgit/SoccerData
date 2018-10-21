using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Models
{
    public class CompetitionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentMatchday { get; set; }
        public List<MatchdayDto> Matchdays { get; set; }
        public List<StandingDto> Standings { get; set; }
    }
}
