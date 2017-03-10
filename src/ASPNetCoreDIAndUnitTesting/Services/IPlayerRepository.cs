 

using System;
using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public interface IPlayerRepository
    {
        ICollection<Player> GetAll();
        ICollection<Player> Find(Func<Player, bool> predicate);
    }
}
