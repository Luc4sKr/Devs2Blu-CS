using Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using Correios;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms
{
    internal partial class FormCadastro : Form
    {
        public EnderecoRepository EnderecoRepository { get; set; }
        public ContatoRepository ContatoRepository { get; set; }
        public CompromissoRepository CompromissoRepository { get; set;   }

        public static Endereco EnderecoCompromisso { get; set; }
        public static Contato Contato { get; set; }
        public static Compromisso Compromisso { get; set; }

        public FormCadastro()
        {
            InitializeComponent();
        }

        #region Methods
        private void PopulaComboEstados()
        {
            var listEstados = EstadoRepository.FetchAll();
            cboUF.DataSource = new BindingSource(listEstados, null);
            cboUF.ValueMember = "uf";
            cboUF.DisplayMember = "uf";
        }

        private void PopulaGridContatos()
        {
            MySqlDataReader rdrContatos = ContatoRepository.FetchAll();
            gridContatos.DataSource = new BindingSource(rdrContatos, null);
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
            Compromisso = new Compromisso();
            Compromisso.Contato = Contato;
            Compromisso.Endereco = EnderecoCompromisso;
            Compromisso.Titulo = txtTitulo.Text;
            Compromisso.Descricao = txtDescricao.Text;

            var diaDaSemana = dtpDataInicio.Value.ToString("ddd", new CultureInfo("pt-BR")).ToUpper();
            Compromisso.DiaSemana = diaDaSemana;

            Compromisso.DataInicio = dtpDataInicio.Value;
            Compromisso.DataFim = dtpDataFim.Value;
            CompromissoRepository.Save();
        }
        #endregion

        #region Events
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            this.EnderecoRepository = new EnderecoRepository();
            this.ContatoRepository = new ContatoRepository();
            this.CompromissoRepository = new CompromissoRepository();

            PopulaComboEstados();
        }

        private void FormCadastro_Activated(object sender, EventArgs e)
        {
            PopulaGridContatos();
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            if (mskCEP.Text.Length == 10)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(mskCEP.Text);
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtRua.Text = retorno.end;
                    cboUF.Text = retorno.uf;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("CEP não encontrado!", erro.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCEP.Text = "";
                    mskCEP.Focus();
                }
            }
        }

        #region Buttons
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEndereco();
            SalvarContato();
            SalvarCompromisso();
        }


        #endregion

        #endregion

        
    }
}
