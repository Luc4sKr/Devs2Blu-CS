using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dev2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        static void Exemplo()
        {
            string textoSaida;
            string nomeUsuario;
            int idadeUsuario=0, notaUsuario=0;

            Console.WriteLine("|***** Bem vindo ao programa SysSchool *****|\n");

            Console.Write("Informe o nome do usuário: ");
            nomeUsuario = Console.ReadLine();
            if (nomeUsuario == "")
            {
                nomeUsuario = "User";
            }

            bool idadeValida = false;
            while (!idadeValida)
            {
                Console.Write("Informe a idade do usuário: ");
                string idadeSTR = Console.ReadLine();
                idadeValida = Regex.IsMatch(idadeSTR, @"^[0-9]+$");
                if (!idadeValida)
                {
                    Console.WriteLine("Idade inválida!");
                }
                else
                {
                    idadeUsuario = Int16.Parse(idadeSTR);
                }
            }


            bool notaValida = false;
            while (!notaValida)
            {
                Console.Write("Informe a nota do usuário: ");
                string notaSTR = Console.ReadLine();
                notaValida = Regex.IsMatch(notaSTR, @"^[0-9]+$");
                if (!idadeValida)
                {
                    Console.WriteLine("Nota inválida!");
                }
                else
                {
                    notaUsuario = Int16.Parse(notaSTR);
                }
            }


            // Formatação saída de dados
            textoSaida = $"Candidato: {nomeUsuario}\n";
            textoSaida += $"Idade: {idadeUsuario} - ";

            // Verificar se o candidato é maior de idade
            if (idadeUsuario < 18)
            {
                textoSaida += "Menor de idade\n";
            }
            else
            {
                textoSaida += "Maior de idade\n";
            }

            textoSaida += $"Nota Final: {notaUsuario}\n";
            if (notaUsuario == 10)
            {
                textoSaida += "Aprovado com exelência";
            }
            else
            {
                if (notaUsuario > 5)
                {
                    textoSaida += "Aprovado";
                }
                else
                {
                    textoSaida += "Reprovado :(";
                }
            }

            Console.WriteLine(textoSaida);

            Console.Write("\nPressione uma tecla para sair...");
            Console.ReadKey();
        }

        static void Exercicio1()
        {
            Console.WriteLine("--- QUAL O MAIOR VALOR? ---");

            int valor1, valor2;

            Console.Write("Valor 1: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);

            Console.Write("Valor 2: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);


            if (valor1 > valor2)
            {
                Console.WriteLine($"Maior valor: {valor1}");
            }
            else
            {
                if (valor1 < valor2)
                {
                    Console.WriteLine($"Maior valor: {valor2}");
                }
                else
                {
                    Console.WriteLine("Os valore são iguais");
                }
            }

            Console.Write("Pressione uma tecla para sair...");
            Console.ReadKey();
        }

        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;

            Console.WriteLine("QUAL O MENOR VALOR?");

            Console.Write("Valor 1: ");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.Write("Valor 2: ");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.Write("Valor 3: ");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.Write("Valor 4: ");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if ((valor1 < valor2) &&
                (valor1 < valor3) &&
                (valor1 < valor4))
            {
                Console.WriteLine($"Menor valor: {valor1}");
            } else if ((valor2 < valor3) &&
                       (valor2 < valor4))
            {
                Console.WriteLine($"Menor valor: {valor2}");
            } else if ((valor3 < valor4))
            {
                Console.WriteLine($"Menor valor: {valor3}");
            } else
            {
                Console.WriteLine($"Menor valor: {valor4}");
            }

        }
    }
}
