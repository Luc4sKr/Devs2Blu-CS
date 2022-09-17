using Devs2Blu.ProjetosAula.AulaClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2BluProjetosAula.AulaOOP01Introducao
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretoresList { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretoresList = new List<Diretor>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdDiretor.Checked)
            {
                Diretor diretor = new Diretor();
                diretor.Nome = txtNome.Text;
                diretor.Sobrenome = txtSobrenome.Text;
                diretor.DataNascimento = Convert.ToDateTime(txtNascimento.Text);
                SalvarDiretor(diretor);
                txtConsole.Text += "\nDiretor Cadastrado";
            } else if (rdRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Nome = txtNome.Text;
                recepcionista.Sobrenome = txtSobrenome.Text;
                recepcionista.DataNascimento = Convert.ToDateTime(txtNascimento.Text);
                SalvarRecepcionista(recepcionista);
                txtConsole.Text += "\nRecepcionista Cadastrada";
            }
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparFormulario();
        }


        #region Methods
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
        }

        private void SalvarDiretor(Diretor diretor)
        {
            DiretoresList.Add(diretor);
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtNascimento.Text = "";
            txtEndereco.Text = "";
        }
        #endregion

        
    }
}
