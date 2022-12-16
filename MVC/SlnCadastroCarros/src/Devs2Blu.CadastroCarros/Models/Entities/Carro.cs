using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.CadastroCarros.Models.Entities
{
    [Table("carro")]
    public class Carro
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("modelo")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Column("ano")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Column("CategoriaId")]
        [Display(Name = "Categoria")]
        public int MarcaId { get; set; }

        public virtual Marca? Marca { get; set; } 
    }
}
