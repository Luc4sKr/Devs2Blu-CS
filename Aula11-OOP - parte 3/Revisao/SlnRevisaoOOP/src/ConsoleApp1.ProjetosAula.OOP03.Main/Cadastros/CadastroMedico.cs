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
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("-------------- CADASTRO MÉDICOS --------------");
                Console.WriteLine("1 - Listar Médicos");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Alterar Médico");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------------------------------------");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarMedico();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != (int)MenuEnums.SAIR);
        }

        public void ListarMedicos()
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

        public void CadastrarMedico()
        {
            
        }

        public void AlterarMedico()
        {

        }

        public void ExcluirPaciente()
        {

        }
    }
}
