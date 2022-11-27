using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            {
                new User {Id = 1, Name = "Lucas", Login = "lucas"},
                new User {Id = 2, Name = "Maria", Login = "maria"},
                new User {Id = 3, Name = "João", Login = "joao"},
                new User {Id = 4, Name = "Felipe", Login = "felipe"},
                new User {Id = 5, Name = "Yuri", Login = "yuri"}
            };
            

            return View(users);
        }

        [Route("admin/indicadores")]
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            return PartialView();
        }
    }
}
