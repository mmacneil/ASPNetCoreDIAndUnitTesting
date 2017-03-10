 
using System;
using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Models;
using ASPNetCoreDIAndUnitTesting.Services;
using Moq;
using Xunit;

namespace UnitTests
{
    public class TeamStatCalculatorTests
    {
        [Fact]
        public void GetTotalGoalsForSeason_returns_expected_goal_count()
        {
            // ARRANGE 
            var mockTeamStatRepo = new Mock<ITeamStatRepository>();

            // setup a mock stat repository to return some fake data within our target method
            mockTeamStatRepo.Setup(mtsr => mtsr.FindAll(It.IsAny<Func<TeamStatSummary, bool>>())).Returns(new List<TeamStatSummary>
            {
                  new TeamStatSummary {SeasonId = 1,Team = "team 1",GoalsFor=1},
                  new TeamStatSummary {SeasonId=1,Team = "team 2",GoalsFor=2},
                  new TeamStatSummary {SeasonId = 1,Team = "team 3",GoalsFor=3}
            });

            // create our TeamStatCalculator by injecting our mock repository
            var teamStatCalculator = new TeamStatCalculator(mockTeamStatRepo.Object);

            // ACT - call our method under test
            var result = teamStatCalculator.GetTotalGoalsForSeason(1);

            // ASSERT - we got the result we expected - our fake data has 6 goals...we should get this back from the method
            Assert.True(result==6);
        }
    }
}
