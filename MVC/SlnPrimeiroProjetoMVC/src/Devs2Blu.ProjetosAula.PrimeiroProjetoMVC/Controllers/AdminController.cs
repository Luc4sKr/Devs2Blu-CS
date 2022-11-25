﻿using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("admin/indicadores")]
        public IActionResult Indicadores()
        {
            return View();
        }
    }
}
