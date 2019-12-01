namespace Projeto_Desktop.Formularios
{
    partial class FrmMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotorista));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMotorista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCaminhoneiros = new System.Windows.Forms.ComboBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskValidadeCnh = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategoriasCnh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 154);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Motorista";
            // 
            // txtIdMotorista
            // 
            this.txtIdMotorista.Enabled = false;
            this.txtIdMotorista.Location = new System.Drawing.Point(12, 29);
            this.txtIdMotorista.Name = "txtIdMotorista";
            this.txtIdMotorista.ReadOnly = true;
            this.txtIdMotorista.Size = new System.Drawing.Size(100, 20);
            this.txtIdMotorista.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(215, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Validade CNH";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCpf.Enabled = false;
            this.lblCpf.Location = new System.Drawing.Point(215, 62);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(389, 78);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(171, 20);
            this.txtRg.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(386, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RG";
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(12, 117);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(200, 20);
            this.txtCnh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CNH";
            // 
            // cmbCaminhoneiros
            // 
            this.cmbCaminhoneiros.FormattingEnabled = true;
            this.cmbCaminhoneiros.Location = new System.Drawing.Point(12, 77);
            this.cmbCaminhoneiros.Name = "cmbCaminhoneiros";
            this.cmbCaminhoneiros.Size = new System.Drawing.Size(200, 21);
            this.cmbCaminhoneiros.TabIndex = 17;
            this.cmbCaminhoneiros.SelectedIndexChanged += new System.EventHandler(this.cmbCaminhoneiros_SelectedIndexChanged);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(218, 78);
            this.mskCpf.Mask = "000-000-000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(165, 20);
            this.mskCpf.TabIndex = 18;
            // 
            // mskValidadeCnh
            // 
            this.mskValidadeCnh.Location = new System.Drawing.Point(218, 117);
            this.mskValidadeCnh.Mask = "00/00/0000";
            this.mskValidadeCnh.Name = "mskValidadeCnh";
            this.mskValidadeCnh.Size = new System.Drawing.Size(165, 20);
            this.mskValidadeCnh.TabIndex = 19;
            this.mskValidadeCnh.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategoriasCnh
            // 
            this.cmbCategoriasCnh.FormattingEnabled = true;
            this.cmbCategoriasCnh.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbCategoriasCnh.Location = new System.Drawing.Point(389, 117);
            this.cmbCategoriasCnh.Name = "cmbCategoriasCnh";
            this.cmbCategoriasCnh.Size = new System.Drawing.Size(171, 21);
            this.cmbCategoriasCnh.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(389, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Categoria CNH";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoristas.Location = new System.Drawing.Point(12, 183);
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.RowHeadersVisible = false;
            this.dgvMotoristas.Size = new System.Drawing.Size(548, 215);
            this.dgvMotoristas.TabIndex = 22;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(152, 154);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 23);
            this.btnListar.TabIndex = 23;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(292, 154);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 23);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 410);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvMotoristas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCategoriasCnh);
            this.Controls.Add(this.mskValidadeCnh);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.cmbCaminhoneiros);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMotorista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrando novo motorista";
            this.Load += new System.EventHandler(this.FrmMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCaminhoneiros;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskValidadeCnh;
        private System.Windows.Forms.ComboBox cmbCategoriasCnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
    }
}