 
using ASPNetCoreDIAndUnitTesting.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDIAndUnitTesting.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IPlayerRepository _playerRepository;

        public HomeController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

            public IActionResult Index([FromServices] IGameRepository gameRepository)
            {
                var players = _playerRepository.GetAll(); // constructor injected
                var games = gameRepository.GetTodaysGames(); // parameter injected
                return View();
            }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
