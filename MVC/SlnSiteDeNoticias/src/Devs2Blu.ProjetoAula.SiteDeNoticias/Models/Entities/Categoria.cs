using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities
{
    [Table("categorias")]
    public class Categoria
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Noticia>? Noticias { get; set; }
    }
}
