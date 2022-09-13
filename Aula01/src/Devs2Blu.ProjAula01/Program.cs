using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjAula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string nomeUsuario, cidadeUsuario;
            string formatacaoDados = "Inicialização de variável...\n";

            // Entrada de dados
            // - Nome
            Console.Write("Informe seu nome: ");
            nomeUsuario = Console.ReadLine();

            // - Cidade
            Console.Write("Informe sua cidade: ");
            cidadeUsuario = Console.ReadLine();

            // Processamento
            // - Boas vindas (Nome)
            formatacaoDados += $"Seja bem-vindo, {nomeUsuario}!\n\n";

            // - Cidade do Usuário
            formatacaoDados += $"Localidade: {cidadeUsuario}";

            // Apresentação dos dados
            Console.WriteLine(formatacaoDados);

            // Pausa antes de encerrar
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}