namespace Devs2Blu.ProjetosAula.AulaOPP02
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
            System.Windows.Forms.Label lblNome;
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbInformacoesPessoais = new System.Windows.Forms.GroupBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.gbTexto = new System.Windows.Forms.GroupBox();
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            lblNome = new System.Windows.Forms.Label();
            this.gbInformacoesPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNome.Location = new System.Drawing.Point(6, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(70, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(6, 70);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(82, 25);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Tel/Cel:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 29);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(59, 25);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // gbInformacoesPessoais
            // 
            this.gbInformacoesPessoais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbInformacoesPessoais.Controls.Add(this.txbEmail);
            this.gbInformacoesPessoais.Controls.Add(this.txbTel);
            this.gbInformacoesPessoais.Controls.Add(this.txbNome);
            this.gbInformacoesPessoais.Controls.Add(lblNome);
            this.gbInformacoesPessoais.Controls.Add(this.lblTel);
            this.gbInformacoesPessoais.Controls.Add(this.lblEmail);
            this.gbInformacoesPessoais.Location = new System.Drawing.Point(13, 13);
            this.gbInformacoesPessoais.Name = "gbInformacoesPessoais";
            this.gbInformacoesPessoais.Size = new System.Drawing.Size(335, 162);
            this.gbInformacoesPessoais.TabIndex = 4;
            this.gbInformacoesPessoais.TabStop = false;
            this.gbInformacoesPessoais.Text = "Informações pessoais";
            // 
            // gbEndereco
            // 
            this.gbEndereco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbEndereco.Controls.Add(this.txbNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txbEstado);
            this.gbEndereco.Controls.Add(this.txbCEP);
            this.gbEndereco.Controls.Add(this.txbBairro);
            this.gbEndereco.Controls.Add(this.lblEstado);
            this.gbEndereco.Controls.Add(this.txbCidade);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txbRua);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Location = new System.Drawing.Point(13, 181);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(335, 260);
            this.gbEndereco.TabIndex = 5;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(10, 66);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(53, 25);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(8, 181);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(81, 25);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(10, 143);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(69, 25);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(8, 216);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(86, 33);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(243, 22);
            this.txbNome.TabIndex = 3;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(86, 74);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(243, 22);
            this.txbTel.TabIndex = 4;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(86, 115);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(243, 22);
            this.txbEmail.TabIndex = 5;
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(101, 32);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(228, 22);
            this.txbCEP.TabIndex = 6;
            this.txbCEP.TextChanged += new System.EventHandler(this.txbCEP_TextChanged);
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(101, 70);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(228, 22);
            this.txbRua.TabIndex = 8;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(101, 146);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(228, 22);
            this.txbBairro.TabIndex = 9;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(101, 184);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(228, 22);
            this.txbCidade.TabIndex = 10;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(101, 219);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(228, 22);
            this.txbEstado.TabIndex = 11;
            // 
            // gbTexto
            // 
            this.gbTexto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTexto.Controls.Add(this.btnLimpar);
            this.gbTexto.Controls.Add(this.btnEnviar);
            this.gbTexto.Controls.Add(this.txbTexto);
            this.gbTexto.Location = new System.Drawing.Point(354, 13);
            this.gbTexto.Name = "gbTexto";
            this.gbTexto.Size = new System.Drawing.Size(416, 428);
            this.gbTexto.TabIndex = 6;
            this.gbTexto.TabStop = false;
            this.gbTexto.Text = "Texto";
            // 
            // txbTexto
            // 
            this.txbTexto.Location = new System.Drawing.Point(7, 22);
            this.txbTexto.Multiline = true;
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(402, 358);
            this.txbTexto.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Location = new System.Drawing.Point(101, 387);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 35);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(211, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 35);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(101, 107);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(228, 22);
            this.txbNumero.TabIndex = 13;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(10, 104);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(87, 25);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Número:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gbTexto);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbInformacoesPessoais);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInformacoesPessoais.ResumeLayout(false);
            this.gbInformacoesPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbTexto.ResumeLayout(false);
            this.gbTexto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbInformacoesPessoais;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.GroupBox gbTexto;
        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}

