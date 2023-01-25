using Devs2Blu.ProjetoAula.SiteDeNoticias.Application.Services.SQLServerServices;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;

        public CategoryController(ILogger<CategoryController> logger,
                                  ICategoryService service)
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, name")] CategoryDTO categoryDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(categoryDTO) > 0)
                    {
                        TempData["SuccessMessage"] = "Successfully registered category";
                        return RedirectToAction("Index");
                    }
                }

                return View(categoryDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to register category, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
