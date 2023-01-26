using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Set a title, please.")]
        public string title { get; set; }

        [Required(ErrorMessage = "Set a description, please.")]
        [MinLength(5, ErrorMessage = "Description should bigger than 5 characters")]
        public string description { get; set; }
        public DateTime? createdOn { get; set; }
        public bool published { get; set; }
        public int categoryId { get; set; }
        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CreatedOn = createdOn,
                Published = published,
                CategoryId = categoryId,
            };
        }

        public NewsDTO mapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                createdOn = news.CreatedOn,
                published = news.Published,
                categoryId = news.CategoryId,
                /*category = new CategoryDTO() 
                { 
                    id = news.Category.Id,
                    name = news.Category.Name 
                }*/
            };
        }
    }
}
