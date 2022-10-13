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
        public ContatoRepository ContatoRepository = new ContatoRepository();
        

        public static Endereco EnderecoCompromisso { get; set; }
        public static Contato Contato { get; set; }
        public static Compromisso NovoCompromisso { get; set; }

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

        private void SalvarEndereco()
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

        private void SalvarContato()
        {
            Contato = new Contato();
            Contato.Nome = txtNome.Text;
            Contato.Email = txtEmail.Text;
            Contato.Numero_tel = mskNumeroTel.Text;
            ContatoRepository.Save();
        }

        private void SalvarCompromisso()
        {

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
            SalvarEndereco();
            SalvarContato();
        }
        #endregion

        #endregion


    }
}
