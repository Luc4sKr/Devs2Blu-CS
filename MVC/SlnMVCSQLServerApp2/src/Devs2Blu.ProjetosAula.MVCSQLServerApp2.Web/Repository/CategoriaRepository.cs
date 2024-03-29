﻿using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Repository
{
    public class CategoriaRepository
    {
        private readonly ContextoDatabase _context;

        public CategoriaRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return _context.Categoria.ToList();
        }

        public async Task<int> SaveCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }
    }
}
