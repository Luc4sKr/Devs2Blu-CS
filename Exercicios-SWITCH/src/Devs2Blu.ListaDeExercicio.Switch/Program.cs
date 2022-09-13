using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ListaDeExercicio.Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String exercicio = "";

            do
            {
                Console.WriteLine("-------- EXERCÍCIOS SWITCH --------\n");
                Console.WriteLine(
                    "1 - Exercicio 1\n" +
                    "2 - Exercicio 2\n" +
                    "3 - Exercicio 3\n" +
                    "4 - Exercicio 4\n" +
                    "5 - Exercicio 5\n" +
                    "0 - Sair");

                Console.Write("-> ");
                exercicio = Console.ReadLine();

                Console.Clear();

                switch (exercicio)
                {
                    case "1":
                        Exercicio01();
                        break;
                    case "2":
                        Exercicio02();
                        break;
                    case "3":
                        Exercicio03();
                        break;
                    case "4":
                        Exercicio04();
                        break;
                    case "5":
                        Exercicio05();
                        break;
                    default:
                        if (!exercicio.Equals("0"))
                        Console.WriteLine("Exercício indisponível");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (!exercicio.Equals("0"));
        }

        static void Exercicio01()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------- VENDA DE FRUTAS --------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Frutas: \n" +
                              "1 - Maçã\n" +
                              "2 - Kiwi\n" +
                              "3 - Melancia");
            Console.Write("-> ");

            string fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MAÇA":
                case "1":
                    Console.WriteLine("Não vendemos essa fruta aqui");
                    break;
                case "KIWI":
                case "2":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                case "3":
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
                "1 - Hatch\n" +
                "2 - Sedans\n" +
                "3 - Motocicletas\n" +
                "4 - Caminhonetes\n");

            Console.Write("-> ");
            string carro = Console.ReadLine();

            switch (carro.ToUpper())
            {
                case "HATCH":
                case "1":
                    Console.WriteLine(MSG_COMPRA_EFETUADA);
                    break;
                case "SEDANS":
                case "MOTOCICLETAS":
                case "CAMINHONETES":
                case string str when (str.Equals("2") || str.Equals("3") || str.Equals("4")):
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

        static void Exercicio04()
        {
            Console.WriteLine("-------- PRODUTOS --------\n");

            const string PRODUTOS_NAO_PERECIVEIS = "Arroz - Feijão - Café";
            const string FRUTAS = "Manga - Banana - Maçã";
            const string BEBIDAS = "Leite - Suco - Refrigerante";
            const string MSG_PRODUTO_INDISPONIVEL = "Produto indisponível";

            Console.Write("--- Produtos: \n" +
                              "1 - Não-perecíveis\n" +
                              "2 - Frutas\n" +
                              "3 - Bebidas\n");
            Console.Write("-> ");

            string produto = Console.ReadLine();

            switch (produto.ToUpper())
            {
                case "NÃO-PERECÍVEIS":
                case "1":
                    Console.WriteLine(PRODUTOS_NAO_PERECIVEIS);
                    break;
                case "FRUTAS":
                case "2":
                    Console.WriteLine(FRUTAS);
                    break;
                case "BEBIDAS":
                case "3":
                    Console.WriteLine(BEBIDAS);
                    break;
                default:
                    Console.WriteLine(MSG_PRODUTO_INDISPONIVEL);
                    break;
            }
        }

        static void Exercicio05()
        {
            Console.WriteLine("-------- JOGO DO 21 --------\n");

            Random random = new Random();
            int numeroJogado, numeroMaquina, numeroAleatorio;
            const string MSG_VITORIA = "PARABÉNS VOCÊ GANHOU!";
            const string MSG_EMPATE = "EMPATE!";
            const string MSG_DERROTA = "VOCÊ PERDEU!";

            Console.Write("Seu número: ");
            string numero_jogadoSTR = Console.ReadLine();
            Int32.TryParse(numero_jogadoSTR, out numeroJogado);

            numeroAleatorio = random.Next(1, 21);
            numeroMaquina = random.Next(1, 21);

            Console.WriteLine($"\nNúmero do jogador: {numeroJogado}");
            Console.WriteLine($"Número da máquina: {numeroMaquina}");
            Console.WriteLine($"Número aleatório: {numeroAleatorio}\n");

            int pontos_jogador = CalcularPontos(numeroJogado);
            int pontos_maquina = CalcularPontos(numeroMaquina);

            Console.WriteLine($"Pontos jogador: {pontos_jogador}");
            Console.WriteLine($"Pontos máquina: {pontos_maquina}\n");

            if (pontos_jogador > pontos_maquina)
            {
                Console.WriteLine(MSG_VITORIA);
            } 
            else if (pontos_jogador < pontos_maquina){
                Console.WriteLine(MSG_DERROTA);
            }
            else
            {
                Console.WriteLine(MSG_EMPATE);
            }

            int CalcularPontos(int numero)
            {
                numero += numeroAleatorio;
                int pontos = 0;

                switch (numero)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        pontos += 1;
                        break;
                    case 7:
                        pontos += 10;
                        break;

                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        pontos += 5;
                        break;
                    case 14:
                        pontos += 20;
                        break;

                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        pontos += 6;
                        break;
                    case 21:
                        pontos += 30;
                        break;

                    default:
                        break;
                }

                return pontos;
            }
        }
    }
}
