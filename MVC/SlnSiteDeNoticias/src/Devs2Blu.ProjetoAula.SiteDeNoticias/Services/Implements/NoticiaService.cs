using Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Repository;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Interfaces;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Implements
{
    public class NoticiaService : INoticiaService
    {
        private readonly NoticiaRepository _repository;

        public NoticiaService(NoticiaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Noticia>> GetAllNoticias()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Categoria>> GetAllCategorias()
        {
            return await _repository.GetCategorias();
        }

        public async Task<int> Save(Noticia noticia)
        {
            return await _repository.Save(noticia);
        }
    }
}
