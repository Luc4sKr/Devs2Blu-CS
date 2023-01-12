using Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Interfaces
{
    public interface INoticiaService
    {
        Task<IEnumerable<Noticia>> GetAllNoticias();
        Task<IEnumerable<Categoria>> GetAllCategorias();
        Task<int> Save(Noticia noticia);
    }
}
