using ConsoleApp1.ProjetosAula.OOP03.Main.Interfaces;
using ConsoleApp1.ProjetosAula.OOP03.Main.Utils;
using ConsoleApp1.ProjetosAula.OOP03.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP03.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProjetosAula.OOP03.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;

            Console.Clear();

            Console.WriteLine("-------------- CADASTRO MÉDICOS --------------");
            Console.WriteLine("1 - Listar Médicos");
            Console.WriteLine("2 - Cadastrar Médico");
            Console.WriteLine("3 - Alterar Médico");
            Console.WriteLine("4 - Excluir Médico");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------------------------------");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Listar()
        {
            ListarMedicos();
        }

        public void Cadastrar()
        {
            CadastrarMedico();
        }

        public void Alterar()
        {
            AlterarMedico();
        }

        public void Excluir()
        {
            ExcluirMedico();
        }
        #endregion

        private void ListarMedicos()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        private void CadastrarMedico()
        {
            
        }

        private void AlterarMedico()
        {

        }

        private void ExcluirMedico()
        {

        }

        
    }
}
