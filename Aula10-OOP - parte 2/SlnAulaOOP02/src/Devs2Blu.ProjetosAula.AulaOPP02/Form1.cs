using Devs2Blu.ProjetosAula.OPP02Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOPP02
{
    public partial class Form1 : Form
    {

        public Contato Contato { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            Contato = new Contato();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contato.Nome = txbNome.Text;
            Contato.Tel = txbTel.Text;
            Contato.Email = txbEmail.Text;
            Contato.Cep = txbCEP.Text;
            Contato.Rua = txbRua.Text;
            Contato.Numero = txbNumero.Text;
            Contato.Nome = txbNome.Text;


            string txtMsg = $"{txbNome.Text}, texto enviado com sucesso.";
            string txtTitulo = "Formulário de contato";
            MessageBox.Show(this, txtMsg, txtTitulo);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void txbCEP_TextChanged(object sender, EventArgs e)
        {
            if (txbCEP.Text.Length == 8)
            {
                txbRua.Text = "7 de setembo";
                txbBairro.Text = "Centro";
                txbCidade.Text = "Blumenau";
                txbEstado.Text = "SC";
            } else
            {
                txbRua.Clear();
                txbNumero.Clear();
                txbBairro.Clear();
                txbCidade.Clear();
                txbEstado.Clear();
            }
        }
        #endregion


        #region Methods
        private void LimparForm()
        {
            txbTexto.Clear();
            txbNome.Clear();
            txbTel.Clear();
            txbEmail.Clear();
            txbCEP.Clear();
            txbRua.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbEstado.Clear();
        }

        public bool ValidaForm()
        {
            if (txbNome.Text.Equals("")) return false;
            if (txbTel.Text.Equals("")) return false;
            if (txbEmail.Text.Equals("")) return false;
            if (txbCEP.Text.Equals("")) return false;
            if (txbRua.Text.Equals("")) return false;
            if (txbNumero.Text.Equals("")) return false;
            if (txbBairro.Text.Equals("")) return false;
            if (txbCidade.Text.Equals("")) return false;
            if (txbEstado.Text.Equals("")) return false;
            return true;
        }

        #endregion

        
    }
}
