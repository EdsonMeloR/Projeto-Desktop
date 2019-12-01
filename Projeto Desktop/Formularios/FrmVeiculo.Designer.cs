namespace Projeto_Desktop.Formularios
{
    partial class FrmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbPlacas = new System.Windows.Forms.ComboBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskPesoMaximo = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskLargura = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskComprimento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtIdVeiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCustoPorKm = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 239);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(78, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbPlacas
            // 
            this.cmbPlacas.FormattingEnabled = true;
            this.cmbPlacas.Location = new System.Drawing.Point(12, 81);
            this.cmbPlacas.Name = "cmbPlacas";
            this.cmbPlacas.Size = new System.Drawing.Size(130, 21);
            this.cmbPlacas.TabIndex = 1;
            this.cmbPlacas.SelectedIndexChanged += new System.EventHandler(this.cmbPlacas_SelectedIndexChanged);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(12, 268);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.RowHeadersVisible = false;
            this.dgvVeiculos.Size = new System.Drawing.Size(405, 178);
            this.dgvVeiculos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Veiculo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(148, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(130, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(9, 65);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 6;
            this.lblPlacas.Text = "Placas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modelo";
            // 
            // mskPesoMaximo
            // 
            this.mskPesoMaximo.Location = new System.Drawing.Point(148, 122);
            this.mskPesoMaximo.Name = "mskPesoMaximo";
            this.mskPesoMaximo.Size = new System.Drawing.Size(130, 20);
            this.mskPesoMaximo.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(284, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(133, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(12, 121);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(130, 20);
            this.txtRenavam.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RENAVAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Peso Máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Largura";
            // 
            // mskLargura
            // 
            this.mskLargura.Location = new System.Drawing.Point(12, 160);
            this.mskLargura.Name = "mskLargura";
            this.mskLargura.Size = new System.Drawing.Size(130, 20);
            this.mskLargura.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Altura";
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(284, 122);
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(133, 20);
            this.mskAltura.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Comprimento";
            // 
            // mskComprimento
            // 
            this.mskComprimento.Location = new System.Drawing.Point(148, 160);
            this.mskComprimento.Name = "mskComprimento";
            this.mskComprimento.Size = new System.Drawing.Size(130, 20);
            this.mskComprimento.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quantidade de Eixos";
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(284, 160);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(133, 20);
            this.txtEixos.TabIndex = 20;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(175, 239);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(78, 23);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(338, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(78, 23);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtIdVeiculo
            // 
            this.txtIdVeiculo.Enabled = false;
            this.txtIdVeiculo.Location = new System.Drawing.Point(12, 32);
            this.txtIdVeiculo.Name = "txtIdVeiculo";
            this.txtIdVeiculo.Size = new System.Drawing.Size(130, 20);
            this.txtIdVeiculo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Custo por KM";
            // 
            // mskCustoPorKm
            // 
            this.mskCustoPorKm.Location = new System.Drawing.Point(12, 206);
            this.mskCustoPorKm.Name = "mskCustoPorKm";
            this.mskCustoPorKm.Size = new System.Drawing.Size(266, 20);
            this.mskCustoPorKm.TabIndex = 26;
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 458);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskCustoPorKm);
            this.Controls.Add(this.txtIdVeiculo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEixos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskComprimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskLargura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskPesoMaximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.cmbPlacas);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.FrmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbPlacas;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPesoMaximo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskLargura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskComprimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEixos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtIdVeiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCustoPorKm;
    }
}