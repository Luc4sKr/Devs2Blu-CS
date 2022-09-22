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
                Console.Clear();

                Console.WriteLine("------------- CADASTRO PACIENTES -------------");
                Console.WriteLine("1 - Listar pacientes");
                Console.WriteLine("2 - Cadastrar paciente");
                Console.WriteLine("3 - Alterar paciente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------------------------------------");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                Console.Clear();

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastarPaciente();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarPaciente();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != (int)MenuEnums.SAIR);
        }

        public void ListarPacientes()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        public void CadastarPaciente()
        {
            Console.WriteLine("------------- CADASTRAR PACIENTE -------------");

            Console.Write("Código: ");
            Int32 codigo;
            Int32.TryParse(Console.ReadLine(), out codigo);

            Console.Write("Nome: ");
            String nome = Console.ReadLine();

            Console.Write("CPF: ");
            String cpf = Console.ReadLine();

            Console.Write("Convenio: ");
            String convenio = Console.ReadLine();

            Paciente paciente = new Paciente(codigo, nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);

            Console.WriteLine("\nPaciete cadastrado!");

            Console.WriteLine("----------------------------------------------");
        }

        public void AlterarPaciente()
        {
            Console.WriteLine("-------------- ALTERAR PACIENTE --------------");
            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();
            
            Console.WriteLine("----------------------------------------------");
        }
        
        public void ExcluirPaciete()
        {
            ListarSemDetalhes();

            do
            {
                Console.WriteLine("Código do Paciente que deseja alterar ['0' para parar] ");
                Console.Write("-> ");
                Int32 codigoPaciente;
                Int32.TryParse(Console.ReadLine(), out codigoPaciente);

                foreach (Paciente paciente in Program.Mock.ListaPacientes)
                {
                    if (paciente.CodigoPaciente == codigoPaciente)
                    {
                        Program.Mock.ListaPacientes.Remove(paciente);
                        Console.WriteLine("Pciente removido");
                    }
                    else if (codigoPaciente == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Paciente não encontrado");
                    }
                }
            } while (true);
        }

        public void ListarSemDetalhes()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine($"{paciente.CodigoPaciente}, {paciente.Nome}, {paciente.CGCCPF}, {paciente.Convenio}\n");
            }
        }
    }
}
