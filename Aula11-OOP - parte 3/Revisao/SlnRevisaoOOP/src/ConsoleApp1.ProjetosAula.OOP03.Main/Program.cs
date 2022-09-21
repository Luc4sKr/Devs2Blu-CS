using ConsoleApp1.ProjetosAula.OOP03.Main.Utils;
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
            Mock = new Mocks();
            ViewListPacientes();
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
