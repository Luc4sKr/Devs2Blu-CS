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
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {

        }

        public void MunuCadastro()
        {
            Int32 opcao = 0;

            do
            {
                Console.WriteLine("------------- CADASTRO PACIENTES -------------");
                Console.WriteLine("1 - Lista pacientes");
                Console.WriteLine("2 - Cadastro de pacientes");
                Console.WriteLine("3 - Alterar pacientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------------------------------------");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastarPaciente();
                        break;
                    default:
                        break;
                }

            } while (opcao != (int)MenuEnums.SAIR);
        }

        public void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

        public void CadastarPaciente()
        {

        }

        public void AlterarPaciente()
        {

        }
        
        public void ExcluirPaciete()
        {

        }
    }
}
