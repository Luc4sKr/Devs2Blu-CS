using Devs2Blu.ProjetosAula.DesafioAula.Models;
using Devs2Blu.ProjetosAula.DesafioAula.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.DesafioAula.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceApi Service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Service = new ServiceApi();
        }

        public async Task<IActionResult> Index()
        {
            var result = await Service.GetRandomCharacters();
            return View(result);
        }

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