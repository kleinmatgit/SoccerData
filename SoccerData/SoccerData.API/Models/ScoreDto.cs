namespace SoccerData.API.Models
{
    public class ScoreDto
    {
        public ScoreSectionDto FullTime { get; set; }
        public ScoreSectionDto HalfTime { get; set; }
        public ScoreSectionDto ExtraTime { get; set; }
        public ScoreSectionDto Penalties { get; set; }
    }
}