﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.AulaClasses
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Enderco { get; set; }

        public string ApresentarNomeCustom()
        {
            string nomeCustom;
            nomeCustom = $"{Sobrenome}, {Nome}";
            return nomeCustom;
        }
    }
}
