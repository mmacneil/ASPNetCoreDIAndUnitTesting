 

namespace ASPNetCoreDIAndUnitTesting.Models
{
    public class Player
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public SeasonStatSummary SeasonStats { get; set; }
    }
}
