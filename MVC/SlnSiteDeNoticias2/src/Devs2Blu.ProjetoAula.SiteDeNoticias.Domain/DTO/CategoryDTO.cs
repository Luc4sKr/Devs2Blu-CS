﻿using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO
{
    public class CategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<NewsDTO>? newsList { get; set; }

        public Category mapToEntity()
        {
            return new Category
            {
                Id = id,
                Name = name
            };
        }

        public CategoryDTO mapToDTO(Category category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                name = category.Name,
                newsList = category.NewsList.Select(c => new NewsDTO() { }).ToList()
            };
        }
    }
}
