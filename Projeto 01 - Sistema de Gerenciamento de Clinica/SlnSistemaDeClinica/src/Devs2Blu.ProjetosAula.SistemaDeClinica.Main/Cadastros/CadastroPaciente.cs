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
            int i = 1;
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine($"╔═ Paciente {i} ═══════════════════════════════");
                Console.WriteLine($"║Paciente: {paciente.CodigoPaciente}         ");
                Console.WriteLine($"║Nome: {paciente.Nome}                       ");
                Console.WriteLine($"║CPF: {paciente.CGCCPF}                      ");
                Console.WriteLine($"║Convenio: {paciente.Convenio}               ");
                Console.WriteLine($"╚════════════════════════════════════════════");

                i++;
            }

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
        }

        private void CadastarPaciente()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠══════════════════════ CADASTRAR PACIENTE ══════════════════════╣");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("║Informe o nome do paciente");
            Console.Write("╠══ > ");
            String nome = Console.ReadLine();

            Console.WriteLine("║Informe o CPF do paciete");
            Console.Write("╠══ > ");
            String cpf = Console.ReadLine();

            Console.WriteLine("║Informe o Convenio do paciente");
            Console.Write("╠══ > ");
            String convenio = Console.ReadLine();

            Random random = new Random();
            Int32 codigo = random.Next(1, 100) + DateTime.Now.Second;

            Paciente paciente = new Paciente(codigo, nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);

            Console.WriteLine("╠════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Paciete cadastrado!                                             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();
            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
        }

        private void AlterarPaciente()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═══════════════════════ ALTERAR PACIENTE ═══════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;
            Paciente pacienteParaAlterar = new Paciente();

            Console.WriteLine("Código do Paciente que deseja alterar");
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
                
                Console.WriteLine($"Paciente: {pacienteParaAlterar.Codigo}/{pacienteParaAlterar.CodigoPaciente} | Nome: {pacienteParaAlterar.Nome} | CPF: {pacienteParaAlterar.CGCCPF} | Convênio: {pacienteParaAlterar.Convenio}");
                Console.WriteLine($"╔══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"║Qual campo deseja alterar?                                                ║");
                Console.WriteLine($"║01 - Nome                                                                 ║");
                Console.WriteLine($"║02 - CPF                                                                  ║");
                Console.WriteLine($"║03 - Convênio                                                             ║");
                Console.WriteLine($"║00 - Sair                                                                 ║");
                Console.WriteLine($"╚══════════════════════════════════════════════════════════════════════════╝");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out opcaoAlterar);

                bool opcaoValida = true;
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

        private void ExcluirPaciete()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═══════════════════════ EXCLUIR PACIENTE ═══════════════════════╣");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Pacientes: ");
            ListarSemDetalhes();

            Int32 codigoPaciente;
            Boolean pacienteEncontrado = false;

            Console.WriteLine("Código do Paciente que deseja excluir");
            Console.Write("-> ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            Console.Clear();

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

            if (!pacienteEncontrado)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║Paciete não encontrado!                                         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\nPressione 'ENTER' para continuar... ");
                return;
            }

            Program.Mock.ListaPacientes.RemoveAt(indexPaciente);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Paciete removido!                                               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nPressione 'ENTER' para continuar... ");
            Console.ReadKey();
            
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
