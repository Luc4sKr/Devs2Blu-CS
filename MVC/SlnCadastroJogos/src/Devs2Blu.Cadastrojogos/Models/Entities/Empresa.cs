using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.Cadastrojogos.Models.Entities
{
    [Table("empresas")]
    public class Empresa
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Jogo>? Jogos { get; set; }
    }
}
