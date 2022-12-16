using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.Cadastrojogos.Models.Entities
{
    [Table("jogos")]
    public class Jogo
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("preco")]
        [Display(Name = "Preço")]
        public Double Preco { get; set; }

        [Column("EmpresaId")]
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }

        public virtual Empresa? Empresa { get; set; }
    }
}
