using Devs2Blu.Cadastrojogos.Models.Entities;

namespace Devs2Blu.Cadastrojogos.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task<IEnumerable<Empresa>> GetAllEmpresas();
    }
}
