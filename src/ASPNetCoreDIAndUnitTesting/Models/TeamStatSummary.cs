 

namespace ASPNetCoreDIAndUnitTesting.Models
{
    public class TeamStatSummary
    {
        public int SeasonId { get; set; }
        public string Team { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
    }
}
