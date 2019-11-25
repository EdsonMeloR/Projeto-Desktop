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
            this.btnGerarNotaTransporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpNotasTransportes = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.grbCargasPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(6, 85);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(365, 21);
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
            this.cmbTiposFretes.Location = new System.Drawing.Point(6, 130);
            this.cmbTiposFretes.Name = "cmbTiposFretes";
            this.cmbTiposFretes.Size = new System.Drawing.Size(365, 21);
            this.cmbTiposFretes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veiculos Disponiveis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cubagem Total das Cargas";
            // 
            // txtCargasCubadas
            // 
            this.txtCargasCubadas.Enabled = false;
            this.txtCargasCubadas.Location = new System.Drawing.Point(6, 41);
            this.txtCargasCubadas.Name = "txtCargasCubadas";
            this.txtCargasCubadas.Size = new System.Drawing.Size(150, 20);
            this.txtCargasCubadas.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Motoristas Disponiveis";
            // 
            // cmbMotoristas
            // 
            this.cmbMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotoristas.FormattingEnabled = true;
            this.cmbMotoristas.Location = new System.Drawing.Point(162, 40);
            this.cmbMotoristas.Name = "cmbMotoristas";
            this.cmbMotoristas.Size = new System.Drawing.Size(209, 21);
            this.cmbMotoristas.TabIndex = 16;
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToOrderColumns = true;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.RowHeadersVisible = false;
            this.dgvCargasPedido.Size = new System.Drawing.Size(610, 158);
            this.dgvCargasPedido.TabIndex = 9;
            // 
            // grbCargasPedido
            // 
            this.grbCargasPedido.Controls.Add(this.dgvCargasPedido);
            this.grbCargasPedido.Location = new System.Drawing.Point(12, 52);
            this.grbCargasPedido.Name = "grbCargasPedido";
            this.grbCargasPedido.Size = new System.Drawing.Size(622, 183);
            this.grbCargasPedido.TabIndex = 10;
            this.grbCargasPedido.TabStop = false;
            this.grbCargasPedido.Text = "Cargas";
            // 
            // btnGerarNotaTransporte
            // 
            this.btnGerarNotaTransporte.Location = new System.Drawing.Point(12, 487);
            this.btnGerarNotaTransporte.Name = "btnGerarNotaTransporte";
            this.btnGerarNotaTransporte.Size = new System.Drawing.Size(127, 31);
            this.btnGerarNotaTransporte.TabIndex = 17;
            this.btnGerarNotaTransporte.Text = "Gerar Nota";
            this.btnGerarNotaTransporte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.txtCargasCubadas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbMotoristas);
            this.groupBox1.Controls.Add(this.cmbVeiculos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTiposFretes);
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 240);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipos de Fretes";
            // 
            // grpNotasTransportes
            // 
            this.grpNotasTransportes.Location = new System.Drawing.Point(640, 52);
            this.grpNotasTransportes.Name = "grpNotasTransportes";
            this.grpNotasTransportes.Size = new System.Drawing.Size(215, 379);
            this.grpNotasTransportes.TabIndex = 19;
            this.grpNotasTransportes.TabStop = false;
            this.grpNotasTransportes.Text = "Notas Transportes";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(383, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // FrmNotaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 522);
            this.Controls.Add(this.btnGerarNotaTransporte);
            this.Controls.Add(this.grpNotasTransportes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCargasPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label2);
            this.Name = "FrmNotaTransporte";
            this.Text = "Nota Transporte";
            this.Load += new System.EventHandler(this.FrmNotaTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.grbCargasPedido.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpNotasTransportes;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}