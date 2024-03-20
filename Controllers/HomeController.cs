using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;
using System.Diagnostics;

namespace Projeto1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Lucas Fernandes";
            home.Email = "lucasrx6@gmail.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Atividades()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
