using Devs2Blu.ProjetoAula.SiteDeNoticias.Application.Services.SQLServerServices;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _service.FindById(id);
            return View(category);
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

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, name")] CategoryDTO categoryDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(categoryDTO) > 0)
                    {
                        TempData["SuccessMessage"] = "Successfully edit category";
                        return RedirectToAction("Index");
                    }
                }

                return View(categoryDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to edit category, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public async Task<JsonResult> Delete(int? id)
        {
            var retDel = new ReturnJsonDel
            {
                status = "Success",
                code = "200"
            };
            

            if (await _service.Delete(id ?? 0) <= 0)
            {
                retDel = new ReturnJsonDel
                {
                    status = "Success",
                    code = "200"
                };
            }

            return Json(retDel);
        }
    }

    public class ReturnJsonDel
    {
        public string status { get; set; }
        public string code { get; set; }
    }
}
