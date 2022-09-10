using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula3.ListaDeExercicioCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio= - 1;

            do
            {
                Console.WriteLine("Exercicios: \n" +
                    "1 - Exercicio 1\n" +
                    "2 - Exercicio 2\n" +
                    "3 - Exercicio 3\n" +
                    "4 - Exercicio 4\n" +
                    "5 - Exercicio 5\n" +
                    "6 - Exercicio 6");
                Console.Write("-> ");
                exercicio = Int32.Parse(Console.ReadLine());

                Console.Clear();
                if (exercicio == 1)
                {
                    Console.WriteLine("EM PRODUÇÃO");
                }
                else if (exercicio == 2)
                {
                    Console.WriteLine("EM PRODUÇÃO");
                }
                else if (exercicio == 3)
                {
                    Exercicio3();
                }
                else if (exercicio == 4)
                {
                    Exercicio4();
                }
                else if (exercicio == 5)
                {
                    Exercicio5();
                }
                else if (exercicio == 6)
                {
                    Exercicio6();
                }
            } while (exercicio != 0);
            

            Console.ReadKey();
        }

        static void Exercicio3()
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

        static void Exercicio4()
        {
            Console.WriteLine("-------- LEITOR DE CÓDIGO --------");

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
            } else if (codigo == "002") {
                produto = "Feijão";
            } else if (codigo == "003") {
                produto = "Farinha";
            } else
            {
                produto = "Diversos";
            }

            Console.WriteLine($"Produto: {produto}");
        }

        static void Exercicio5()
        {
            var dateAndTime = DateTime.Now;
            var dataAtualSTR = dateAndTime.Date.ToString("yyyy");
            int dataAtual = Int32.Parse(dataAtualSTR);
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
            } else
            {
                Console.WriteLine("Você não pode votar");
            }
        }

        static void Exercicio6()
        {
            const string SENHA_ACESSO = "1234";

            Console.WriteLine("-------- VALIDAÇÃO DE SENHA --------");

            Console.Write("Informe a senha para acessar o sistema: ");
            string senhaInput = Console.ReadLine();

            if (senhaInput.Equals(SENHA_ACESSO))
            {
                Console.WriteLine("ACESSO PERMITIDO");
            } else
            {
                Console.WriteLine("ACESSO NEGADO!");
            }
        }
    }
}
