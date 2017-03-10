 

namespace ASPNetCoreDIAndUnitTesting.Services
{
   
    public class StatCalculator
    {
        private readonly IPlayerRepository _playerRepository;

        public StatCalculator(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public int GetTotalGoalsBySeason(int seasonId)
        {

            return 0;
        }
    }
}
