﻿using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
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
            // To list all categories
            // Get of CategoryRepository through Dependency Injection (ICategoryService)
            var categoryList = _service.FindAll();
            return View(await categoryList.ToListAsync());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}