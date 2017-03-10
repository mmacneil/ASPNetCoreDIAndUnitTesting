
using System;
using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;

namespace ASPNetCoreDIAndUnitTesting.Services
{
    public interface ITeamStatRepository
    {
        ICollection<TeamStatSummary> GetAll();
        ICollection<TeamStatSummary> FindAll(Func<TeamStatSummary, bool> predicate);
    }
}
