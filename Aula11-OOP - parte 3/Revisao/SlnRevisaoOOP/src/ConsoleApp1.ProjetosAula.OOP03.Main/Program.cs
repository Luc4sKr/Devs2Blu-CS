using ConsoleApp1.ProjetosAula.OOP03.Main.Cadastros;
using ConsoleApp1.ProjetosAula.OOP03.Main.Utils;
using ConsoleApp1.ProjetosAula.OOP03.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP03.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProjetosAula.OOP03.Main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }


        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();

            do
            {
                Console.WriteLine("---- SISTEMA DE GERENCIAMENTO DE CLÍNICAS ----");
                Console.WriteLine("10 - Cadastro de Pacientes");
                Console.WriteLine("20 - Cadastro de Médicos");
                Console.WriteLine("30 - Cadastro de Recepcionistas");
                Console.WriteLine("40 - Cadastro de Fornecedores");
                Console.WriteLine("50 - Agenda");
                Console.WriteLine("60 - Prontuario");
                Console.WriteLine("70 - Financeiro");
                Console.WriteLine("00 - Sair");
                Console.WriteLine("----------------------------------------------");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PACIENTE:
                        CadastroPaciente ModuloCadastroPacientes = new CadastroPaciente();
                        ModuloCadastroPacientes.MunuCadastro();
                        break;
                    default:
                        break;
                }

            } while (opcao != (int)MenuEnums.SAIR);
            
        }

        public static void ViewListPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Mock.ListaPacientes)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("---------------------------------------------\n");
            }
        }
    }
}
