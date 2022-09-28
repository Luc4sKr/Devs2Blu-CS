using Devs2Blu.ProjetosAula.OOP03.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProjetosAula.OOP03.Main.Interfaces
{
    public interface IMenuCadastro
    {
        Int32 MenuCadastro();
        void Listar();
        void Cadastrar();
        void Alterar();
        void Excluir();
    }
}
