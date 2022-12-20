using Devs2Blu.Cadastrojogos.Models.Entities;

namespace Devs2Blu.Cadastrojogos.Services.Interfaces
{
    public interface IJogoService
    {
        Task<IEnumerable<Jogo>> GetAllJogos();
        Task<IEnumerable<Empresa>> GetAllEmpresas();
        Task<int> Save(Jogo jogo);
        Task<Jogo> Details(int? id);
        Task<Jogo> Delete(int? id);
        Task<int> DeleteConfirmed(int? id);
    }
}
