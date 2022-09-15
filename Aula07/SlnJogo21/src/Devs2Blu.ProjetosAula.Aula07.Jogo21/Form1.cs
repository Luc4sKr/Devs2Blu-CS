﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula07.Jogo21
{
    public partial class Form1 : Form
    {

        public int Rodada { get; set; }
        public int PontuacaoP1 { get; set; }
        public int PontuacaoP2 { get; set; }
        public string NumeroAleatorio { get; set; }

        public Form1()
        {
            InitializeComponent();
            Rodada = 1;
            PontuacaoP1 = 0;
            PontuacaoP2 = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Pressione \"Iniciar\" para começar o jogo.";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Primeira Rodada";
            txtConsole.Text += "\r\n Informe um número de 1 a 20";
            btnPlayer1.Enabled = true;
            txtInputP1.Focus();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Player 1 escolheu seu número...";
            txtPlayer1.Text += $"\r\n Número jogado: {txtInputP1.Text}";
            int playerInput = Int32.Parse(txtInputP1.Text);

            GeraNumeroPlayer2();
            GerarNumeroAleatorio();
            
            PontuacaoP1 = CalcularPontos(playerInput, PontuacaoP1);
            txtPlayer1.Text += $"\r\n Sua pontuação: {PontuacaoP1}";

            if (Rodada == 1)
            {
                btnPlayer1.Enabled = false;
                if (PontuacaoP1 > PontuacaoP2)
                {
                    txtConsole.Text += "\r\n --- Player 1 venceu --- ";
                    txtPlayer1.Text += "\r\n Você venceu";
                    txtPlayer2.Text += "\r\n Você perdeu";
                }
                else if (PontuacaoP1 < PontuacaoP2)
                {
                    txtConsole.Text += "\r\n --- Player 2 venceu --- ";
                    txtPlayer1.Text += "\r\n Você perdeu";
                    txtPlayer2.Text += "\r\n Você venceu";
                } else
                {
                    txtConsole.Text += "\r\n --- Empate --- ";
                    txtPlayer1.Text += "\r\n Empate";
                    txtPlayer2.Text += "\r\n Empate";
                }
            }
            Rodada++;
        }

        private void GeraNumeroPlayer2()
        {
            Random rd = new Random();
            string numeroPlayer2 = rd.Next(1, 21).ToString();
            txtPlayer2.Text += $"\r\n Número jogado: {numeroPlayer2}";
            txtConsole.Text += "\r\n Player 2 escolheu seu número...";

            PontuacaoP2 = CalcularPontos(Convert.ToInt32(numeroPlayer2), PontuacaoP2);
            txtPlayer2.Text += $"\r\n Sua pontuação: {PontuacaoP2}";
        }

        private void GerarNumeroAleatorio()
        {
            Random rd = new Random();
            NumeroAleatorio = rd.Next(1, 21).ToString();
            txtConsole.Text += $"\r\n O número aleatório gerado foi: {NumeroAleatorio}";
        }

        private int CalcularPontos(int valor, int pontos)
        {
            valor += Convert.ToInt32(NumeroAleatorio);

            switch (valor)
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

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "\r Pressione \"Iniciar\" para começar o jogo.";
            txtPlayer1.Text = "";
            txtPlayer2.Text = "";
        }
    }
}
