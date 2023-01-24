using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsService _service;

        public NewsController(ILogger<NewsController> logger,
                              INewsService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        public async Task<IActionResult> Create()
        {
            ViewData["CategoriaId"] = new SelectList(_service.FindAll()
                .Select(c => c.category.id), "id", "nome");
            return View();
        }


        [HttpPost]
        public IActionResult Create(NewsDTO newsDTO)
        {
            _service.Save(newsDTO);
            return RedirectToAction("Index");

            /*try
            {
                if (ModelState.IsValid)
                {
                    _service.Save(newsDTO);
                    TempData["SuccessMessage"] = "Successfully registered news";
                    return RedirectToAction("Index");
                }

                return View(newsDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to register news, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }*/
        }
    }
}
