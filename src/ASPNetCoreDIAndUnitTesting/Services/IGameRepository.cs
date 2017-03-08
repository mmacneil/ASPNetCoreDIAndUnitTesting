 

using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public interface IGameRepository
    {
        ICollection<Game> GetTodaysGames();
    }
}
