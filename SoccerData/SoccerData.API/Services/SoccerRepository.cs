using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerData.API.Models;
using SoccerData.API.Stores;

namespace SoccerData.API.Services
{
    public class SoccerRepository : ISoccerRepository
    {
        public CompetitionWithoutDetailsDto GetCompetition(int competitionId)
        {
            var competition = CompetitionDataStore.Current.Competitions.FirstOrDefault(c => c.Id == competitionId);
            if (competition == null)
            {
                return null;
            }

            return new CompetitionWithoutDetailsDto()
            {
                Id = competition.Id,
                Name = competition.Name,
                CurrentMatchday = competition.CurrentMatchday
            };

        }

        public IEnumerable<CompetitionWithoutDetailsDto> GetCompetitions()
        {
            var competitionsWithoutDetails = new List<CompetitionWithoutDetailsDto>();

            foreach (var competition in CompetitionDataStore.Current.Competitions)
            {
                competitionsWithoutDetails.Add(
                    new CompetitionWithoutDetailsDto()
                    {
                        Id = competition.Id,
                        Name = competition.Name,
                        CurrentMatchday = competition.CurrentMatchday
                    });
            }

            return competitionsWithoutDetails;
        }

        public MatchDto GetMatch(int matchId)
        {
            return CompetitionDataStore.Current.Competitions
                .SelectMany(c => c.Matchdays)
                .SelectMany(m => m.Matches)
                .FirstOrDefault(m => m.Id == matchId);
        }

        public MatchdayDto GetMatchday(int competitionId, int matchday)
        {
            var competition = CompetitionDataStore.Current.Competitions.FirstOrDefault(c => c.Id == competitionId);
            var matches = competition.Matchdays.ElementAt(matchday - 1);
            return matches;
        }

        public IEnumerable<StandingDto> GetStandings(int competitionId)
        {
            var competition = CompetitionDataStore.Current.Competitions.FirstOrDefault(c => c.Id == competitionId);
            if (competition == null)
            {
                return null;
            }

            return competition.Standings;
        }
    }
}
