using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula07.Jogo21
{
    public class Player
    {
        public int Number { get; set; }
        public int Score { get; set; }

        public Player(int number, int score)
        {
            Number = number;
            Score = score;
        }

        public int CalcularPontos(int numero, int numeroAleatorio)
        {
            numero += Convert.ToInt32(numeroAleatorio);
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
