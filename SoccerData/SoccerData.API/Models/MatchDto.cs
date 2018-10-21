namespace SoccerData.API.Models
{
    public class MatchDto
    {
        public int Id { get; set; }
        public string UtcDate { get; set; }
        public string Status { get; set; }
        public ScoreDto Score { get; set; }
        public TeamDto HomeTeam { get; set; }
        public TeamDto AwayTeam { get; set; }
    }
}