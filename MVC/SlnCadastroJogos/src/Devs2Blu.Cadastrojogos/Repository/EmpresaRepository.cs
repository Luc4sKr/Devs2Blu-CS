using Devs2Blu.Cadastrojogos.Models;
using Devs2Blu.Cadastrojogos.Models.Entities;

namespace Devs2Blu.Cadastrojogos.Repository
{
    public class EmpresaRepository
    {
        private readonly ContextDatabase _context;

        public EmpresaRepository(ContextDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Empresa>> GetAll()
        {
            return _context.Empresa.ToList();
        }
    }
}
