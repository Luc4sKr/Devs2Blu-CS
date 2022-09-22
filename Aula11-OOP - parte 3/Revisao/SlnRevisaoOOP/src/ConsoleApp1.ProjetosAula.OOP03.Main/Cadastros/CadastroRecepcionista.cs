using ConsoleApp1.ProjetosAula.OOP03.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP03.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProjetosAula.OOP03.Main.Cadastros
{
    public class CadastroRecepcionista
    {
        public CadastroRecepcionista()
        {

        }
        public void MenuCadastro()
        {
            Int32 opcao = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("----------- CADASTRO RECEPCIONISTAS ----------");
                Console.WriteLine("1 - Listar Recepcionistas");
                Console.WriteLine("2 - Cadastrar Recepcionista");
                Console.WriteLine("3 - Alterar Recepcionista");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------------------------------------");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionistas();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarRecepcionista();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != (int)MenuEnums.SAIR);
        }

        public void ListarRecepcionistas()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        public void CadastrarRecepcionista()
        {
            
        }
    }
}
