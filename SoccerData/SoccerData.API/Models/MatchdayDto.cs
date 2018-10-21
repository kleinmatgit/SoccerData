using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Models
{
    public class MatchdayDto
    {
        public int Id { get; set; }
        public List<MatchDto> Matches { get; set; } = new List<MatchDto>();
    }
}
