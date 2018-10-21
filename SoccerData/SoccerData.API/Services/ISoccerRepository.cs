using SoccerData.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Services
{
    public interface ISoccerRepository
    {
        IEnumerable<CompetitionWithoutDetailsDto> GetCompetitions();
        CompetitionWithoutDetailsDto GetCompetition(int competitionId);
        MatchdayDto GetMatchday(int competitionId, int matchday);
        MatchDto GetMatch(int matchId);
        IEnumerable<StandingDto> GetStandings(int competitionId);
    }
}
