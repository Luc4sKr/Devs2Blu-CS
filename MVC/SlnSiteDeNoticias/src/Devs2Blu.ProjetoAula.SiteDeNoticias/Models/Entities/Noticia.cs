using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities
{
    [Table("noticias")]
    public class Noticia
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Digite um título")]
        public string Titulo { get; set; }

        [Column("descricao")]
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Digite uma descrição")]
        public string Descricao { get; set; }

        [Column("categoriaId")]
        [Display(Name = "CategoriaId")]
        [Required(ErrorMessage = "Escolha uma categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
