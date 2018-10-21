using SoccerData.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerData.API.Stores
{
    public class CompetitionDataStore
    {
        public static CompetitionDataStore Current { get; } = new CompetitionDataStore();

        public List<CompetitionDto> Competitions { get; set; }

        public CompetitionDataStore()
        {
            Competitions = new List<CompetitionDto>()
            {
                // Ligue1
                new CompetitionDto()
                {
                    Id = 0,
                    Name = "Ligue1",
                    CurrentMatchday = 3,
                    Matchdays = new List<MatchdayDto>()
                    {
                        // matchday1
                        new MatchdayDto()
                        {
                            Id = 1,
                            Matches = new List<MatchDto>()
                            {
                                new MatchDto()
                                {
                                    Id = 0,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 0, Name = "Paris Saint-Germain", ShortName = "PSG"},
                                    AwayTeam = new TeamDto() { Id = 1, Name = "Olympique Marseille", ShortName = "Marseille"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 1,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 2, Name = "OGC Nice", ShortName = "Nice"},
                                    AwayTeam = new TeamDto() { Id = 3, Name = "Olympique Lyonnais", ShortName = "Lyon"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 2,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 4, Name = "Rennes", ShortName = "Rennes"},
                                    AwayTeam = new TeamDto() { Id = 5, Name = "FC Nantes Atlantique", ShortName = "Nantes"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                }
                            }
                        },

                        // matchday2
                        new MatchdayDto()
                        {
                            Id = 2,
                            Matches = new List<MatchDto>()
                            {
                                new MatchDto()
                                {
                                    Id = 3,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 0, Name = "Paris Saint-Germain", ShortName = "PSG"},
                                    AwayTeam = new TeamDto() { Id = 2, Name = "OGC Nice", ShortName = "Nice"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 4,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 1, Name = "Olympique Marseille", ShortName = "Marseille"},
                                    AwayTeam = new TeamDto() { Id = 3, Name = "Olympique Lyonnais", ShortName = "Lyon"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 5,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 6, Name = "En Avant Guingamp", ShortName = "Guingamp"},
                                    AwayTeam = new TeamDto() { Id = 5, Name = "FC Nantes Atlantique", ShortName = "Nantes"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                }
                            }
                        },

                        // matchday3
                        new MatchdayDto()
                        {
                            Id = 3,
                            Matches = new List<MatchDto>()
                            {
                                new MatchDto()
                                {
                                    Id = 6,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 0, Name = "Paris Saint-Germain", ShortName = "PSG"},
                                    AwayTeam = new TeamDto() { Id = 3, Name = "Olympique Lyonnais", ShortName = "Lyon"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 7,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 1, Name = "Olympique Marseille", ShortName = "Marseille"},
                                    AwayTeam = new TeamDto() { Id = 6, Name = "En Avant Guingamp", ShortName = "Guingamp"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 8,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 7, Name = "Amiens", ShortName = "Amiens"},
                                    AwayTeam = new TeamDto() { Id = 8, Name = "Girondins Bordeaux", ShortName = "Bordeaux"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                }
                            }
                        }
                    },
                    Standings = new List<StandingDto>()
                    {
                        new StandingDto()
                        {
                            Position = 1,
                            Team = new TeamDto(){ Id = 0, Name = "Paris Saint-Germain", ShortName = "PSG"},
                            PlayedGames = 3,
                            Won = 3,
                            Draw = 0,
                            Lost = 0,
                            Points = 9,
                            GoalsAgainst = 0,
                            GoalsFor = 10,
                            GoalDifference = 10
                        },
                        new StandingDto()
                        {
                            Position = 2,
                            Team = new TeamDto(){ Id = 3, Name = "Olympique Lyonnais", ShortName = "Lyon"},
                            PlayedGames = 3,
                            Won = 2,
                            Draw = 0,
                            Lost = 1,
                            Points = 6,
                            GoalsAgainst = 3,
                            GoalsFor = 6,
                            GoalDifference = 3
                        },
                        new StandingDto()
                        {
                            Position = 3,
                            Team = new TeamDto(){ Id = 6, Name = "En Avant Guingamp", ShortName = "Guingamp"},
                            PlayedGames = 3,
                            Won = 1,
                            Draw = 2,
                            Lost = 0,
                            Points = 5,
                            GoalsAgainst = 0,
                            GoalsFor = 1,
                            GoalDifference = 1
                        },
                    }
                },

                // LaLiga
                new CompetitionDto()
                {
                    Id = 1,
                    Name = "LaLiga",
                    CurrentMatchday = 2,
                    Matchdays = new List<MatchdayDto>()
                    {
                        // matchday1
                        new MatchdayDto()
                        {
                            Id = 1,
                            Matches = new List<MatchDto>()
                            {
                                new MatchDto()
                                {
                                    Id = 9,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 10, Name = "Real Madrid", ShortName = "Real Madrid"},
                                    AwayTeam = new TeamDto() { Id = 11, Name = "FC Barcelona", ShortName = "Barcelona"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 10,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 12, Name = "Atletico Madrid", ShortName = "Atletico"},
                                    AwayTeam = new TeamDto() { Id = 13, Name = "FC Valencia", ShortName = "Valencia"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 11,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 14, Name = "Espanyol Barcelona", ShortName = "Espanyol"},
                                    AwayTeam = new TeamDto() { Id = 15, Name = "Villareal", ShortName = "Villareal"},
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0},
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0}
                                    }
                                }
                            }
                        },

                        // matchday2
                        new MatchdayDto()
                        {
                            Id = 2,
                            Matches = new List<MatchDto>()
                            {
                                new MatchDto()
                                {
                                    Id = 12,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 10, Name = "Real Madrid", ShortName = "Real Madrid" },
                                    AwayTeam = new TeamDto() { Id = 12, Name = "Atletico Madrid", ShortName = "Atletico" },
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 }
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 13,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 11, Name = "FC Barcelona", ShortName = "Barcelona" },
                                    AwayTeam = new TeamDto() { Id = 15, Name = "Villareal", ShortName = "Villareal" },
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 }
                                    }
                                },
                                new MatchDto()
                                {
                                    Id = 14,
                                    UtcDate = "",
                                    Status = "COMPLETED",
                                    HomeTeam = new TeamDto() { Id = 14, Name = "Espanyol Barcelona", ShortName = "Espanyol" },
                                    AwayTeam = new TeamDto() { Id = 13, Name = "FC Valencia", ShortName = "Valencia" },
                                    Score = new ScoreDto()
                                    {
                                        FullTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        HalfTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        ExtraTime = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 },
                                        Penalties = new ScoreSectionDto() { HomeScore = 0, AwayScore = 0 }
                                    }
                                }
                            }
                        }
                    },
                    Standings = new List<StandingDto>()
                    {
                        new StandingDto()
                        {
                            Position = 1,
                            Team = new TeamDto(){ Id = 10, Name = "Real Madrid", ShortName = "Real Madrid" },
                            PlayedGames = 3,
                            Won = 3,
                            Draw = 0,
                            Lost = 0,
                            Points = 9,
                            GoalsAgainst = 0,
                            GoalsFor = 10,
                            GoalDifference = 10
                        },
                        new StandingDto()
                        {
                            Position = 2,
                            Team = new TeamDto(){ Id = 11, Name = "FC Barcelona", ShortName = "Barcelona" },
                            PlayedGames = 3,
                            Won = 2,
                            Draw = 0,
                            Lost = 1,
                            Points = 6,
                            GoalsAgainst = 3,
                            GoalsFor = 6,
                            GoalDifference = 3
                        },
                        new StandingDto()
                        {
                            Position = 3,
                            Team = new TeamDto(){ Id = 13, Name = "FC Valencia", ShortName = "Valencia" },
                            PlayedGames = 3,
                            Won = 1,
                            Draw = 2,
                            Lost = 0,
                            Points = 5,
                            GoalsAgainst = 0,
                            GoalsFor = 1,
                            GoalDifference = 1
                        }
                    }
                }
            };
        }
    }
}