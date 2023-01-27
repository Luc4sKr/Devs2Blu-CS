using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Application.Services.SQLServerServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public List<CategoryDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(c => new CategoryDTO()
                {
                    id = c.Id,
                    name = c.Name
                }).ToList();
        }

        public async Task<CategoryDTO> FindById(int id)
        {
            var dto = new CategoryDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(CategoryDTO entityDTO)
        {
            if (entityDTO.id > 0)
            {
                return _repository.Update(entityDTO.mapToEntity());
            }

            return _repository.Save(entityDTO.mapToEntity());
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
