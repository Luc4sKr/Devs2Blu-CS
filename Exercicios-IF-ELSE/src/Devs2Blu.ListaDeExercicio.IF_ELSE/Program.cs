using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Devs2Blu.ListaDeExercicio.IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exercicioInput;
            int exercicio = 0;
            bool exercicioValido = false;

            do
            {
                Console.WriteLine("Exercicios: \n" +
                    "1 - Exercicio 1\n" +
                    "2 - Exercicio 2\n" +
                    "3 - Exercicio 3\n" +
                    "4 - Exercicio 4\n" +
                    "5 - Exercicio 5\n" +
                    "6 - Exercicio 6\n" +
                    "7 - Exercicio 7\n" +
                    "8 - Exercicio 8\n" +
                    "0 - Sair");

                exercicioValido = false;
                while (!exercicioValido)
                {
                    Console.Write("-> ");
                    exercicioInput = Console.ReadLine();
                    exercicioValido = Regex.IsMatch(exercicioInput, @"^[0-9]+$");
                    if (!exercicioValido)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                    else
                    {
                        exercicio = Convert.ToInt32(exercicioInput);
                    }
                }

                Console.Clear();
                if (exercicio == 1)
                {
                    Exercicio01();
                }
                else if (exercicio == 2)
                {
                    Exercicio02();
                }
                else if (exercicio == 3)
                {
                    Exercicio03();
                }
                else if (exercicio == 4)
                {
                    Exercicio04();
                }
                else if (exercicio == 5)
                {
                    Exercicio05();
                }
                else if (exercicio == 6)
                {
                    Exercicio06();
                }
                else if (exercicio == 7)
                {
                    Exercicio07();
                }
                else if (exercicio == 8)
                {
                    Exercicio08();
                }

                Console.Write("Presione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (exercicio != 0);

        }

        static void Exercicio01()
        {
            Console.WriteLine("-------- QUAL O MAIOR VALOR? --------\n");

            int valor1, valor2;

            Console.Write("Primeiro valor: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);

            Console.Write("Segundo valor: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);

            Console.WriteLine($"Valor 1: {valor1}\nValor 2: {valor2}");

            int maiorValor = 0;
            if (valor1 > valor2)
            {
                maiorValor = valor1;
            }
            else if (valor2 > valor1)
            {
                maiorValor = valor2;
            }
            else
            {
                Console.WriteLine("Os valores são iguais");
            }

            if (valor1 != valor2)
            {
                Console.WriteLine($"Maior valor: {maiorValor}");
            }
        }

        static void Exercicio02()
        {
            Console.WriteLine("-------- QUAL O MENOR VALOR? --------\n");

            Random random = new Random();

            int n1 = random.Next(0, 100);
            int n2 = random.Next(0, 100);
            int n3 = random.Next(0, 100);
            int n4 = random.Next(0, 100);
            int menorValor = 0;

            Console.WriteLine("Números gerados: \n" +
                $"N1 = {n1}\n" +
                $"N2 = {n2}\n" +
                $"N3 = {n3}\n" +
                $"N4 = {n4}\n");

            if ((n1 < n2) &&
                (n1 < n3) &&
                (n1 < n4))
            {
                menorValor = n1;
            }
            else if ((n2 < n3) &&
                       (n2 < n4))
            {
                menorValor = n2;
            }
            else if (n3 < n4)
            {
                menorValor = n3;
            }
            else
            {
                menorValor = n4;
            }

            Console.WriteLine($"Menor valor gerado: {menorValor}");

        }

        static void Exercicio03()
        {
            int numero;

            Console.WriteLine("-------- VERIFICAR SE O NÚMERO É PAR OU ÍMPAR --------\n");

            Console.Write("Digite um número: ");
            string numeroSTR = Console.ReadLine();
            Int32.TryParse(numeroSTR, out numero);

            if (numero - numero / 2 * 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar");
            }
        }

        static void Exercicio04()
        {
            Console.WriteLine("-------- LEITOR DE CÓDIGO --------\n");

            string codigo;
            string produto = "";

            Console.Write("Produtos: \n" +
                "001 - Arroz\n" +
                "002 - Feijão\n" +
                "003 - Farinha\n");

            Console.Write("Digite o código do produto: ");
            codigo = Console.ReadLine();

            if (codigo == "001")
            {
                produto = "Arroz";
            }
            else if (codigo == "002")
            {
                produto = "Feijão";
            }
            else if (codigo == "003")
            {
                produto = "Farinha";
            }
            else
            {
                produto = "Diversos";
            }

            Console.WriteLine($"Produto: {produto}");
        }

        static void Exercicio05()
        {
            Console.WriteLine("-------- VERIFICAÇÃO SE PODE VOTAR --------\n");

            var dataAtual = DateTime.Now.Year;
            int anoNascimento;

            Console.Write("Em que ano você nasceu? ");
            string anoNascimentoSTR = Console.ReadLine();
            Int32.TryParse(anoNascimentoSTR, out anoNascimento);

            int idade = dataAtual - anoNascimento;
            bool podeVotar = (idade >= 16) ? true : false;

            Console.WriteLine($"Idade: {idade}");

            if (podeVotar)
            {
                Console.WriteLine("Você pode votar");
            }
            else
            {
                Console.WriteLine("Você não pode votar");
            }
        }

        static void Exercicio06()
        {
            Console.WriteLine("-------- VALIDAÇÃO DE SENHA --------\n");

            const string SENHA_ACESSO = "1234";

            Console.Write("Informe a senha para acessar o sistema: ");
            string senhaInput = Console.ReadLine();

            if (senhaInput.Equals(SENHA_ACESSO))
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO!");
            }
        }

        static void Exercicio07()
        {
            Console.WriteLine("-------- VENDA DE MAÇÃS --------\n");

            int numDeMacas;
            const Double PRECO_MACAS_ATE_11 = 0.30;
            const Double PRECO_MACAS_1DUZIA = 0.25;
            Double totalPagamento;

            Console.Write("Deseja comprar quantas maças: ");
            string numDeMacasSTR = Console.ReadLine();
            Int32.TryParse(numDeMacasSTR, out numDeMacas);

            if (numDeMacas < 12)
            {
                totalPagamento = numDeMacas * PRECO_MACAS_ATE_11;
            }
            else
            {
                totalPagamento = numDeMacas * PRECO_MACAS_1DUZIA;
            }

            Console.WriteLine($"Maças compradoas: {numDeMacas} - Total a pagar: R${totalPagamento}");
        }

        static void Exercicio08()
        {
            Console.WriteLine("------- NÚMEROS EM ORDEM CRESCENTE --------\n");

            int n1, n2, n3;
            string textoFormatado = "";

            Console.Write("Digite o primeiro número: ");
            string n1STR = Console.ReadLine();
            Int32.TryParse(n1STR, out n1);

            Console.Write("Digite o segundo número: ");
            string n2STR = Console.ReadLine();
            Int32.TryParse(n2STR, out n2);

            Console.Write("Digite o terceiro número: ");
            string n3STR = Console.ReadLine();
            Int32.TryParse(n3STR, out n3);

            if ((n1 < n2) &&
                (n1 < n3))
            {
                textoFormatado += $"{n1} - ";
                if (n2 < n3)
                {
                    textoFormatado += $"{n2} - {n3}";
                }
                else
                {
                    textoFormatado += $"{n3} - {n2}";
                }
            }
            else if ((n2 < n1) &&
                       (n2 < n3))
            {
                textoFormatado += $"{n2} - ";
                if (n1 < n3)
                {
                    textoFormatado += $"{n1} - {n3}";
                }
                else
                {
                    textoFormatado += $"{n3} - {n1}";
                }
            }
            else if ((n3 < n1) &&
                       (n3 < n2))
            {
                textoFormatado += $"{n3} - ";
                if (n1 < n2)
                {
                    textoFormatado += $"{n1} - {n2}";
                }
                else
                {
                    textoFormatado += $"{n2} - {n1}";
                }
            }

            Console.WriteLine($"Oredem crescente: {textoFormatado}");

        }
    }
}
