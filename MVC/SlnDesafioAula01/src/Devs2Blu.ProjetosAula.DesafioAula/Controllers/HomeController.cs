using Devs2Blu.ProjetosAula.DesafioAula.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.DesafioAula.Controllers
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
            return View();
        }

        [Route("index/contato")]
        public IActionResult Contato()
        {
            return View();
        }

        [Route("index/privacy")]
        public IActionResult Privacy()
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