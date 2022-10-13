using Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms
{
    internal partial class FormCadastro : Form
    {
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();

        public static Endereco EnderecoCompromisso { get; set; }

        public Contato Contato = new Contato();
        public Compromisso Compromisso = new Compromisso();

        public FormCadastro()
        {
            InitializeComponent();
        }

        #region Methods
        private void PopulaComboEstados()
        {
            var listEstados = EstadoRepository.FetchAll();
            cboUF.DataSource = new BindingSource(listEstados, null);
            cboUF.DisplayMember = "uf";
        }
        #endregion

        #region Events
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            PopulaComboEstados();
        }

        #region Buttons
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EnderecoCompromisso = new Endereco();
            EnderecoCompromisso.Cep = mskCEP.Text.Replace(",", ".");
            EnderecoCompromisso.Uf = cboUF.Text;
            EnderecoCompromisso.Cidade = txtCidade.Text;
            EnderecoCompromisso.Bairro = txtBairro.Text;
            EnderecoCompromisso.Rua = txtRua.Text;
            EnderecoCompromisso.Numero = Int32.Parse(numNumero.Value.ToString());
            EnderecoRepository.Save();
        }
        #endregion

        #endregion


    }
}
