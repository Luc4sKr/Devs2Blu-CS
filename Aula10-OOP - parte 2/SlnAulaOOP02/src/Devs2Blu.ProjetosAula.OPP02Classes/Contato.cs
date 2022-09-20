using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OPP02Classes
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Contato() { }

        public Contato(string nome, string tel, string email, string cep, string rua, int numero, string bairro, string cidade, string estdo)
        {
            this.Nome = nome;
            this.Tel = tel;
            this.Email = email;
            this.Cep = cep;
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estdo;
        }
    }
}
