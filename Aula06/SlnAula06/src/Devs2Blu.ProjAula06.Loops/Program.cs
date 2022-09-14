using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjAula06.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("|      ___   __  ____    ___       ____  _____      |\r\n" +
                                  "|     /   | / / / / /   /   |     / __ \\/ ___/      |\r\n" +
                                  "|    / /| |/ / / / /   / /| |    / / / / __ \\       |\r\n" +
                                  "|   / ___ / /_/ / /___/ ___ |   / /_/ / /_/ /       |\r\n" +
                                  "|  /_/  |_\\____/_____/_/  |_|   \\____/\\____/        |\r");
                Console.WriteLine("-----------------------------------------------------");

                Console.WriteLine("Informe um dos códigos abaixo: ");
                Console.WriteLine("1 - Exemplo01");
                Console.WriteLine("2 - Exercício01");
                Console.WriteLine("3 - Exercício02");
                Console.WriteLine("4 - Exercício03");
                Console.WriteLine("5 - Exercício04");
                Console.WriteLine("6 - Exercício05");
                Console.WriteLine("7 - Exercício06");
                Console.WriteLine("0 - Sair");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out controle);

                Console.Clear();

                switch (controle)
                {
                    case 1:
                        Exemplo01();
                        break;
                    case 2:
                        Exercicio01();
                        break;
                    case 3:
                        Exercicio02();
                        break;
                    case 4:
                        Exercicio03();
                        break;
                    case 5:
                        Exercicio04();
                        break;
                    case 6:
                        Exercicio05();
                        break;
                    case 7:
                        Exercicio06();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para sair");
                Console.ReadKey();

            } while (controle != 0);
        }

        static void Exemplo01()
        {
            Console.WriteLine("    _______  __ ________  _______  __    ____     ___\r\n" +
                              "   / ____/ |/ // ____/  |/  / __ \\/ /   / __ \\   <  /\r\n" +
                              "  / __/  |   // __/ / /|_/ / /_/ / /   / / / /   / / \r\n" +
                              " / /___ /   |/ /___/ /  / / ____/ /___/ /_/ /   / /  \r\n" +
                              "/_____//_/|_/_____/_/  /_/_/   /_____/\\____/   /_/   \r\n");
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código '0' para sair");
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void Exercicio01()
        {
            Console.WriteLine("    _   __  __  __  _____________  ____  _____     __ __  _______  ___    ____  ___________\r\n" +
                              "   / | / /_/_/_/  |/  / ____/ __ \\/ __ \\/ ___/   _/_//  |/  / __ \\/   |  / __ \\/ ____/ ___/\r\n" +
                              "  /  |/ / / / / /|_/ / __/ / /_/ / / / /\\__ \\   /  _/ /|_/ / /_/ / /| | / /_/ / __/  \\__ \\ \r\n" +
                              " / /|  / /_/ / /  / / /___/ _, _/ /_/ /___/ /  _/ // /  / / ____/ ___ |/ _, _/ /___ ___/ / \r\n" +
                              "/_/ |_/\\____/_/  /_/_____/_/ |_|\\____//____/  /___/_/  /_/_/   /_/  |_/_/ |_/_____//____/  \r\n");

            int num = 0;
            
            while (num <= 100)
            {
                if (num % 2 != 0)
                {
                    Console.Write($"| {num} ");
                }
                if (num % 10 == 0)
                {
                    Console.WriteLine();
                }
                num++;
            }

            Console.ReadKey();
        }

        static void Exercicio02()
        {
            Console.WriteLine("    _   __  __  __  _____________  ____  _____    ____  ___    ____  ___________\r\n" +
                              "   / | / /_/_/_/  |/  / ____/ __ \\/ __ \\/ ___/   / __ \\/   |  / __ \\/ ____/ ___/\r\n" +
                              "  /  |/ / / / / /|_/ / __/ / /_/ / / / /\\__ \\   / /_/ / /| | / /_/ / __/  \\__ \\ \r\n" +
                              " / /|  / /_/ / /  / / /___/ _, _/ /_/ /___/ /  / ____/ ___ |/ _, _/ /___ ___/ / \r\n" +
                              "/_/ |_/\\____/_/  /_/_____/_/ |_|\\____//____/  /_/   /_/  |_/_/ |_/_____//____/  \r\n");

            int num = 0;

            while (num <= 100)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"| {num} ");
                    
                }
                if (num % 10 == 0 && num != 0)
                {
                    Console.WriteLine();
                }
                num++;
            }

            Console.ReadKey();
        }

        static void Exercicio03()
        {
            Console.WriteLine("    _   __  __  __  _____________  ____  _____    ____  ___    ____  ___________\r\n" +
                              "   / | / /_/_/_/  |/  / ____/ __ \\/ __ \\/ ___/   / __ \\/   |  / __ \\/ ____/ ___/\r\n" +
                              "  /  |/ / / / / /|_/ / __/ / /_/ / / / /\\__ \\   / /_/ / /| | / /_/ / __/  \\__ \\ \r\n" +
                              " / /|  / /_/ / /  / / /___/ _, _/ /_/ /___/ /  / ____/ ___ |/ _, _/ /___ ___/ / \r\n" +
                              "/_/ |_/\\____/_/  /_/_____/_/ |_|\\____//____/  /_/   /_/  |_/_/ |_/_____//____/  \r\n");
            Console.WriteLine("    ______    __ __  _______  ___    ____  ___________\r\n" +
                              "   / ____/  _/_//  |/  / __ \\/   |  / __ \\/ ____/ ___/\r\n" +
                              "  / __/    /  _/ /|_/ / /_/ / /| | / /_/ / __/  \\__ \\ \r\n" +
                              " / /___   _/ // /  / / ____/ ___ |/ _, _/ /___ ___/ / \r\n" +
                              "/_____/  /___/_/  /_/_/   /_/  |_/_/ |_/_____//____/  \r\n");

            int numUsuario, num = 0;

            Console.Write("Digite um número: ");
            Int32.TryParse(Console.ReadLine(), out numUsuario);

            while (num <= numUsuario)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num} - Par     ");
                } else
                {
                    Console.WriteLine($"{num} - Ímpar");
                }
                num++;
            }
            Console.WriteLine();
        }

        static void Exercicio04()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("     __  ___ __ ____  _______       ____  ___       ________  ______  __  ______ \r\n" +
                              "    /  |/  //_// __ \\/  _/   |     / __ \\/   |     /_  __/ / / / __ \\/  |/  /   |\r\n" +
                              "   / /|_/ / __/ / / // // /| |    / / / / /| |      / / / / / / /_/ / /|_/ / /| |\r\n" +
                              "  / /  / / _// /_/ // // ___ |   / /_/ / ___ |     / / / /_/ / _, _/ /  / / ___ |\r\n" +
                              " /_/  /_/___/_____/___/_/  |_|  /_____/_/  |_|    /_/  \\____/_/ |_/_/  /_/_/  |_|\r\n");
            Console.WriteLine("----------------------------------------------------------------------------------");

            int numeroAlunos, aluno = 1;
            Double nota, mediaTurma = 0;

            Console.Write("Número de alunos: ");
            Int32.TryParse(Console.ReadLine(), out numeroAlunos);

            while (aluno <= numeroAlunos)
            {
                Console.Write($"Digite a nota do {aluno}º Aluno: ");
                Double.TryParse(Console.ReadLine(), out nota);
                mediaTurma += nota;
                aluno++;
            }

            Console.WriteLine($"Média da turma: {mediaTurma / numeroAlunos}");

        }

        static void Exercicio05()
        {
            const int NUM = 20;
            int contador = 1;

            while (contador < NUM)
            {
                Console.WriteLine($"{contador}");
                contador++;
            }

            while (contador >= 1)
            {
                Console.Write($"{contador}  ");
                contador--;
            }

        }

        static void Exercicio06()
        {
            int contador = 1000;

            while (contador < 2000)
            {
                if (contador % 11 == 5)
                {
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
