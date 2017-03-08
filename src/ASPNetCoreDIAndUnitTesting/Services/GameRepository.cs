

using System;
using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public class GameRepository : IGameRepository
    { 

        ICollection<Game> IGameRepository.GetTodaysGames()
        {
            return new List<Game>
            {
                new Game {Date = DateTime.Now,HomeTeam = "Montreal Canadiens", AwayTeam = "Toronto Maple Leafs"},
                new Game {Date = DateTime.Now,HomeTeam = "Vancouver Canucks", AwayTeam = "Calgary Flames"},
                new Game {Date = DateTime.Now,HomeTeam = "Los Angeles Kings", AwayTeam = "Anaheim Ducks"}
            };
        }
    }
}
