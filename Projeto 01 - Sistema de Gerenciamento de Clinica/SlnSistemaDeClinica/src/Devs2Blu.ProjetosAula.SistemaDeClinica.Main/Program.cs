using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Cadastros;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Interfaces;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils;
using System;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Texto;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }


        static void Main(string[] args)
        {
            Int32 opcao = 0, opcaoMenuCadastros = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastros;

            Console.WriteLine(ConstantesDeTexto.TXT_SISTEMA_DE_GERENCIAMENTO_DE_CLINICA);
            Console.WriteLine("\n\nPressione 'ENTER' para entrar...");
            Console.ReadKey();

            do
            {
                if (opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
                {
                    Console.Clear();

                    DesenharTexto.TituloBox(ConstantesDeTexto.TXT_MENU);
                    Console.WriteLine("║10 - Cadastro de Pacientes                    ║");
                    Console.WriteLine("║20 - Cadastro de Médicos                      ║");
                    Console.WriteLine("║30 - Cadastro de Recepcionistas               ║");
                    Console.WriteLine("║40 - Cadastro de Fornecedores                 ║");
                    Console.WriteLine("║50 - Agenda                                   ║");
                    Console.WriteLine("║60 - Prontuario                               ║");
                    Console.WriteLine("║70 - Financeiro                               ║");
                    Console.WriteLine("║00 - Sair                                     ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");
                    Console.Write("-> ");
                    Int32.TryParse(Console.ReadLine(), out opcao);
                }

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PACIENTE:
                        menuCadastros = new CadastroPaciente();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MEDICO:
                        menuCadastros = new CadastroMedico();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_RECEPCIONISTA:
                        menuCadastros = new CadastroRecepcionista();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FORNECEDOR:
                        menuCadastros = new CadastroFornecedor();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    default:
                        menuCadastros = new CadastroPadrao();
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }

                switch (opcaoMenuCadastros)
                {
                    case (int)MenuEnums.LISTAR:
                        menuCadastros.Listar();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        menuCadastros.Cadastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadastros.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadastros.Excluir();
                        break;
                    default:
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }

            } while (opcao != (int)MenuEnums.SAIR);
        }
    }
}
