using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public String Cep { get; set; }
        public String Uf { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, string cep, string uf, string cidade, string bairro, string rua, int numero)
        {
            Id = id;
            Cep = cep;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }
    }
}
