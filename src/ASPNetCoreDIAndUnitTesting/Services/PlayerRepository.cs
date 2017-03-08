

using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        public ICollection<Player> GetAll()
        {
            return new List<Player>
            {
                new Player {Name = "Wayne Gretzky",Height = 34.3,Weight = 205},
                new Player {Name = "Sidney Crosby",Height = 31.2,Weight = 195},
                new Player {Name = "Bobby Orr",Height = 35.7,Weight = 210}
            };
        }
    }
}
