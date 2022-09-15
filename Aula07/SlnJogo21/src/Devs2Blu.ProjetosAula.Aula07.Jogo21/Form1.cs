using System;
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

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            PontuacaoP1 = 0;
            PontuacaoP2 = 0;
            Rodada = 0;

            txtConsole.Text = "\r Pressione \"Iniciar\" para começar o jogo.";
            txtPlayer1.Text = "";
            txtPlayer2.Text = "";
        }
    }
}
