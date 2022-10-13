using Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data;
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
    public partial class FormCadastro : Form
    {
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
        #endregion
    }
}
