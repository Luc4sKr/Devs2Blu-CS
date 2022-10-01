using System;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils.Texto
{
    public static class DesenharTexto
    {
        public static void Titulo(String titulo)
        {
            Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("╔══════════════════════════════════════════════╦══════════════════════════════════════════════════════════════════════");
        }
    }
}
