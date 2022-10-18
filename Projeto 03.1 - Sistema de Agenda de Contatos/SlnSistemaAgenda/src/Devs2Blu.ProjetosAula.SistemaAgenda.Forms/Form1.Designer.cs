namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mskNumeroTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.numNumero = new System.Windows.Forms.NumericUpDown();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBirro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.gbCompromisso = new System.Windows.Forms.GroupBox();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridContatos = new System.Windows.Forms.DataGridView();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbContato.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).BeginInit();
            this.gbCompromisso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).BeginInit();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContato
            // 
            this.gbContato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbContato.Controls.Add(this.mskNumeroTel);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.txtNome);
            this.gbContato.Controls.Add(this.lblNumeroTel);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.lblNome);
            this.gbContato.Location = new System.Drawing.Point(13, 13);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(345, 126);
            this.gbContato.TabIndex = 0;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // mskNumeroTel
            // 
            this.mskNumeroTel.Location = new System.Drawing.Point(91, 94);
            this.mskNumeroTel.Mask = "(00) 00 00000-0000";
            this.mskNumeroTel.Name = "mskNumeroTel";
            this.mskNumeroTel.Size = new System.Drawing.Size(119, 22);
            this.mskNumeroTel.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Location = new System.Drawing.Point(7, 97);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(78, 16);
            this.lblNumeroTel.TabIndex = 2;
            this.lblNumeroTel.Text = "Número Tel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbEndereco
            // 
            this.gbEndereco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbEndereco.Controls.Add(this.numNumero);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.cboUF);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.mskCEP);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Controls.Add(this.lblUF);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.lblBirro);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Location = new System.Drawing.Point(12, 145);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(346, 158);
            this.gbEndereco.TabIndex = 1;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // numNumero
            // 
            this.numNumero.Location = new System.Drawing.Point(270, 89);
            this.numNumero.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numNumero.Name = "numNumero";
            this.numNumero.Size = new System.Drawing.Size(55, 22);
            this.numNumero.TabIndex = 3;
            this.numNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(65, 120);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(260, 22);
            this.txtRua.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(65, 92);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(133, 22);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(65, 60);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(133, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(270, 26);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(55, 24);
            this.cboUF.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(209, 95);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(65, 26);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(71, 22);
            this.mskCEP.TabIndex = 5;
            this.mskCEP.TextChanged += new System.EventHandler(this.mskCEP_TextChanged);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(25, 32);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(34, 16);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(239, 34);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(25, 16);
            this.lblUF.TabIndex = 1;
            this.lblUF.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(8, 63);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 16);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBirro
            // 
            this.lblBirro.AutoSize = true;
            this.lblBirro.Location = new System.Drawing.Point(16, 95);
            this.lblBirro.Name = "lblBirro";
            this.lblBirro.Size = new System.Drawing.Size(43, 16);
            this.lblBirro.TabIndex = 3;
            this.lblBirro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(27, 126);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(32, 16);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua";
            // 
            // gbCompromisso
            // 
            this.gbCompromisso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbCompromisso.Controls.Add(this.dtpDataFim);
            this.gbCompromisso.Controls.Add(this.dtpDataInicio);
            this.gbCompromisso.Controls.Add(this.txtDescricao);
            this.gbCompromisso.Controls.Add(this.txtTitulo);
            this.gbCompromisso.Controls.Add(this.lblDataFim);
            this.gbCompromisso.Controls.Add(this.lblDataInicio);
            this.gbCompromisso.Controls.Add(this.lblDescricao);
            this.gbCompromisso.Controls.Add(this.lblTitulo);
            this.gbCompromisso.Location = new System.Drawing.Point(13, 310);
            this.gbCompromisso.Name = "gbCompromisso";
            this.gbCompromisso.Size = new System.Drawing.Size(345, 203);
            this.gbCompromisso.TabIndex = 2;
            this.gbCompromisso.TabStop = false;
            this.gbCompromisso.Text = "Compromisso";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(78, 168);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(246, 22);
            this.dtpDataFim.TabIndex = 7;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(78, 137);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(246, 22);
            this.dtpDataInicio.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(78, 61);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(246, 65);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(78, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(119, 22);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(20, 173);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(56, 16);
            this.lblDataFim.TabIndex = 3;
            this.lblDataFim.Text = "Data fim";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(6, 142);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(70, 16);
            this.lblDataInicio.TabIndex = 2;
            this.lblDataInicio.Text = "Data início";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(7, 64);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 16);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(31, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gridContatos
            // 
            this.gridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContatos.Location = new System.Drawing.Point(364, 13);
            this.gridContatos.Name = "gridContatos";
            this.gridContatos.RowHeadersWidth = 51;
            this.gridContatos.RowTemplate.Height = 24;
            this.gridContatos.Size = new System.Drawing.Size(706, 553);
            this.gridContatos.TabIndex = 4;
            this.gridContatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContatos_CellContentDoubleClick);
            // 
            // gbButtons
            // 
            this.gbButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbButtons.Controls.Add(this.btnExcluir);
            this.gbButtons.Controls.Add(this.btnLimpar);
            this.gbButtons.Controls.Add(this.btnSalvar);
            this.gbButtons.ForeColor = System.Drawing.Color.Black;
            this.gbButtons.Location = new System.Drawing.Point(13, 520);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(345, 46);
            this.gbButtons.TabIndex = 5;
            this.gbButtons.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(249, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(135, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(23, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 578);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gridContatos);
            this.Controls.Add(this.gbCompromisso);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbContato);
            this.Name = "FormCadastro";
            this.Text = "Sistema de Agenda de Contatos";
            this.Activated += new System.EventHandler(this.FormCadastro_Activated);
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).EndInit();
            this.gbCompromisso.ResumeLayout(false);
            this.gbCompromisso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).EndInit();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBirro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.GroupBox gbCompromisso;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.NumericUpDown numNumero;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView gridContatos;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mskNumeroTel;
    }
}

