using Devs2Blu.Cadastrojogos.Models.Entities;
using Devs2Blu.Cadastrojogos.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.Cadastrojogos.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _service;

        public EmpresaController(IEmpresaService service)
        {
            _service = service;
        }

        // GET: EmpresaController
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAllEmpresas());
        }

        // GET: EmpresaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _service.Details(id));
        }

        // GET: EmpresaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nome")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                await _service.Save(empresa);
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(empresa);
            }
        }

        // GET: EmpresaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Empresa empresa = await _service.GetEmpresa(id);

            return View();
        }

        // POST: EmpresaController/Edit/5
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

        // GET: EmpresaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _service.Delete(id));
        }

        // POST: EmpresaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            await _service.DeleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
