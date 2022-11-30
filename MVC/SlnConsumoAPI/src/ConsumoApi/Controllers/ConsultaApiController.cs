using ConsumoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoApi.Controllers
{
    public class ConsultaApiController : Controller
    {

        private readonly APIService Service = new APIService();

        [Route("character")]
        public async Task<IActionResult> Character()
        {
            var result = await Service.GetCharacter();
            return View(result);
        }

        [Route("episodes")]
        public async Task<IActionResult> Episodes()
        {
            var result = await Service.GetEpisodes();
            return View(result);
        }

        [Route("locations")]
        public async Task<IActionResult> Locations()
        {
            var result = await Service.GetLocations();
            return View(result);
        }
    }
}
