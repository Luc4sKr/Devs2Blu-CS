using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula05.Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio05();

            Console.ReadKey();
        }

        static void Exemplo()
        {
            string codigo;

            Console.WriteLine("Informe o código para ver a descrição: \n" +
                "- A23\n" +
                "- A35\n" +
                "- Z16");
            Console.Write("-> ");

            codigo = Console.ReadLine();

            switch (codigo)
            {
                case "A23":
                    Console.WriteLine("A23 - Materiais");
                    break;
                case "A35":
                    Console.WriteLine("A35 - Produtos perecíveis");
                    break;
                case "Z16":
                    Console.WriteLine("Z16 - Produtos químicos");
                    break;
                default:
                    Console.WriteLine("Produto não cadastrado");
                    break;
            }

            Console.ReadKey();
        }

        static void Exercicio01()
        {
            Console.WriteLine("-------- VENDA DE FRUTAS --------\n");

            Console.WriteLine("Frutas: \n" +
                "Maçã\n" +
                "Kiwi\n" +
                "Melancia");
            Console.Write("-> ");

            string fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MAÇA":
                    Console.WriteLine("Não vendemos essa fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;
                default:
                    Console.WriteLine("Fruta indisponível");
                    break;
            }
        }

        static void Exercicio02()
        {
            Console.WriteLine("-------- VENDA DE AUTOMÓVEIS --------\n");

            const string MSG_PR_OUTRO_MODELO = "Tem certeza que não prefere este modelo?";
            const string MSG_COMPRA_EFETUADA = "Compra efetuada com sucesso";
            const string MSG_VEICULO_INDISPONIVEL = "Não trabalhamos com este tipo de automóvel aqui";
    
            Console.Write("Automoveis: \n" +
                "Hatch\n" +
                "Sedans\n" +
                "Motocicletas\n" +
                "Caminhonetes\n");

            Console.Write("-> ");
            string carro = Console.ReadLine();

            switch (carro.ToUpper())
            {
                case "HATCH":
                    Console.WriteLine(MSG_COMPRA_EFETUADA);
                    break;
                case "SEDANS":
                case "MOTOCICLETAS":
                case "CAMINHONETES":
                    Console.WriteLine(MSG_PR_OUTRO_MODELO);
                    break;
                default:
                    Console.WriteLine(MSG_VEICULO_INDISPONIVEL);
                    break;
            }
        }

        static void Exercicio03()
        {
            Console.WriteLine("-------- SIMULADOR DE CALCULADORA --------\n");

            string operador_matematico;
            int n1, n2;

            Console.Write("Operador: \n" +
                "1 - soma (+)\n" +
                "2 - subtração (-)\n" +
                "3 - multiplicação (*)\n" +
                "4 - divisão (/)\n");
            Console.Write("-> ");
            operador_matematico = Console.ReadLine();

            Console.Write("Número 1: ");
            string n1STR = Console.ReadLine();
            Int32.TryParse(n1STR, out n1);

            Console.Write("Número 2: ");
            string n2STR = Console.ReadLine();
            Int32.TryParse(n2STR, out n2);

            Double operacao = 0;
            string operador = "";
            switch (operador_matematico)
            {
                case "1":
                    operacao = n1 + n2;
                    operador = "+";
                    break;
                case "2":
                    operacao = n1 - n2;
                    operador = "-";
                    break;
                case "3":
                    operacao = n1 * n2;
                    operador = "*";
                    break;
                case "4":
                    operacao = n1 / n2;
                    operador = "/";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine($"{n1} {operador} {n2} = {operacao}");

        }

        static void Exercicio05()
        {
            Console.WriteLine("-------- JOGO DO 21 --------\n");

            Random random = new Random();
            int numero_jogado, numero_maquina, numero_aleatorio;

            Console.Write("Seu número: ");
            string numero_jogadoSTR = Console.ReadLine();
            Int32.TryParse(numero_jogadoSTR, out numero_jogado);

            numero_maquina = random.Next(1, 21);
            numero_aleatorio = random.Next(1, 21);

            Console.WriteLine($"\nNúmero do jogador: {numero_jogado}");
            Console.WriteLine($"Número da máquina: {numero_maquina}");
            Console.WriteLine($"Número aleatório: {numero_aleatorio}\n");

            int pontos_jogador = 0;
            switch (numero_jogado + numero_aleatorio)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontos_jogador += 1;
                    break;
                case 7:
                    pontos_jogador += 10;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontos_jogador += 5;
                    break;
                case 14:
                    pontos_jogador += 20;
                    break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontos_jogador += 6;
                    break;
                case 21:
                    pontos_jogador += 30;
                    break;

                default:
                    break;
            }

            int pontos_maquina = 0;
            switch (numero_maquina + numero_aleatorio)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontos_maquina += 1;
                    break;
                case 7:
                    pontos_maquina += 10;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontos_maquina += 5;
                    break;
                case 14:
                    pontos_maquina += 20;
                    break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontos_maquina += 6;
                    break;
                case 21:
                    pontos_maquina += 30;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Pontos jogador: {pontos_jogador}");
            Console.WriteLine($"Pontos máquina: {pontos_maquina}");

        }
    }
}
