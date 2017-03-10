


using System;
using System.Collections.Generic;
using System.Linq;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public class TeamStatRepository : ITeamStatRepository
    {
        private readonly List<TeamStatSummary> _teamStats = new List<TeamStatSummary>
        {
             new TeamStatSummary {SeasonId = 1,Team = "Montreal Canadiens",GoalsFor=345,GoalsAgainst = 123,Wins = 60,Losses = 22},
             new TeamStatSummary {SeasonId=1,Team = "Ottawa Senators",GoalsFor=232,GoalsAgainst = 353,Wins = 40,Losses = 42},
             new TeamStatSummary {SeasonId = 1,Team = "Toronto Maple Leafs",GoalsFor=132,GoalsAgainst = 493,Wins = 20,Losses = 62}
        };

        public ICollection<TeamStatSummary> GetAll()
        {
            return _teamStats;
        }

        public ICollection<TeamStatSummary> FindAll(Func<TeamStatSummary,bool> predicate)
        {
            return _teamStats.Where(predicate).ToList();
        }
    }
}
