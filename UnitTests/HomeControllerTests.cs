
using System;
using System.Collections.Generic;
using ASPNetCoreDIAndUnitTesting.Controllers;
using ASPNetCoreDIAndUnitTesting.Models;
using ASPNetCoreDIAndUnitTesting.Models.HomeViewModels;
using ASPNetCoreDIAndUnitTesting.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace UnitTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_returns_viewresult_with_list_of_players_and_games()
        {
            // ARRANGE 
            var mockPlayerRepo = new Mock<IPlayerRepository>();
          
            mockPlayerRepo.Setup(mpr => mpr.GetAll()).Returns(new List<Player>
            {
                  new Player {Name = "Sidney Crosby"},
                  new Player {Name="Patrick Kane"}
            });

            var mockGameRepo = new Mock<IGameRepository>();

            mockGameRepo.Setup(mpr => mpr.GetTodaysGames()).Returns(new List<Game>
            {
                  new Game {HomeTeam = "Montreal Canadiens",AwayTeam = "Toronto Maple Leafs",Date = DateTime.Today},
                  new Game {HomeTeam = "Calgary Flames",AwayTeam = "Vancouver Canucks",Date = DateTime.Today},
                  new Game {HomeTeam = "Los Angeles Kings",AwayTeam = "Anaheim Ducks",Date = DateTime.Today},
            });

            // player repository is injected through constructor
            var controller = new HomeController(mockPlayerRepo.Object);

            // ACT 
            var result = controller.Index(mockGameRepo.Object); // game repository is injected through action parameter

            // ASSERT our action result and model
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IndexViewModel>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Players.Count);
            Assert.Equal(3, model.Games.Count);
        }
    }
}
