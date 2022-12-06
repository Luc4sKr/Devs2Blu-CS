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
        [Route("characters/page/{page}")]
        public async Task<IActionResult> Characters(int page)
        {
            var result = await Service.GetCharactersByPage(page);
            return View(result);
        }

        
        public async Task<IActionResult> CharacterByPage(int page)
        {
            var result = await Service.GetCharactersByPage(page);
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
