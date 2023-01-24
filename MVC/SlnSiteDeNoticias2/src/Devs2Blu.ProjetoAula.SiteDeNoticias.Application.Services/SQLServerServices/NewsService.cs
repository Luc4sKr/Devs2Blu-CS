using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Application.Services.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(n => new NewsDTO()
                {
                    id = n.Id,
                    title= n.Title,
                    description = n.Description,
                    published = n.Published,
                    createdOn = n.CreatedOn,
                    categoryId = n.CategoryId,
                    category = new CategoryDTO()
                        {
                            id = n.Category.Id,
                            name = n.Category.Name

                        }
                }).ToList();
        }

        public Task<NewsDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NewsDTO entity)
        {
            entity.createdOn = DateTime.Now;
            entity.published = true;

            News news = entity.mapToEntity();

            return _repository.Save(news);
        }

        public Task<int> Delete(NewsDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
