namespace Projeto_Desktop.Formularios
{
    partial class FrmNotaTransporte
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
            this.txtIdNotaTrasnporte = new System.Windows.Forms.TextBox();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbNotaTransporte = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.Observações = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTiposFretes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMotoristas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.grbCargasPedido = new System.Windows.Forms.GroupBox();
            this.grbNotaTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.grbCargasPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Nota Transporte";
            // 
            // txtIdNotaTrasnporte
            // 
            this.txtIdNotaTrasnporte.Location = new System.Drawing.Point(6, 41);
            this.txtIdNotaTrasnporte.Name = "txtIdNotaTrasnporte";
            this.txtIdNotaTrasnporte.Size = new System.Drawing.Size(100, 20);
            this.txtIdNotaTrasnporte.TabIndex = 3;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(374, 40);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(178, 21);
            this.cmbVeiculos.TabIndex = 4;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(18, 25);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Pedido";
            // 
            // grbNotaTransporte
            // 
            this.grbNotaTransporte.Controls.Add(this.button2);
            this.grbNotaTransporte.Controls.Add(this.label6);
            this.grbNotaTransporte.Controls.Add(this.txtDistancia);
            this.grbNotaTransporte.Controls.Add(this.Observações);
            this.grbNotaTransporte.Controls.Add(this.txtObservacoes);
            this.grbNotaTransporte.Controls.Add(this.label5);
            this.grbNotaTransporte.Controls.Add(this.cmbTiposFretes);
            this.grbNotaTransporte.Controls.Add(this.label4);
            this.grbNotaTransporte.Controls.Add(this.cmbMotoristas);
            this.grbNotaTransporte.Controls.Add(this.label3);
            this.grbNotaTransporte.Controls.Add(this.txtIdNotaTrasnporte);
            this.grbNotaTransporte.Controls.Add(this.label1);
            this.grbNotaTransporte.Controls.Add(this.cmbVeiculos);
            this.grbNotaTransporte.Location = new System.Drawing.Point(12, 260);
            this.grbNotaTransporte.Name = "grbNotaTransporte";
            this.grbNotaTransporte.Size = new System.Drawing.Size(883, 211);
            this.grbNotaTransporte.TabIndex = 8;
            this.grbNotaTransporte.TabStop = false;
            this.grbNotaTransporte.Text = "Nota de Transporte";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Nova Nota Transporte";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Distancia (KM)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(742, 41);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(135, 20);
            this.txtDistancia.TabIndex = 11;
            // 
            // Observações
            // 
            this.Observações.AutoSize = true;
            this.Observações.Location = new System.Drawing.Point(6, 64);
            this.Observações.Name = "Observações";
            this.Observações.Size = new System.Drawing.Size(70, 13);
            this.Observações.TabIndex = 10;
            this.Observações.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(6, 80);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(362, 125);
            this.txtObservacoes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipos de Fretes";
            // 
            // cmbTiposFretes
            // 
            this.cmbTiposFretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposFretes.FormattingEnabled = true;
            this.cmbTiposFretes.Location = new System.Drawing.Point(112, 40);
            this.cmbTiposFretes.Name = "cmbTiposFretes";
            this.cmbTiposFretes.Size = new System.Drawing.Size(256, 21);
            this.cmbTiposFretes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motoristas Disponiveis";
            // 
            // cmbMotoristas
            // 
            this.cmbMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotoristas.FormattingEnabled = true;
            this.cmbMotoristas.Location = new System.Drawing.Point(558, 40);
            this.cmbMotoristas.Name = "cmbMotoristas";
            this.cmbMotoristas.Size = new System.Drawing.Size(178, 21);
            this.cmbMotoristas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veiculos Disponiveis";
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToOrderColumns = true;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.RowHeadersVisible = false;
            this.dgvCargasPedido.Size = new System.Drawing.Size(871, 176);
            this.dgvCargasPedido.TabIndex = 9;
            // 
            // grbCargasPedido
            // 
            this.grbCargasPedido.Controls.Add(this.dgvCargasPedido);
            this.grbCargasPedido.Location = new System.Drawing.Point(12, 52);
            this.grbCargasPedido.Name = "grbCargasPedido";
            this.grbCargasPedido.Size = new System.Drawing.Size(883, 202);
            this.grbCargasPedido.TabIndex = 10;
            this.grbCargasPedido.TabStop = false;
            this.grbCargasPedido.Text = "Cargas";
            // 
            // FrmNotaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 482);
            this.Controls.Add(this.grbCargasPedido);
            this.Controls.Add(this.grbNotaTransporte);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label2);
            this.Name = "FrmNotaTransporte";
            this.Text = "Nota Transporte";
            this.Load += new System.EventHandler(this.FrmNotaTransporte_Load);
            this.grbNotaTransporte.ResumeLayout(false);
            this.grbNotaTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.grbCargasPedido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdNotaTrasnporte;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbNotaTransporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMotoristas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTiposFretes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label Observações;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
        private System.Windows.Forms.GroupBox grbCargasPedido;
    }
}