using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Interfaces;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Texto;
using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model;
using System;


namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;
            Console.Clear();

            Console.WriteLine("╔═ Cadastro de Pacientes ══════════════════════╗");
            Console.WriteLine("║1 - Listar pacientes                          ║");
            Console.WriteLine("║2 - Cadastrar paciente                        ║");
            Console.WriteLine("║3 - Alterar paciente                          ║");
            Console.WriteLine("║4 - Excluir paciente                          ║");
            Console.WriteLine("║0 - Sair                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar()
        {
            CadastarPaciente();
        }

        public void Alterar()
        {
            AlterarPaciente();
        }

        public void Excluir()
        {
            ExcluirPaciete();
        }
        #endregion

        private void ListarPacientes()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("══════════════════════════════════════════════");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("══════════════════════════════════════════════");
            }
        }

        private void CadastarPaciente()
        {
            Console.WriteLine("╠══════════════════════ CADASTRAR PACIENTE ══════════════════════╣");

            Console.WriteLine("║Informe o nome do paciente");
            Console.Write("╚══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("║Informe o CPF do paciete");
            Console.Write("╚══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("║Informe o Convenio do paciente");
            Console.Write("╚══ > ");
            String convenio = Console.ReadLine();

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Paciente paciente = new Paciente(codigo, nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);

            Console.WriteLine("\nPaciete cadastrado!");

            Console.WriteLine("----------------------------------------------");
        }

        private void AlterarPaciente()
        {
            Console.WriteLine("-------------- ALTERAR PACIENTE --------------");
            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;
            Paciente pacienteParaAlterar = new Paciente();

            Console.WriteLine("Código do Paciente que deseja remover");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            Console.Clear();

            int index = 0;
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CodigoPaciente == codigoPaciente)
                {
                    pacienteEncontrado = true;
                    pacienteParaAlterar = paciente;
                }
                index++;
            }

            if (!pacienteEncontrado)
            {
                Console.WriteLine("Paciente não encontrado");
                return;
            }

            int opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"\nPaciente: {pacienteParaAlterar.Codigo}/{pacienteParaAlterar.CodigoPaciente} | Nome: {pacienteParaAlterar.Nome} | CPF: {pacienteParaAlterar.CGCCPF} | Convênio: {pacienteParaAlterar.Convenio}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome");
                Console.WriteLine("02 - CPF");
                Console.WriteLine("03 - Convênio");
                Console.WriteLine("00 - Sair");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

                switch (opcaoAlterar)
                {
                    case (int)MenuEnums.NOME_PACIENTE:
                        Console.Write("Informe um novo nome: ");
                        pacienteParaAlterar.Nome = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CPF_PACIENTE:
                        Console.Write("Informe um novo CPF: ");
                        pacienteParaAlterar.CGCCPF = Console.ReadLine();
                        break;
                    case (int)MenuEnums.CONVENIO_PACIENTE:
                        Console.Write("Informe um novo Convênio: ");
                        pacienteParaAlterar.Convenio = Console.ReadLine();
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

            Console.WriteLine("----------------------------------------------");
        }

        private void ExcluirPaciete()
        {
            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;

            Console.WriteLine("Código do Paciente que deseja alterar");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            int index = 0;
            int indexPaciente = 0;
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CodigoPaciente == codigoPaciente)
                {
                    pacienteEncontrado = true;
                    indexPaciente = index;

                }
                index++;
            }

            if (pacienteEncontrado)
            {
                Program.Mock.ListaPacientes.RemoveAt(indexPaciente);
                Console.WriteLine("Paciente removido");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado");
            }
        }

        private void ListarSemDetalhes()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine($"{paciente.CodigoPaciente}, {paciente.Nome}, {paciente.CGCCPF}, {paciente.Convenio}\n");
            }
        }
    }
}
