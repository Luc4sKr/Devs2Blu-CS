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

        public async Task<NewsDTO> FindById(int id)
        {
            var dto = new NewsDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NewsDTO entityDTO)
        {
            if (entityDTO.id > 0)
            {
                return _repository.Update(entityDTO.mapToEntity());
            }

            entityDTO.createdOn = DateTime.Now;
            entityDTO.published = true;

            return _repository.Save(entityDTO.mapToEntity());
        }

        public Task<int> Delete(NewsDTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
