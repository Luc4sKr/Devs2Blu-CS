using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool Published { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
