
using System.Linq;
using ASPNetCoreDIAndUnitTesting.Models.HomeViewModels;
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
            var model = new IndexViewModel
            {
                Players = _playerRepository.GetAll().ToList(),    // constructor injected
                Games = gameRepository.GetTodaysGames().ToList()      // parameter injected
            };

            return View(model);
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
