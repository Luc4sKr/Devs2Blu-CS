using Devs2Blu.ProjetosAula.DesafioAula.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.DesafioAula.Controllers
{
    [Route("results")]
    public class CardsApiController : Controller
    {
        private readonly ILogger<CardsApiController> _logger;
        private readonly ServiceApi Service;

        public CardsApiController(ILogger<CardsApiController> logger)
        {
            _logger = logger;
            Service = new ServiceApi();
        }

        [Route("characters")]
        public async Task<IActionResult> Characters()
        {
            var result = await Service.GetCharacters();
            return View(result);
        }

        [Route("locations")]
        public async Task<IActionResult> Locations()
        {
            var result = await Service.GetLocations();
            return View(result);
        }

        [Route("search/{nameCharacter}")]
        public async Task<IActionResult> SearchCard(string nameCharacter)
        {
            var card = await Service.GetCharacterByName(nameCharacter);
            return View(card);
        }
    }
}
