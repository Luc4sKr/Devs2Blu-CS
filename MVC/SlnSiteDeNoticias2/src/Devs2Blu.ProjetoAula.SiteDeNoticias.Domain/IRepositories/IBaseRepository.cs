using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories
{
    public interface IBaseService<T> where T : class
    {
        IQueryable<T> FindAll();
        Task<T> FindById(int id);
        Task<int> Save(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
