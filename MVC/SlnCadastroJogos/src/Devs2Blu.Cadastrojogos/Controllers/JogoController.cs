using Devs2Blu.Cadastrojogos.Models.Entities;
using Devs2Blu.Cadastrojogos.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Devs2Blu.Cadastrojogos.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            _service = service;
        }

        // GET: JogoController
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAllJogos());
        }

        // GET: JogoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _service.Details(id));
        }

        // GET: JogoController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["EmpresaId"] = new SelectList( await _service.GetAllEmpresas(), "Id", "Id");
            return View();
        }

        // POST: JogoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nome,Preco,EmpresaId")] Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                await _service.Save(jogo);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(jogo);
            }
        }

        // GET: JogoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JogoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JogoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JogoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
