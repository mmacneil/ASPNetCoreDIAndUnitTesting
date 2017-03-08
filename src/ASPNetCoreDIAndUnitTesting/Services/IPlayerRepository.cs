 

using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public interface IPlayerRepository
    {
        ICollection<Player> GetAll();
    }
}
