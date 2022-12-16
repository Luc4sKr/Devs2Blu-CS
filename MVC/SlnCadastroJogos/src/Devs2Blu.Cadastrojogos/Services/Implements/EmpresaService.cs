using Devs2Blu.Cadastrojogos.Models.Entities;
using Devs2Blu.Cadastrojogos.Repository;
using Devs2Blu.Cadastrojogos.Services.Interfaces;

namespace Devs2Blu.Cadastrojogos.Services.Implements
{
    public class EmpresaService : IEmpresaService
    {
        private readonly EmpresaRepository _repository;

        public EmpresaService(EmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Empresa>> GetAllEmpresas()
        {
            return await _repository.GetAll();
        }
    }
}
