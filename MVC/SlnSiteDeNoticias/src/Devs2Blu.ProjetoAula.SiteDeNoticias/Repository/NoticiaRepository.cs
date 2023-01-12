using Devs2Blu.ProjetoAula.SiteDeNoticias.Models;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Repository
{
    public class NoticiaRepository
    {
        private readonly ContextDatabase _context;

        public NoticiaRepository(ContextDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Noticia>> GetAll()
        {
            return _context.Noticia.ToList();
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            return _context.Categoria.ToList();
        }

        public async Task<Noticia> GetById(int id)
        {
            return _context.Noticia.FirstOrDefault(noticia => noticia.Id == id);
        }

        public async Task<int> Save(Noticia noticia)
        {
            _context.Add(noticia);
            return await _context.SaveChangesAsync();
        }
    }
}
