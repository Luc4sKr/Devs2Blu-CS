using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("consulta")]
    public class ConsultaApiController : Controller
    {
        private readonly PokemonAPIService Service = new PokemonAPIService();


        public async Task<IActionResult> Index()
        {
            var result = await Service.GetPokemnons();
            return View(result);
        }

        [Route("pokemons")]
        public PartialViewResult Pokemons()
        {
            var result = Service.GetPokemnons();
            return PartialView();
        }
    }
}
