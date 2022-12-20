using Devs2Blu.Cadastrojogos.Models;
using Devs2Blu.Cadastrojogos.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.Cadastrojogos.Repository
{
    public class JogoRepository
    {
        private readonly ContextDatabase _context;

        public JogoRepository(ContextDatabase context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Jogo>> GetAll()
        {
            return _context.Jogo.ToList();
        }

        public async Task<IEnumerable<Empresa>> GetEmpresas()
        {
            return _context.Empresa.ToList();
        }

        public async Task<int> SaveJogo(Jogo jogo)
        {
            _context.Add(jogo);
            return await _context.SaveChangesAsync();
        }

        public async Task<Jogo> DetailsJogo(int? id)
        {
            return await _context.Jogo.Include(jogo => jogo.Empresa).
                FirstOrDefaultAsync(jogo => jogo.Id == id);
        }

        public async Task<Jogo> DeleteJogo(int? id)
        {
            return await _context.Jogo.FirstOrDefaultAsync(jogo => jogo.Id == id);
        }

        public async Task<int> DeleteConfirmJogo(int? id)
        {
            Jogo jogo = await _context.Jogo.FindAsync(id);
            _context.Jogo.Remove(jogo);
            return await _context.SaveChangesAsync();
        }
    }
}
