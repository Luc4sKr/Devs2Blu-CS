using Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using Correios;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Globalization;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using MySqlX.XDevAPI.Relational;
using System.Drawing.Text;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms
{
    public partial class FormCadastro : Form
    {
        public EnderecoRepository EnderecoRepository { get; set; }
        public ContatoRepository ContatoRepository { get; set; }
        public CompromissoRepository CompromissoRepository { get; set;   }

        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public Compromisso Compromisso { get; set; }

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

        /*private void PopulaGridContatos()
        {
            MySqlDataReader rdrContatos = ContatoRepository.GetAll();
            gridContatos.DataSource = new BindingSource(rdrContatos, null);
        }*/

        private void PopulaGrid()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            const string SQL_SELECT_ALL = @"SELECT
comp.id AS id_compromisso,
cont.id AS id_contato,
ende.id AS id_endereco,
comp.titulo,
comp.descricao,
comp.data_inicio,
comp.data_fim,
cont.nome,
cont.email,
cont.numero_tel,
ende.cep,
ende.uf,
ende.cidade,
ende.bairro,
ende.rua,
ende.numero
FROM compromisso comp
INNER JOIN contato cont ON comp.id_contato = cont.id
INNER JOIN endereco ende ON comp.id_endereco = ende.id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                gridContatos.DataSource = new BindingSource(dataReader, null);
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private bool ValidaForm()
        {
            return true;
        }

        private void SalvarEndereco()
        {
            String columns, values;

            Endereco = new Endereco();
            Endereco.Cep = mskCEP.Text.Replace(",", ".");
            Endereco.Uf = cboUF.Text;
            Endereco.Cidade = txtCidade.Text;
            Endereco.Bairro = txtBairro.Text;
            Endereco.Rua = txtRua.Text;
            Endereco.Numero = Int32.Parse(numNumero.Value.ToString());

            columns = "cep, uf, cidade, bairro, rua, numero";
            values = $"'{Endereco.Cep}', '{Endereco.Uf}', '{Endereco.Cidade}', '{Endereco.Bairro}', '{Endereco.Rua}', '{Endereco.Numero}'";

            try
            {
                int idInsert = EnderecoRepository.Insert(columns, values);
                Endereco.Id = idInsert;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao salvar endereco: {error}");
                throw;
            }
        }

        private void SalvarContato()
        {
            String columns, values;

            Contato = new Contato();
            Contato.Nome = txtNome.Text;
            Contato.Email = txtEmail.Text;
            Contato.Numero_tel = mskNumeroTel.Text;
            Contato.FlStatus = EnumFlstatus.A;

            columns = "nome, email, numero_tel, flstatus";
            values = $"'{Contato.Nome}', '{Contato.Email}', '{Contato.Numero_tel}', '{Contato.FlStatus}'";

            try
            {
                int idInsert = ContatoRepository.Insert(columns, values);
                Contato.Id = idInsert;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao salvar contato: {error}");
                throw;
            }
        }

        private void SalvarCompromisso()
        {
            String columns, values;

            Compromisso = new Compromisso();
            Compromisso.Contato = Contato;
            Compromisso.Endereco = Endereco;
            Compromisso.Titulo = txtTitulo.Text;
            Compromisso.Descricao = txtDescricao.Text;

            var diaDaSemana = dtpDataInicio.Value.ToString("ddd", new CultureInfo("pt-BR")).ToUpper();
            Compromisso.DiaSemana = diaDaSemana;

            Compromisso.DataInicio = Convert.ToDateTime(dtpDataInicio.Value.Date);
            Compromisso.DataFim = Convert.ToDateTime(dtpDataFim.Value.Date);
            Compromisso.FlStatus = EnumFlstatus.A;

            columns = "id_contato, id_endereco, titulo, descricao, dia_semana, data_inicio, data_fim, flstatus";
            values = $"'{Compromisso.Contato.Id}', '{Compromisso.Endereco.Id}', '{Compromisso.Titulo}', '{Compromisso.Descricao}', '{Compromisso.DiaSemana}', '{Compromisso.DataInicio}', '{Compromisso.DataFim}', '{Compromisso.FlStatus}'";

            try
            {
                int idInsert = CompromissoRepository.Insert(columns, values);
                Compromisso.Id = idInsert;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao salvar compromisso: {error}");
                throw;
            }
        }

        private void PopulaCamposForm()
        {
            txtNome.Text = Contato.Nome;
            txtEmail.Text = Contato.Email;
            mskNumeroTel.Text = Contato.Numero_tel;
            
            mskCEP.Text = Endereco.Cep;

            txtTitulo.Text = Compromisso.Titulo;
            txtDescricao.Text = Compromisso.Descricao;
            //dtpDataInicio.Value = (DateTime)Compromisso.DataInicio;
            //dtpDataFim.MaxDate = (DateTime)Compromisso.DataFim;
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
            //PopulaGridContatos();
            PopulaGrid();
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
            if (ValidaForm())
            {
                SalvarEndereco();
                SalvarContato();
                SalvarCompromisso();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void gridContatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idContato = (int)gridContatos.Rows[e.RowIndex].Cells["id_contato"].Value;
            int idEndereco = (int)gridContatos.Rows[e.RowIndex].Cells["id_endereco"].Value;
            int idCompromisso = (int)gridContatos.Rows[e.RowIndex].Cells["id_compromisso"].Value;

            Contato = ContatoRepository.FindById(idContato);
            Endereco = EnderecoRepository.FindById(idEndereco);
            Compromisso = CompromissoRepository.FindById(idCompromisso);

            MessageBox.Show($"idcompro {Compromisso.Id}, telnum {Contato.Numero_tel}");

            PopulaCamposForm();
        }
        #endregion
    }
}
