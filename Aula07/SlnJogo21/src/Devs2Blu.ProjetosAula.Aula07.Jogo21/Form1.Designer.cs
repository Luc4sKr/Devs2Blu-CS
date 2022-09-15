namespace Devs2Blu.ProjetosAula.Aula07.Jogo21
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
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.txtInputP1 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.txtInputP2 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.gbConsole = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.gbConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPlayer1.Controls.Add(this.btnPlayer1);
            this.gbPlayer1.Controls.Add(this.txtInputP1);
            this.gbPlayer1.Controls.Add(this.txtPlayer1);
            this.gbPlayer1.Location = new System.Drawing.Point(12, 231);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(333, 253);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Enabled = false;
            this.btnPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.Location = new System.Drawing.Point(217, 217);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(110, 30);
            this.btnPlayer1.TabIndex = 2;
            this.btnPlayer1.Text = "ok";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // txtInputP1
            // 
            this.txtInputP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputP1.Location = new System.Drawing.Point(7, 217);
            this.txtInputP1.Name = "txtInputP1";
            this.txtInputP1.Size = new System.Drawing.Size(204, 30);
            this.txtInputP1.TabIndex = 1;
            this.txtInputP1.Text = "0";
            this.txtInputP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPlayer1.Location = new System.Drawing.Point(7, 22);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ReadOnly = true;
            this.txtPlayer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer1.Size = new System.Drawing.Size(320, 189);
            this.txtPlayer1.TabIndex = 0;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPlayer2.Controls.Add(this.btnPlayer2);
            this.gbPlayer2.Controls.Add(this.txtInputP2);
            this.gbPlayer2.Controls.Add(this.txtPlayer2);
            this.gbPlayer2.Location = new System.Drawing.Point(598, 231);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(333, 253);
            this.gbPlayer2.TabIndex = 1;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2 (PC)";
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.Location = new System.Drawing.Point(217, 217);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(110, 30);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.Text = "ok";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            // 
            // txtInputP2
            // 
            this.txtInputP2.Enabled = false;
            this.txtInputP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputP2.Location = new System.Drawing.Point(7, 217);
            this.txtInputP2.Name = "txtInputP2";
            this.txtInputP2.Size = new System.Drawing.Size(204, 30);
            this.txtInputP2.TabIndex = 2;
            this.txtInputP2.Text = "0";
            this.txtInputP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPlayer2.Location = new System.Drawing.Point(7, 22);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ReadOnly = true;
            this.txtPlayer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer2.Size = new System.Drawing.Size(320, 189);
            this.txtPlayer2.TabIndex = 1;
            // 
            // gbConsole
            // 
            this.gbConsole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbConsole.Controls.Add(this.txtConsole);
            this.gbConsole.Location = new System.Drawing.Point(12, 12);
            this.gbConsole.Name = "gbConsole";
            this.gbConsole.Size = new System.Drawing.Size(919, 201);
            this.gbConsole.TabIndex = 1;
            this.gbConsole.TabStop = false;
            this.gbConsole.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Black;
            this.txtConsole.Location = new System.Drawing.Point(7, 22);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.ShortcutsEnabled = false;
            this.txtConsole.Size = new System.Drawing.Size(906, 173);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "Bem vindo ao Jogo 21";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(407, 253);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 36);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(407, 295);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(131, 36);
            this.btnNovoJogo.TabIndex = 4;
            this.btnNovoJogo.Text = "Novo jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.gbConsole);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Name = "Form1";
            this.Text = "Devs2Blu - Jogo 21";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.gbConsole.ResumeLayout(false);
            this.gbConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.GroupBox gbConsole;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox txtInputP1;
        private System.Windows.Forms.TextBox txtInputP2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNovoJogo;
    }
}

