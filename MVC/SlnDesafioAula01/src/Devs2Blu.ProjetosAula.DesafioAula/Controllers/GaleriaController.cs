using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.DesafioAula.Controllers
{
    public class GaleriaController : Controller
    {

        [Route("galeria/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
