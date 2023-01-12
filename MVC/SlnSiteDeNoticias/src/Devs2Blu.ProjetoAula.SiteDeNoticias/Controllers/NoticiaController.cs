using Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaService _service;

        public NoticiaController(INoticiaService service)
        {
            _service = service;
        }

        #region GET
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllNoticias());
        }

        public async Task<IActionResult> Create()
        {
            ViewData["CategoriaId"] = new SelectList(await _service.GetAllCategorias(), "Id", "Nome");
            return View();
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Create(Noticia noticia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Save(noticia);
                    TempData["SucessMessage"] = "Notícia cadastrada com sucesso.";
                    return RedirectToAction("Index");
                }

                return View(noticia);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Não foi possível cadastrar a noticia, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
        #endregion
    }
}
