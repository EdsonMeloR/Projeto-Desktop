namespace Projeto_Desktop.Formularios
{
    partial class FrmPrimeiroLogin
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
            this.lblPrimeiroLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroLogin
            // 
            this.lblPrimeiroLogin.AutoSize = true;
            this.lblPrimeiroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroLogin.Location = new System.Drawing.Point(242, 59);
            this.lblPrimeiroLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimeiroLogin.Name = "lblPrimeiroLogin";
            this.lblPrimeiroLogin.Size = new System.Drawing.Size(177, 37);
            this.lblPrimeiroLogin.TabIndex = 0;
            this.lblPrimeiroLogin.Text = "Bem-vindo!";
            this.lblPrimeiroLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(171, 163);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(343, 26);
            this.txtSenha.TabIndex = 2;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(171, 229);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(343, 26);
            this.txtSenha2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repita a Senha";
            // 
            // btnModificarSenha
            // 
            this.btnModificarSenha.Location = new System.Drawing.Point(275, 302);
            this.btnModificarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarSenha.Name = "btnModificarSenha";
            this.btnModificarSenha.Size = new System.Drawing.Size(112, 35);
            this.btnModificarSenha.TabIndex = 5;
            this.btnModificarSenha.Text = "Alterar Senha";
            this.btnModificarSenha.UseVisualStyleBackColor = true;
            this.btnModificarSenha.Click += new System.EventHandler(this.btnModificarSenha_Click);
            // 
            // FrmPrimeiroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 451);
            this.Controls.Add(this.btnModificarSenha);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrimeiroLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrimeiroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Login";
            this.Load += new System.EventHandler(this.FrmPrimeiroLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarSenha;
    }
}