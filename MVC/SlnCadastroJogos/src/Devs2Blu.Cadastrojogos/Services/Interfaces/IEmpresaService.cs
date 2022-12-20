using Devs2Blu.Cadastrojogos.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.Cadastrojogos.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task<IEnumerable<Empresa>> GetAllEmpresas();
        Task<Empresa> GetEmpresa(int? id);
        Task<int> Save(Empresa empresa);
        Task<Empresa> Details(int? id);
        Task<Empresa> Delete(int? id);
        Task<int> DeleteConfirmed(int? id);
    }
}
