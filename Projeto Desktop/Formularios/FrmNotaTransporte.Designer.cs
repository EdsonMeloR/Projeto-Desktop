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
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCargasPedido = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCargasNota = new System.Windows.Forms.Button();
            this.btnGerarNotaTransporte = new System.Windows.Forms.Button();
            this.grpGerarNotaTransporte = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mncData = new System.Windows.Forms.MonthCalendar();
            this.txtCargasCubadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMotoristas = new System.Windows.Forms.ComboBox();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTiposFretes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCargasAdicionadas = new System.Windows.Forms.DataGridView();
            this.IdCargaAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LarguraAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlturaAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComprimentoAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.grbCargasPedido.SuspendLayout();
            this.grpGerarNotaTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasAdicionadas)).BeginInit();
            this.SuspendLayout();
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
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToAddRows = false;
            this.dgvCargasPedido.AllowUserToDeleteRows = false;
            this.dgvCargasPedido.AllowUserToResizeColumns = false;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCargasPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeProduto,
            this.Quantidade,
            this.Peso,
            this.Largura,
            this.Altura,
            this.Comprimento,
            this.ValorProduto});
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.ReadOnly = true;
            this.dgvCargasPedido.RowHeadersVisible = false;
            this.dgvCargasPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCargasPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargasPedido.Size = new System.Drawing.Size(831, 158);
            this.dgvCargasPedido.TabIndex = 9;
            this.dgvCargasPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargasPedido_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Largura
            // 
            this.Largura.HeaderText = "Largura";
            this.Largura.Name = "Largura";
            this.Largura.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Comprimento
            // 
            this.Comprimento.HeaderText = "Comprimento";
            this.Comprimento.Name = "Comprimento";
            this.Comprimento.ReadOnly = true;
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "Valor";
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
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
            this.btnGerarNotaTransporte.Location = new System.Drawing.Point(9, 364);
            this.btnGerarNotaTransporte.Name = "btnGerarNotaTransporte";
            this.btnGerarNotaTransporte.Size = new System.Drawing.Size(150, 31);
            this.btnGerarNotaTransporte.TabIndex = 17;
            this.btnGerarNotaTransporte.Text = "Nova Nota Transporte";
            this.btnGerarNotaTransporte.UseVisualStyleBackColor = true;
            // 
            // grpGerarNotaTransporte
            // 
            this.grpGerarNotaTransporte.Controls.Add(this.textBox2);
            this.grpGerarNotaTransporte.Controls.Add(this.label6);
            this.grpGerarNotaTransporte.Controls.Add(this.btnGerarNotaTransporte);
            this.grpGerarNotaTransporte.Controls.Add(this.textBox1);
            this.grpGerarNotaTransporte.Controls.Add(this.label1);
            this.grpGerarNotaTransporte.Controls.Add(this.mncData);
            this.grpGerarNotaTransporte.Controls.Add(this.txtCargasCubadas);
            this.grpGerarNotaTransporte.Controls.Add(this.label7);
            this.grpGerarNotaTransporte.Controls.Add(this.label4);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbMotoristas);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbVeiculos);
            this.grpGerarNotaTransporte.Controls.Add(this.label5);
            this.grpGerarNotaTransporte.Controls.Add(this.label3);
            this.grpGerarNotaTransporte.Controls.Add(this.cmbTiposFretes);
            this.grpGerarNotaTransporte.Controls.Add(this.label8);
            this.grpGerarNotaTransporte.Controls.Add(this.dgvCargasAdicionadas);
            this.grpGerarNotaTransporte.Location = new System.Drawing.Point(12, 275);
            this.grpGerarNotaTransporte.Name = "grpGerarNotaTransporte";
            this.grpGerarNotaTransporte.Size = new System.Drawing.Size(843, 404);
            this.grpGerarNotaTransporte.TabIndex = 18;
            this.grpGerarNotaTransporte.TabStop = false;
            this.grpGerarNotaTransporte.Text = "Nota Transporte";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(199, 338);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Distância";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Valor Frete";
            // 
            // mncData
            // 
            this.mncData.Location = new System.Drawing.Point(604, 196);
            this.mncData.Name = "mncData";
            this.mncData.TabIndex = 32;
            // 
            // txtCargasCubadas
            // 
            this.txtCargasCubadas.Enabled = false;
            this.txtCargasCubadas.Location = new System.Drawing.Point(9, 209);
            this.txtCargasCubadas.Name = "txtCargasCubadas";
            this.txtCargasCubadas.Size = new System.Drawing.Size(150, 20);
            this.txtCargasCubadas.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cubagem Total das Cargas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Motoristas Disponiveis";
            // 
            // cmbMotoristas
            // 
            this.cmbMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotoristas.FormattingEnabled = true;
            this.cmbMotoristas.Location = new System.Drawing.Point(165, 209);
            this.cmbMotoristas.Name = "cmbMotoristas";
            this.cmbMotoristas.Size = new System.Drawing.Size(218, 21);
            this.cmbMotoristas.TabIndex = 31;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(9, 254);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(374, 21);
            this.cmbVeiculos.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipos de Fretes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Veiculos Disponiveis";
            // 
            // cmbTiposFretes
            // 
            this.cmbTiposFretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposFretes.FormattingEnabled = true;
            this.cmbTiposFretes.Location = new System.Drawing.Point(9, 300);
            this.cmbTiposFretes.Name = "cmbTiposFretes";
            this.cmbTiposFretes.Size = new System.Drawing.Size(374, 21);
            this.cmbTiposFretes.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cargas a serem adicionadas na Nota de Transporte";
            // 
            // dgvCargasAdicionadas
            // 
            this.dgvCargasAdicionadas.AllowUserToAddRows = false;
            this.dgvCargasAdicionadas.AllowUserToDeleteRows = false;
            this.dgvCargasAdicionadas.AllowUserToResizeColumns = false;
            this.dgvCargasAdicionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCargasAdicionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCargaAdicionada,
            this.ProdutoAdicionada,
            this.QuantidadeAdicionada,
            this.PesoAdicionado,
            this.LarguraAdicionado,
            this.AlturaAdicionado,
            this.ComprimentoAltura,
            this.ValorAdicionado});
            this.dgvCargasAdicionadas.Location = new System.Drawing.Point(6, 34);
            this.dgvCargasAdicionadas.Name = "dgvCargasAdicionadas";
            this.dgvCargasAdicionadas.ReadOnly = true;
            this.dgvCargasAdicionadas.RowHeadersVisible = false;
            this.dgvCargasAdicionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargasAdicionadas.Size = new System.Drawing.Size(831, 150);
            this.dgvCargasAdicionadas.TabIndex = 18;
            // 
            // IdCargaAdicionada
            // 
            this.IdCargaAdicionada.HeaderText = "Id";
            this.IdCargaAdicionada.Name = "IdCargaAdicionada";
            this.IdCargaAdicionada.ReadOnly = true;
            // 
            // ProdutoAdicionada
            // 
            this.ProdutoAdicionada.HeaderText = "Produto";
            this.ProdutoAdicionada.Name = "ProdutoAdicionada";
            this.ProdutoAdicionada.ReadOnly = true;
            // 
            // QuantidadeAdicionada
            // 
            this.QuantidadeAdicionada.HeaderText = "Quantidade";
            this.QuantidadeAdicionada.Name = "QuantidadeAdicionada";
            this.QuantidadeAdicionada.ReadOnly = true;
            // 
            // PesoAdicionado
            // 
            this.PesoAdicionado.HeaderText = "Peso";
            this.PesoAdicionado.Name = "PesoAdicionado";
            this.PesoAdicionado.ReadOnly = true;
            // 
            // LarguraAdicionado
            // 
            this.LarguraAdicionado.HeaderText = "Largura";
            this.LarguraAdicionado.Name = "LarguraAdicionado";
            this.LarguraAdicionado.ReadOnly = true;
            // 
            // AlturaAdicionado
            // 
            this.AlturaAdicionado.HeaderText = "Altura";
            this.AlturaAdicionado.Name = "AlturaAdicionado";
            this.AlturaAdicionado.ReadOnly = true;
            // 
            // ComprimentoAltura
            // 
            this.ComprimentoAltura.HeaderText = "Comprimento";
            this.ComprimentoAltura.Name = "ComprimentoAltura";
            this.ComprimentoAltura.ReadOnly = true;
            // 
            // ValorAdicionado
            // 
            this.ValorAdicionado.HeaderText = "Valor";
            this.ValorAdicionado.Name = "ValorAdicionado";
            this.ValorAdicionado.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasAdicionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
        private System.Windows.Forms.GroupBox grbCargasPedido;
        private System.Windows.Forms.Button btnGerarNotaTransporte;
        private System.Windows.Forms.GroupBox grpGerarNotaTransporte;
        private System.Windows.Forms.DataGridView dgvCargasAdicionadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdicionarCargasNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mncData;
        private System.Windows.Forms.TextBox txtCargasCubadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMotoristas;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposFretes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargaAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoAdicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn LarguraAdicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlturaAdicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComprimentoAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAdicionado;
    }
}