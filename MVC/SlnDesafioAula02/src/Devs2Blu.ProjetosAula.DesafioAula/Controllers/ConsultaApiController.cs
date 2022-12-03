using Devs2Blu.ProjetosAula.DesafioAula.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.DesafioAula.Controllers
{
    public class ConsultaApiController : Controller
    {
        private readonly ServiceAPI Service = new ServiceAPI();

        [Route("agents")]
        public async Task<IActionResult> Agents()
        {
            var result = await Service.GetAgents();
            return View(result);
        }

        public async Task<IActionResult> Maps()
        {
            var result = await Service.GetMaps();
            return View(result);
        }
    }
}
