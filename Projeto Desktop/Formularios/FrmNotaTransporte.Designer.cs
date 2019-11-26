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
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTiposFretes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCargasCubadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMotoristas = new System.Windows.Forms.ComboBox();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.grbCargasPedido = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCargasNota = new System.Windows.Forms.Button();
            this.btnGerarNotaTransporte = new System.Windows.Forms.Button();
            this.grpGerarNotaTransporte = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mncData = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.grbCargasPedido.SuspendLayout();
            this.grpGerarNotaTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(9, 87);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(374, 21);
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
            // cmbTiposFretes
            // 
            this.cmbTiposFretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposFretes.FormattingEnabled = true;
            this.cmbTiposFretes.Location = new System.Drawing.Point(9, 133);
            this.cmbTiposFretes.Name = "cmbTiposFretes";
            this.cmbTiposFretes.Size = new System.Drawing.Size(374, 21);
            this.cmbTiposFretes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veiculos Disponiveis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cubagem Total das Cargas";
            // 
            // txtCargasCubadas
            // 
            this.txtCargasCubadas.Enabled = false;
            this.txtCargasCubadas.Location = new System.Drawing.Point(9, 42);
            this.txtCargasCubadas.Name = "txtCargasCubadas";
            this.txtCargasCubadas.Size = new System.Drawing.Size(150, 20);
            this.txtCargasCubadas.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Motoristas Disponiveis";
            // 
            // cmbMotoristas
            // 
            this.cmbMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotoristas.FormattingEnabled = true;
            this.cmbMotoristas.Location = new System.Drawing.Point(165, 42);
            this.cmbMotoristas.Name = "cmbMotoristas";
            this.cmbMotoristas.Size = new System.Drawing.Size(218, 21);
            this.cmbMotoristas.TabIndex = 16;
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToAddRows = false;
            this.dgvCargasPedido.AllowUserToDeleteRows = false;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.ReadOnly = true;
            this.dgvCargasPedido.RowHeadersVisible = false;
            this.dgvCargasPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCargasPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargasPedido.Size = new System.Drawing.Size(831, 158);
            this.dgvCargasPedido.TabIndex = 9;
            // 
            // grbCargasPedido
            // 
            this.grbCargasPedido.Controls.Add(this.btnAdicionarCargasNota);
            this.grbCargasPedido.Controls.Add(this.dgvCargasPedido);
            this.grbCargasPedido.Location = new System.Drawing.Point(12, 52);
            this.grbCargasPedido.Name = "grbCargasPedido";
            this.grbCargasPedido.Size = new System.Drawing.Size(843, 217);
            this.grbCargasPedido.TabIndex = 10;
            this.grbCargasPedido.TabStop = false;
            this.grbCargasPedido.Text = "Cargas";
            // 
            // btnAdicionarCargasNota
            // 
            this.btnAdicionarCargasNota.Location = new System.Drawing.Point(6, 183);
            this.btnAdicionarCargasNota.Name = "btnAdicionarCargasNota";
            this.btnAdicionarCargasNota.Size = new System.Drawing.Size(187, 31);
            this.btnAdicionarCargasNota.TabIndex = 24;
            this.btnAdicionarCargasNota.Text = "Adicionar Cargas Selecionadas";
            this.btnAdicionarCargasNota.UseVisualStyleBackColor = true;
            this.btnAdicionarCargasNota.Click += new System.EventHandler(this.btnAdicionarCargasNota_Click);
            // 
            // btnGerarNotaTransporte
            // 
            this.btnGerarNotaTransporte.Location = new System.Drawing.Point(9, 380);
            this.btnGerarNotaTransporte.Name = "btnGerarNotaTransporte";
            this.btnGerarNotaTransporte.Size = new System.Drawing.Size(150, 31);
            this.btnGerarNotaTransporte.TabIndex = 17;
            this.btnGerarNotaTransporte.Text = "Gerar Nota";
            this.btnGerarNotaTransporte.UseVisualStyleBackColor = true;
            // 
            // grpGerarNotaTransporte
            // 
            this.grpGerarNotaTransporte.Controls.Add(this.label8);
            this.grpGerarNotaTransporte.Controls.Add(this.textBox2);
            this.grpGerarNotaTransporte.Controls.Add(this.label6);
            this.grpGerarNotaTransporte.Controls.Add(this.textBox1);
            this.grpGerarNotaTransporte.Controls.Add(this.label1);
            this.grpGerarNotaTransporte.Controls.Add(this.dataGridView1);
            this.grpGerarNotaTransporte.Controls.Add(this.btnGerarNotaTransporte);
            this.grpGerarNotaTransporte.Controls.Add(this.mncData);
            this.grpGerarNotaTransporte.Controls.Add(this.txtCargasCubadas);
            this.grpGerarNotaTransporte.Controls.Add(this.label7);
            this.grpGerarNotaTransporte.Controls.Add(this.label4);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbMotoristas);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbVeiculos);
            this.grpGerarNotaTransporte.Controls.Add(this.label5);
            this.grpGerarNotaTransporte.Controls.Add(this.label3);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbTiposFretes);
            this.grpGerarNotaTransporte.Location = new System.Drawing.Point(12, 275);
            this.grpGerarNotaTransporte.Name = "grpGerarNotaTransporte";
            this.grpGerarNotaTransporte.Size = new System.Drawing.Size(843, 419);
            this.grpGerarNotaTransporte.TabIndex = 18;
            this.grpGerarNotaTransporte.TabStop = false;
            this.grpGerarNotaTransporte.Text = "Nota Transporte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cargas a serem adicionadas na Nota de Transporte";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(199, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Distância";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor Frete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // mncData
            // 
            this.mncData.Location = new System.Drawing.Point(604, 29);
            this.mncData.Name = "mncData";
            this.mncData.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipos de Fretes";
            // 
            // FrmNotaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 702);
            this.Controls.Add(this.grpGerarNotaTransporte);
            this.Controls.Add(this.grbCargasPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label2);
            this.Name = "FrmNotaTransporte";
            this.Text = "Nota Transporte";
            this.Load += new System.EventHandler(this.FrmNotaTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.grbCargasPedido.ResumeLayout(false);
            this.grpGerarNotaTransporte.ResumeLayout(false);
            this.grpGerarNotaTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposFretes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCargasCubadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMotoristas;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
        private System.Windows.Forms.GroupBox grbCargasPedido;
        private System.Windows.Forms.Button btnGerarNotaTransporte;
        private System.Windows.Forms.GroupBox grpGerarNotaTransporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar mncData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdicionarCargasNota;
    }
}