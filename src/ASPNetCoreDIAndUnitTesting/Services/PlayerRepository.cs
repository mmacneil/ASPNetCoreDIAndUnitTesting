

using System;
using System.Collections.Generic;
using System.Linq;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly List<Player> _players = new List<Player>
        {
             new Player {Name = "Wayne Gretzky",Height = 34.3,Weight = 205},
             new Player {Name = "Sidney Crosby",Height = 31.2,Weight = 195},
             new Player {Name = "Bobby Orr",Height = 35.7,Weight = 210}
        };


        public ICollection<Player> GetAll()
        {
            return _players;
        }

        public ICollection<Player> Find(Func<Player,bool> predicate)
        {
            return _players.Where(predicate).ToList();
        }
    }
}
