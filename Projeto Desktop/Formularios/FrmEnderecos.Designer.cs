namespace Projeto_Desktop.Formularios
{
    partial class FrmEnderecos
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
            this.btnConsultarCep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrarEndereco = new System.Windows.Forms.Button();
            this.btnConsultarEndereco = new System.Windows.Forms.Button();
            this.btnListarEndereco = new System.Windows.Forms.Button();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCep
            // 
            this.btnConsultarCep.Location = new System.Drawing.Point(421, 32);
            this.btnConsultarCep.Name = "btnConsultarCep";
            this.btnConsultarCep.Size = new System.Drawing.Size(88, 23);
            this.btnConsultarCep.TabIndex = 0;
            this.btnConsultarCep.Text = "Consultar Cep";
            this.btnConsultarCep.UseVisualStyleBackColor = true;
            this.btnConsultarCep.Click += new System.EventHandler(this.btnConsultarCep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Endereço";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(150, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(12, 75);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(238, 20);
            this.txtLogradouro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logradouro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(12, 114);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(403, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cep";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(12, 153);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(497, 54);
            this.txtReferencia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Referencia";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(263, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(152, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(263, 35);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(152, 20);
            this.txtCep.TabIndex = 13;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(12, 35);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Clientes";
            // 
            // btnCadastrarEndereco
            // 
            this.btnCadastrarEndereco.Location = new System.Drawing.Point(12, 213);
            this.btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            this.btnCadastrarEndereco.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarEndereco.TabIndex = 16;
            this.btnCadastrarEndereco.Text = "Cadastrar";
            this.btnCadastrarEndereco.UseVisualStyleBackColor = true;
            this.btnCadastrarEndereco.Click += new System.EventHandler(this.btnCadastrarEndereco_Click);
            // 
            // btnConsultarEndereco
            // 
            this.btnConsultarEndereco.Location = new System.Drawing.Point(118, 213);
            this.btnConsultarEndereco.Name = "btnConsultarEndereco";
            this.btnConsultarEndereco.Size = new System.Drawing.Size(121, 23);
            this.btnConsultarEndereco.TabIndex = 17;
            this.btnConsultarEndereco.Text = "Consultar";
            this.btnConsultarEndereco.UseVisualStyleBackColor = true;
            this.btnConsultarEndereco.Click += new System.EventHandler(this.btnConsultarEndereco_Click);
            // 
            // btnListarEndereco
            // 
            this.btnListarEndereco.Location = new System.Drawing.Point(245, 213);
            this.btnListarEndereco.Name = "btnListarEndereco";
            this.btnListarEndereco.Size = new System.Drawing.Size(100, 23);
            this.btnListarEndereco.TabIndex = 18;
            this.btnListarEndereco.Text = "Listar";
            this.btnListarEndereco.UseVisualStyleBackColor = true;
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Location = new System.Drawing.Point(18, 242);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.RowHeadersVisible = false;
            this.dgvEnderecos.Size = new System.Drawing.Size(491, 220);
            this.dgvEnderecos.TabIndex = 19;
            // 
            // FrmEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 474);
            this.Controls.Add(this.dgvEnderecos);
            this.Controls.Add(this.btnListarEndereco);
            this.Controls.Add(this.btnConsultarEndereco);
            this.Controls.Add(this.btnCadastrarEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarCep);
            this.Name = "FrmEnderecos";
            this.Text = "Enderecos";
            this.Load += new System.EventHandler(this.FrmEnderecos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrarEndereco;
        private System.Windows.Forms.Button btnConsultarEndereco;
        private System.Windows.Forms.Button btnListarEndereco;
        private System.Windows.Forms.DataGridView dgvEnderecos;
    }
}