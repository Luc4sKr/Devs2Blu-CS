namespace Devs2BluProjetosAula.AulaOOP01Introducao
{
    partial class Form1
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
            this.gbCadastroDeFuncionarios = new System.Windows.Forms.GroupBox();
            this.labelAnos = new System.Windows.Forms.Label();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.gbTipoFuncionario = new System.Windows.Forms.GroupBox();
            this.rdRecepcionista = new System.Windows.Forms.RadioButton();
            this.rdDiretor = new System.Windows.Forms.RadioButton();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCadastroDeFuncionarios.SuspendLayout();
            this.gbTipoFuncionario.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroDeFuncionarios
            // 
            this.gbCadastroDeFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCadastroDeFuncionarios.Controls.Add(this.labelAnos);
            this.gbCadastroDeFuncionarios.Controls.Add(this.txtAnos);
            this.gbCadastroDeFuncionarios.Controls.Add(this.txtEndereco);
            this.gbCadastroDeFuncionarios.Controls.Add(this.txtNascimento);
            this.gbCadastroDeFuncionarios.Controls.Add(this.txtSobrenome);
            this.gbCadastroDeFuncionarios.Controls.Add(this.txtNome);
            this.gbCadastroDeFuncionarios.Controls.Add(this.labelSobrenome);
            this.gbCadastroDeFuncionarios.Controls.Add(this.gbTipoFuncionario);
            this.gbCadastroDeFuncionarios.Controls.Add(this.labelNascimento);
            this.gbCadastroDeFuncionarios.Controls.Add(this.labelEndereco);
            this.gbCadastroDeFuncionarios.Controls.Add(this.labelNome);
            this.gbCadastroDeFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroDeFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroDeFuncionarios.Name = "gbCadastroDeFuncionarios";
            this.gbCadastroDeFuncionarios.Size = new System.Drawing.Size(451, 426);
            this.gbCadastroDeFuncionarios.TabIndex = 0;
            this.gbCadastroDeFuncionarios.TabStop = false;
            this.gbCadastroDeFuncionarios.Text = "Cadastro de Funcionários";
            // 
            // labelAnos
            // 
            this.labelAnos.AutoSize = true;
            this.labelAnos.Location = new System.Drawing.Point(312, 102);
            this.labelAnos.Name = "labelAnos";
            this.labelAnos.Size = new System.Drawing.Size(41, 16);
            this.labelAnos.TabIndex = 10;
            this.labelAnos.Text = "anos";
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(271, 96);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.ReadOnly = true;
            this.txtAnos.Size = new System.Drawing.Size(35, 22);
            this.txtAnos.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(139, 130);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(229, 22);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(140, 96);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(115, 22);
            this.txtNascimento.TabIndex = 7;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(139, 64);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(229, 22);
            this.txtSobrenome.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 22);
            this.txtNome.TabIndex = 5;
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(11, 63);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(109, 20);
            this.labelSobrenome.TabIndex = 4;
            this.labelSobrenome.Text = "Sobrenome:";
            // 
            // gbTipoFuncionario
            // 
            this.gbTipoFuncionario.Controls.Add(this.rdRecepcionista);
            this.gbTipoFuncionario.Controls.Add(this.rdDiretor);
            this.gbTipoFuncionario.Location = new System.Drawing.Point(15, 188);
            this.gbTipoFuncionario.Name = "gbTipoFuncionario";
            this.gbTipoFuncionario.Size = new System.Drawing.Size(421, 100);
            this.gbTipoFuncionario.TabIndex = 3;
            this.gbTipoFuncionario.TabStop = false;
            this.gbTipoFuncionario.Text = "Tipo Funcionário";
            // 
            // rdRecepcionista
            // 
            this.rdRecepcionista.AutoSize = true;
            this.rdRecepcionista.Location = new System.Drawing.Point(213, 44);
            this.rdRecepcionista.Name = "rdRecepcionista";
            this.rdRecepcionista.Size = new System.Drawing.Size(128, 20);
            this.rdRecepcionista.TabIndex = 1;
            this.rdRecepcionista.TabStop = true;
            this.rdRecepcionista.Text = "Recepsionista";
            this.rdRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rdDiretor
            // 
            this.rdDiretor.AutoSize = true;
            this.rdDiretor.Location = new System.Drawing.Point(85, 44);
            this.rdDiretor.Name = "rdDiretor";
            this.rdDiretor.Size = new System.Drawing.Size(75, 20);
            this.rdDiretor.TabIndex = 0;
            this.rdDiretor.TabStop = true;
            this.rdDiretor.Text = "Diretor";
            this.rdDiretor.UseVisualStyleBackColor = true;
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(6, 97);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(114, 20);
            this.labelNascimento.TabIndex = 2;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(26, 132);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(94, 20);
            this.labelEndereco.TabIndex = 1;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(57, 32);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(63, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbStatus.Controls.Add(this.txtConsole);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(469, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(319, 252);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtConsole.Location = new System.Drawing.Point(6, 21);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(307, 225);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "Sistema de Cadastro de Funcionários...";
            // 
            // gbControles
            // 
            this.gbControles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbControles.Controls.Add(this.btnLimpar);
            this.gbControles.Controls.Add(this.btnSalvar);
            this.gbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControles.Location = new System.Drawing.Point(469, 270);
            this.gbControles.Name = "gbControles";
            this.gbControles.Padding = new System.Windows.Forms.Padding(0);
            this.gbControles.Size = new System.Drawing.Size(319, 168);
            this.gbControles.TabIndex = 2;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(103, 91);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 39);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(103, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 39);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbCadastroDeFuncionarios);
            this.Name = "Form1";
            this.Text = "Aula OOP 01 - Sistema de cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCadastroDeFuncionarios.ResumeLayout(false);
            this.gbCadastroDeFuncionarios.PerformLayout();
            this.gbTipoFuncionario.ResumeLayout(false);
            this.gbTipoFuncionario.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroDeFuncionarios;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.GroupBox gbTipoFuncionario;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Label labelAnos;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdRecepcionista;
        private System.Windows.Forms.RadioButton rdDiretor;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

