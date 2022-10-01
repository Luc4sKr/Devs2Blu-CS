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

            Console.WriteLine("╔═ CADASTRO MÉDICOS ═══════════════════════════╗");
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
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("══════════════════════════════════════════════");
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("══════════════════════════════════════════════");
            }
        }

        private void CadastrarMedico()
        {
            Console.WriteLine("CADASTRAR MEDICO");
            Console.WriteLine("Informe o nome do médico");
            Console.Write("╚══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do médico");
            Console.Write("╚══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("Informe a especialidade do médico");
            Console.Write("╚══ > ");
            String especialidade = Console.ReadLine();

            Console.WriteLine("Informe o CRM do médico");
            Console.Write("╚══ > ");
            Int32 crm;
            Int32.TryParse(Console.ReadLine(), out crm);

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Medico medico = new Medico(codigo, nome, cpf, crm, especialidade);
            Program.Mock.ListaMedicos.Add(medico);

            Console.WriteLine("\nMédico cadastrado!");

        }

        private void AlterarMedico()
        {
            Console.WriteLine("ALTERAR MÉDICO");
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
                Console.WriteLine("Médico não encontrado");
                return;
            }

            int opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {medicoParaAlterar.Codigo}/{medicoParaAlterar.CodigoMedico} | Nome: {medicoParaAlterar.Nome} | CPF: {medicoParaAlterar.CGCCPF} | {medicoParaAlterar.Especialidade} | {medicoParaAlterar.CRM}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome");
                Console.WriteLine("02 - CPF");
                Console.WriteLine("03 - Especialidade");
                Console.WriteLine("04 - CRM");
                Console.WriteLine("00 - Sair");
                Console.WriteLine("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

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

        private void ExcluirMedico()
        {
            Console.WriteLine("EXCLUIR MÉDICO");
            Console.WriteLine("Médicos: ");
            ListarSemDetalhes();

            Int32 codigoMedico;
            Boolean medicoEncontrado = false;
            Medico medicoParaAlterar = new Medico();

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

            if (medicoEncontrado)
            {
                Program.Mock.ListaMedicos.RemoveAt(indexMedico);
                Console.WriteLine("Médico removido");
            } else
            {
                Console.WriteLine("Médico não encontrado");
            }
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
