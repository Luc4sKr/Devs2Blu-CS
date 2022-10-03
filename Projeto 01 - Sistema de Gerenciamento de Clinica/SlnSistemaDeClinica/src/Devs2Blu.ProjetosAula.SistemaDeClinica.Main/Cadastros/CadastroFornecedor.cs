using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Interfaces;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model;
using System;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Cadastros
{
    internal class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;
            Console.Clear();

            Console.WriteLine("╔═ Cadastro de Fornecedores ═══════════════════╗");
            Console.WriteLine("║1 - Listar fornecedores                       ║");
            Console.WriteLine("║2 - Cadastrar fornecedores                    ║");
            Console.WriteLine("║3 - Alterar fornecedor                        ║");
            Console.WriteLine("║4 - Excluir fornecedor                        ║");
            Console.WriteLine("║0 - Sair                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;
        }

        public void Listar()
        {
            ListarFornecedores();
        }

        public void Cadastrar()
        {
            CadastrarFornecedor();
        }

        public void Alterar()
        {
            AlterarFornecedor();
        }

        public void Excluir()
        {
            ExcluirFornecedor();
        }
        #endregion

        private void ListarFornecedores()
        {
            int i = 1;
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"╔═ Fornecedor {i} ═════════════════════════════");
                Console.WriteLine($"║Fornecedor: {fornecedor.CodigoFornecedor}   ");
                Console.WriteLine($"║Nome: {fornecedor.Nome}                     ");
                Console.WriteLine($"║CPF: {fornecedor.CGCCPF}                    ");
                Console.WriteLine($"║Tipo fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine($"╚════════════════════════════════════════════");

                i++;
            }

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
        }

        private void CadastrarFornecedor()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═════════════════════ CADASTRAR FORNECEDOR ═════════════════════╣");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("║Informe o nome do fornecedor");
            Console.Write("╠══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("║Informe o CPF do fornecedor");
            Console.Write("╠══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("║Informe o tipo do fornecedor");
            Console.Write("╠══ > ");
            String tipoFornecedor = Console.ReadLine();

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Fornecedor fornecedor = new Fornecedor(codigo, nome, cpf, tipoFornecedor);
            Program.Mock.ListaFornecedores.Add(fornecedor);

            Console.WriteLine("╠════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Fornecedor cadastrado!                                          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();
            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
        }

        private void AlterarFornecedor()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠══════════════════════ ALTERAR FORNECEDOR ══════════════════════╣");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Fornecedores: ");
            ListarSemDetalhes();

            Int32 codigoFornecedor;
            Boolean fornecedorEncontrado = false;
            Fornecedor fornecedorParaAlterar = new Fornecedor();

            Console.WriteLine("Código do Paciente que deseja alterar");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            Console.Clear();

            int index = 0;
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                if (fornecedor.CodigoFornecedor == codigoFornecedor)
                {
                    fornecedorEncontrado = true;
                    fornecedorParaAlterar = fornecedor;
                }
                index++;
            }

            if (!fornecedorEncontrado)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║Paciete não encontrado!                                         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                return;
            }

            int opcaoAlterar;
            bool alterar = true;

            do
            {

                Console.WriteLine($"Fornecedor: {fornecedorParaAlterar.Codigo}/{fornecedorParaAlterar.CodigoFornecedor} | Nome: {fornecedorParaAlterar.Nome} | CPF: {fornecedorParaAlterar.CGCCPF} | Convênio: {fornecedorParaAlterar.TipoFornecedor}");
                Console.WriteLine($"╔══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"║Qual campo deseja alterar?                                                ║");
                Console.WriteLine($"║01 - Nome                                                                 ║");
                Console.WriteLine($"║02 - CPF                                                                  ║");
                Console.WriteLine($"║03 - Tipo fornecedor                                                      ║");
                Console.WriteLine($"║00 - Sair                                                                 ║");
                Console.WriteLine($"╚══════════════════════════════════════════════════════════════════════════╝");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

                bool opcaoValida = true;
                switch (opcaoAlterar)
                {
                    case (int)MenuEnums.NOME_FORNECEDOR:
                        Console.Write("Informe um novo nome: ");
                        fornecedorParaAlterar.Nome = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CPF_FORNECEDOR:
                        Console.Write("Informe um novo CPF: ");
                        fornecedorParaAlterar.CGCCPF = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CONVENIO_PACIENTE:
                        Console.Write("Informe um novo tipo de fornecedor: ");
                        fornecedorParaAlterar.TipoFornecedor = Console.ReadLine();
                        break;
                    case (int)MenuEnums.SAIR:
                        alterar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        opcaoValida = false;
                        break;
                }

                if (alterar && opcaoValida)
                {
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║Dado alterado com sucesso!                                      ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

                    Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (alterar);
        }

        private void ExcluirFornecedor()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠══════════════════════ EXCLUIR FORNECEDOR ══════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Fornecedores: ");
            ListarSemDetalhes();

            Int32 codigoFornecedor;
            Boolean fornecedorEncontrado = false;

            Console.WriteLine("Código do Fornecedor que deseja excluir");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            Console.Clear();

            int index = 0;
            int indexFornecedor = 0;
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                if (fornecedor.CodigoFornecedor == codigoFornecedor)
                {
                    fornecedorEncontrado = true;
                    indexFornecedor = index;

                }
                index++;
            }

            if (!fornecedorEncontrado)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║Paciete não encontrado!                                         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                return;
            }

            Program.Mock.ListaFornecedores.RemoveAt(indexFornecedor);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Fornecedor removido!                                            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
        }

        private void ListarSemDetalhes()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"{fornecedor.CodigoFornecedor}, {fornecedor.Nome}, {fornecedor.CGCCPF}, {fornecedor.TipoFornecedor}\n");
            }
        }
    }
}
