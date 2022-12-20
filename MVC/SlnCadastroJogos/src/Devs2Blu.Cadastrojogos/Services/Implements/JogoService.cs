using Devs2Blu.Cadastrojogos.Models.Entities;
using Devs2Blu.Cadastrojogos.Repository;
using Devs2Blu.Cadastrojogos.Services.Interfaces;

namespace Devs2Blu.Cadastrojogos.Services.Implements
{
    public class JogoService : IJogoService
    {
        private readonly JogoRepository _repository;

        public JogoService(JogoRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Jogo>> GetAllJogos()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Empresa>> GetAllEmpresas()
        {
            return await _repository.GetEmpresas();
        }

        public async Task<int> Save(Jogo jogo)
        {
            return await _repository.SaveJogo(jogo);
        }

        public async Task<Jogo> Details(int? id)
        {
            return await _repository.DetailsJogo(id);
        }

        public async Task<Jogo> Delete(int? id)
        {
            return await _repository.DeleteJogo(id);
        }

        public async Task<int> DeleteConfirmed(int? id)
        {
            return await _repository.DeleteConfirmJogo(id);
        }
    }
}
