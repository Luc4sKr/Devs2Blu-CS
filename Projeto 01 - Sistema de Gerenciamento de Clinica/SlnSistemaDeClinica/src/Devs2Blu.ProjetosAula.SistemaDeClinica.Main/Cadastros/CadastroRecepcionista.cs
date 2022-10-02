using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Interfaces;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model;
using System;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;
            Console.Clear();

            Console.WriteLine("╔═ Cadastro de Recepcionista ══════════════════╗");
            Console.WriteLine("║1 - Listar recepcionista                      ║");
            Console.WriteLine("║2 - Cadastrar recepcionista                   ║");
            Console.WriteLine("║3 - Alterar recepcionista                     ║");
            Console.WriteLine("║4 - Excluir recepcionista                     ║");
            Console.WriteLine("║0 - Sair                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;
        }
        public void Listar()
        {
            ListarRecepcionista();
        }

        public void Cadastrar()
        {
            CadastrarRecepcionista();
        }

        public void Alterar()
        {
            AlterarRecepcionista();
        }

        public void Excluir()
        {
            ExcluirRecepcionista();
        }
        #endregion

        private void ListarRecepcionista()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("══════════════════════════════════════════════");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("══════════════════════════════════════════════");
            }
        }

        private void CadastrarRecepcionista()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠════════════════════ CADASTRAR RECEPCIONISTA ═══════════════════╣");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("║Informe o nome da recepcionista");
            Console.Write("╠══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("║Informe o CPF da recepcionista");
            Console.Write("╠══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("║Informe o setor da recepcionista");
            Console.Write("╠══ > ");
            String setor = Console.ReadLine();

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Recepcionista recepcionista = new Recepcionista(codigo, nome, cpf, setor);
            Program.Mock.ListaRecepcionistas.Add(recepcionista);

            Console.WriteLine("╠════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Recepcionista cadastrada!                                       ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
        }

        public void AlterarRecepcionista()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═════════════════════ ALTERAR RECEPCIONISTA ════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Recepcionistas: ");
            ListarSemDetalhes();

            Int32 codigoRecepcionista;
            Boolean recepcionistaEncontrada = false;
            Recepcionista recepcionistaParaAlterar = new Recepcionista();

            Console.WriteLine("Código da Recepcionista que deseja alterar");
            Console.WriteLine("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            Console.Clear();

            int index = 0;
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                if (recepcionista.CodigoRecepcionista == codigoRecepcionista)
                {
                    recepcionistaEncontrada = true;
                    recepcionistaParaAlterar = recepcionista;
                }
                index++;
            }

            if (!recepcionistaEncontrada)
            {
                Console.WriteLine("Recepcionista não encontrada");
                return;
            }

            int opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Recepcionista: {recepcionistaParaAlterar.Codigo}/{recepcionistaParaAlterar.CodigoRecepcionista}, Nome: {recepcionistaParaAlterar.Nome}, CPF: {recepcionistaParaAlterar.CGCCPF}, Setor: {recepcionistaParaAlterar.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome");
                Console.WriteLine("02 - CPF");
                Console.WriteLine("03 - Setor");
                Console.WriteLine("00 - Sair");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

                switch (opcaoAlterar)
                {
                    case (int)MenuEnums.NOME_RECEPCIONISTA:
                        Console.Write("Informe um novo nome: ");
                        recepcionistaParaAlterar.Nome = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CPF_RECEPCIONISTA:
                        Console.Write("Informe um novo CPF: ");
                        recepcionistaParaAlterar.CGCCPF = Console.ReadLine();
                        break;
                    case (int)MenuEnums.SETOR_RECEPCIONISTA:
                        Console.Write("Informe um novo setor: ");
                        recepcionistaParaAlterar.Setor = Console.ReadLine();
                        break;
                    case (int)MenuEnums.SAIR:
                        alterar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (alterar)
                {
                    Console.WriteLine("Dado Alterado com Sucesso!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (alterar);
        }

        public void ExcluirRecepcionista()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═════════════════════ ALTERAR RECEPCIONISTA ════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Recepcionistas: ");
            ListarSemDetalhes();

            Int32 codigoRecepcionista;
            Boolean recepcionistaEncontrada = false;

            Console.WriteLine("Código da Recepcionista que deseja alterar");
            Console.WriteLine("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            Console.Clear();

            int index = 0;
            int indexRecepcionista = 0;
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                if (recepcionista.CodigoRecepcionista == codigoRecepcionista)
                {
                    recepcionistaEncontrada = true;
                    indexRecepcionista = index;
                }
                index++;
            }

            if (recepcionistaEncontrada)
            {
                Program.Mock.ListaRecepcionistas.RemoveAt(indexRecepcionista);
                Console.WriteLine("Recepcionista removida");
            } else
            {
                Console.WriteLine("Recepcionista não encontrada");
            }
        }

        public void ListarSemDetalhes()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"{recepcionista.CodigoRecepcionista}, {recepcionista.Nome}, {recepcionista.CGCCPF}, {recepcionista.Setor}");
            }
        }
    }
}
