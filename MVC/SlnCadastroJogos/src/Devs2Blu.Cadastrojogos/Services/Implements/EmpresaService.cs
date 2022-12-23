using Devs2Blu.Cadastrojogos.Models.Entities;
using Devs2Blu.Cadastrojogos.Repository;
using Devs2Blu.Cadastrojogos.Services.Interfaces;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<Empresa> GetEmpresa(int? id)
        {
            return await _repository.GetOne(id);
        }


        public Task<int> Edit(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Save(Empresa empresa)
        {
            return await _repository.SaveEmpresa(empresa);
        }

        public async Task<Empresa> Details(int? id)
        {
            return await _repository.DetailsEmpresa(id);
        }

        public async Task<Empresa> Delete(int? id)
        {
            return await _repository.DeleteEmpresa(id);
        }

        public async Task<int> DeleteConfirmed(int? id)
        {
            return await _repository.DeleteConfirmEmpresa(id);
        }
    }
}
