using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<CategoryDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CategoryDTO entityDTO)
        {
            return _repository.Save(entityDTO.mapToEntity());
        }

        public Task<int> Delete(CategoryDTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
