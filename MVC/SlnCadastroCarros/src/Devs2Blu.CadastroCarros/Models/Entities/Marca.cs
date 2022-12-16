using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.CadastroCarros.Models.Entities
{
    [Table("marca")]
    public class Marca
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Carro>? Carros { get; set; }
    }
}
