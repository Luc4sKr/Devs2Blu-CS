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
                Console.WriteLine("4 - Excluir paciente");
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
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirPaciete();
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

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;

            Console.WriteLine("Código do Paciente que deseja remover");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            int index = 0;
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CodigoPaciente == codigoPaciente)
                {
                    pacienteEncontrado = true;

                    Console.Write("Nome: ");
                    String nome = Console.ReadLine();

                    Console.Write("CPF: ");
                    String cpf = Console.ReadLine();

                    Console.Write("Convenio: ");
                    String convenio = Console.ReadLine();

                    paciente.Nome = nome;
                    paciente.CGCCPF = cpf;
                    paciente.Convenio = convenio;

                    Console.WriteLine("Paciente alterado!");
                }
                index++;
            }

            if (!pacienteEncontrado)
            {
                Console.WriteLine("Paciente não encontrado");
                return;
            }

            Console.WriteLine("----------------------------------------------");
        }
        
        public void ExcluirPaciete()
        {
            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;

            Console.WriteLine("Código do Paciente que deseja alterar");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            int index = 0;
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CodigoPaciente == codigoPaciente)
                {
                    pacienteEncontrado = true;

                }
                index++;
            }

            if (pacienteEncontrado)
            {
                Program.Mock.ListaPacientes.RemoveAt(index-1);
                Console.WriteLine("Paciente removido");
            } else
            {
                Console.WriteLine("Paciente não encontrado");
            }
            
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
