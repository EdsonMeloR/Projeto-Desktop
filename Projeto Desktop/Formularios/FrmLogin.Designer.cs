namespace Projeto_Desktop.Formularios
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.rbManterConectado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(156, 179);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(186, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(156, 227);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(186, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(156, 268);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(186, 23);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.Location = new System.Drawing.Point(156, 297);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(186, 23);
            this.btnRecuperarSenha.TabIndex = 5;
            this.btnRecuperarSenha.Text = "Recuperar Senha";
            this.btnRecuperarSenha.UseVisualStyleBackColor = true;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.btnRecuperarSenha_Click);
            // 
            // rbManterConectado
            // 
            this.rbManterConectado.AutoSize = true;
            this.rbManterConectado.Location = new System.Drawing.Point(156, 345);
            this.rbManterConectado.Name = "rbManterConectado";
            this.rbManterConectado.Size = new System.Drawing.Size(127, 17);
            this.rbManterConectado.TabIndex = 6;
            this.rbManterConectado.TabStop = true;
            this.rbManterConectado.Text = "Mantenha conectado";
            this.rbManterConectado.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.rbManterConectado);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Prosperity Log";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.RadioButton rbManterConectado;
    }
}