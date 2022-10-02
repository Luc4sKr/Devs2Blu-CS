using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Interfaces;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;
            Console.Clear();

            Console.WriteLine("╔═ Cadastro de Médicos ════════════════════════╗");
            Console.WriteLine("║1 - Listar Médicos                            ║");
            Console.WriteLine("║2 - Cadastrar Médico                          ║");
            Console.WriteLine("║3 - Alterar Médico                            ║");
            Console.WriteLine("║4 - Excluir Médico                            ║");
            Console.WriteLine("║0 - Sair                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;
        }

        public void Listar()
        {
            ListarMedicos();
        }

        public void Cadastrar()
        {
            CadastrarMedico();
        }

        public void Alterar()
        {
            AlterarMedico();
        }

        public void Excluir()
        {
            ExcluirMedico();
        }
        #endregion

        private void ListarMedicos()
        {
            int i = 0;
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"╔═ Médico {i} ═══════════════════════════════");
                Console.WriteLine($"║Médico: {medico.CodigoMedico}");
                Console.WriteLine($"║Nome: {medico.Nome}");
                Console.WriteLine($"║CPF: {medico.CGCCPF}");
                Console.WriteLine($"║Especialidade: {medico.Especialidade}");
                Console.WriteLine($"║CRM: {medico.CRM}");
                Console.WriteLine($"╚════════════════════════════════════════════");

                i++;
            }

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
        }

        private void CadastrarMedico()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═══════════════════════ CADASTRAR MÉDICO ═══════════════════════╣");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("║Informe o nome do médico");
            Console.Write("╠══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("║Informe o CPF do médico");
            Console.Write("╠══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("║Informe a especialidade do médico");
            Console.Write("╠══ > ");
            String especialidade = Console.ReadLine();

            Console.WriteLine("║Informe o CRM do médico");
            Console.Write("╠══ > ");
            Int32 crm;
            Int32.TryParse(Console.ReadLine(), out crm);

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Medico medico = new Medico(codigo, nome, cpf, crm, especialidade);
            Program.Mock.ListaMedicos.Add(medico);

            Console.WriteLine("╠════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Médico cadastrado!                                              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();
            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
        }

        private void AlterarMedico()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠════════════════════════ ALTERAR MÉDICO ════════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Médicos: ");
            ListarSemDetalhes();

            Int32 codigoMedico;
            Boolean medicoEncontrado = false;
            Medico medicoParaAlterar = new Medico();

            Console.WriteLine("Código do Médico que deseja alterar");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            Console.Clear();

            int index = 0;
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                if (medico.CodigoMedico == codigoMedico)
                {
                    medicoEncontrado = true;
                    medicoParaAlterar = medico;
                }
                index++;
            }

            if (!medicoEncontrado)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║Médico não encontrado!                                          ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                return;
            }

            int opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {medicoParaAlterar.Codigo}/{medicoParaAlterar.CodigoMedico} | Nome: {medicoParaAlterar.Nome} | CPF: {medicoParaAlterar.CGCCPF} | {medicoParaAlterar.Especialidade} | {medicoParaAlterar.CRM}");
                Console.WriteLine($"╔══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"║Qual campo deseja alterar?                                                ║");
                Console.WriteLine($"║01 - Nome                                                                 ║");
                Console.WriteLine($"║02 - CPF                                                                  ║");
                Console.WriteLine($"║03 - Especialidade                                                        ║");
                Console.WriteLine($"║04 - CRM                                                                  ║");
                Console.WriteLine($"║00 - Sair                                                                 ║");
                Console.WriteLine($"╚══════════════════════════════════════════════════════════════════════════╝");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

                bool opcaoValida = true;
                switch (opcaoAlterar)
                {
                    case (int)MenuEnums.NOME_MEDICO:
                        Console.Write("Informe um novo nome: ");
                        medicoParaAlterar.Nome = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CPF_MEICO:
                        Console.Write("Informe um novo CPF: ");
                        medicoParaAlterar.CGCCPF = Console.ReadLine();
                        break;
                    case (int)MenuEnums.ESPECIALIDADE_MEDICO:
                        Console.Write("Informe uma nova especialidade: ");
                        medicoParaAlterar.Especialidade = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CRM_MEDICO:
                        Console.Write("Informe uma nova CRM: ");
                        Int32 crm;
                        Int32.TryParse(Console.ReadLine(), out crm);
                        medicoParaAlterar.CRM = crm;
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

        private void ExcluirMedico()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠════════════════════════ EXCLUIR MÉDICO ════════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("Médicos: ");
            ListarSemDetalhes();

            Int32 codigoMedico;
            Boolean medicoEncontrado = false;

            Console.WriteLine("Código do Médico que deseja exclir");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            Console.Clear();

            int index = 0;
            int indexMedico = 0;
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                if (medico.CodigoMedico == codigoMedico)
                {
                    medicoEncontrado = true;
                    indexMedico = index;
                }
                index++;
            }

            if (!medicoEncontrado)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║Médico não encontrado!                                          ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                return;
            }

            Program.Mock.ListaPacientes.RemoveAt(indexMedico);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Médico removido!                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
        }

        private void ListarSemDetalhes()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"{medico.CodigoMedico}, {medico.Nome}, {medico.CGCCPF}, {medico.Especialidade}, {medico.CRM}");   
            }
        }
    }
}
