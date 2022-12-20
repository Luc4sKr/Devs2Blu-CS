using Devs2Blu.Cadastrojogos.Models;
using Devs2Blu.Cadastrojogos.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Empresa> GetOne(int id)
        {
            return await _context.Empresa.FirstOrDefaultAsync(empresa => empresa.Id == id);
        }

        public async Task<int> SaveEmpresa(Empresa empresa)
        {
            _context.Add(empresa);
            return await _context.SaveChangesAsync();
        }

        public async Task<Empresa> DetailsEmpresa(int? id)
        {
            return await _context.Empresa.FirstOrDefaultAsync(empresa => empresa.Id == id);   
        }

        public async Task<Empresa> DeleteEmpresa(int? id)
        {
            return await _context.Empresa.FirstOrDefaultAsync(empresa => empresa.Id == id);
        }

        public async Task<int> DeleteConfirmEmpresa(int? id)
        {
            Empresa empresa = await _context.Empresa.FindAsync(id);
            _context.Empresa.Remove(empresa);
            return await _context.SaveChangesAsync();
        }
    }
}
