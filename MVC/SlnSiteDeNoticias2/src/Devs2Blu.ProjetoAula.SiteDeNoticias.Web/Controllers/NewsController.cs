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
        private readonly ICategoryService _categoryService;

        public NewsController(ILogger<NewsController> logger,
                              INewsService service,
                              ICategoryService categoryService)
        {
            _logger = logger;
            _service = service;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            var news = await _service.FindById(id);
            return View(news);
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, title, description, createdOn, published, categoryId")] NewsDTO newsDTO)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(newsDTO) > 0)
                    {
                        TempData["SuccessMessage"] = "Successfully registered news";
                        return RedirectToAction("Index");
                    }
                }

                ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
                return View(newsDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to register news, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id, title, description, createdOn, published, categoryId")] NewsDTO newsDTO)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(newsDTO) > 0)
                    {
                        TempData["SuccessMessage"] = "Successfully edit news";
                        return RedirectToAction("Index");
                    }
                }

                ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
                return View(newsDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to edit news, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
