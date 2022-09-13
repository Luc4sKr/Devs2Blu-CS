using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Devs2Blu.ProjAula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeCandidato, situacaoCandidato, idadeInput, notaInput;
            int idadeCandidato = 0;
            float notaCandidato = 0;
            bool idadeValida = false, notaValida = false;

            Console.WriteLine("--- Bem vindo ao sistema ScoolSystem ---\n");

            Console.Write("Informe o nome do Aluno: ");
            nomeCandidato = Console.ReadLine();

            while (!idadeValida)
            {
                Console.Write("Informe a idade do Aluno: ");
                idadeInput = Console.ReadLine();
                idadeValida = Regex.IsMatch(idadeInput, @"^[0-9]+$");
                if (!idadeValida)
                {
                    Console.WriteLine("Idade inválida!");
                }
                else
                {
                    idadeCandidato = Convert.ToInt32(idadeInput);
                }
            }

            while (!notaValida)
            {
                Console.Write("Informe a nota do Aluno: ");
                notaInput = Console.ReadLine();
                notaValida = Regex.IsMatch(notaInput, @"^[0-9]+$");
                if (!notaValida)
                {
                    Console.WriteLine("Nota inválida");
                }
                else
                {
                    notaCandidato = Convert.ToInt32(notaInput);
                }
            }

            if (notaCandidato == 10)
            {
                situacaoCandidato = "Aprovado com exelência";
            }
            else
            {
                if (notaCandidato >= 7)
                {
                    situacaoCandidato = "Aprovado";
                }
                else
                {
                    if (notaCandidato >= 5)
                    {
                        situacaoCandidato = "Em recuperação";
                    }
                    else
                    {
                        situacaoCandidato = "Reprovado";
                    }
                }
            }

            Console.WriteLine($"\nNome: {nomeCandidato} - Idade: {idadeCandidato}");
            Console.WriteLine($"Nota: {notaCandidato} - Situação: {situacaoCandidato}\n");

            Console.Write("ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
