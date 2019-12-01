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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaTransporte));
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoCubagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCargasPedido = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCargasNota = new System.Windows.Forms.Button();
            this.grbItensNotaTransporte = new System.Windows.Forms.GroupBox();
            this.btnNotaTransporte = new System.Windows.Forms.Button();
            this.btnRemoverItemSelecionado = new System.Windows.Forms.Button();
            this.btnFinalizarNota = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCargasAdicionadas = new System.Windows.Forms.DataGridView();
            this.IdCargaAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CubagemAdicionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CubagemAssociada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAdicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdNotaTransporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbNotaTransporte = new System.Windows.Forms.GroupBox();
            this.btnGerarNotaTransporte = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorFrete = new System.Windows.Forms.TextBox();
            this.cmbTiposFretes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMotoristas = new System.Windows.Forms.ComboBox();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.cmbNotasGeradas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.grbCargasPedido.SuspendLayout();
            this.grbItensNotaTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasAdicionadas)).BeginInit();
            this.grbNotaTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(24, 20);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(135, 20);
            this.txtIdPedido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Pedido";
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToAddRows = false;
            this.dgvCargasPedido.AllowUserToDeleteRows = false;
            this.dgvCargasPedido.AllowUserToResizeColumns = false;
            this.dgvCargasPedido.AllowUserToResizeRows = false;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeProduto,
            this.Quantidade,
            this.Peso,
            this.Cubagem,
            this.CalculoCubagem,
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
            this.Id.Width = 70;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 128;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 130;
            // 
            // Cubagem
            // 
            this.Cubagem.HeaderText = "A x L x C";
            this.Cubagem.Name = "Cubagem";
            this.Cubagem.ReadOnly = true;
            this.Cubagem.Width = 130;
            // 
            // CalculoCubagem
            // 
            this.CalculoCubagem.HeaderText = "Cubagem M³";
            this.CalculoCubagem.Name = "CalculoCubagem";
            this.CalculoCubagem.ReadOnly = true;
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "Valor";
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
            this.ValorProduto.Width = 120;
            // 
            // grbCargasPedido
            // 
            this.grbCargasPedido.BackColor = System.Drawing.SystemColors.Control;
            this.grbCargasPedido.Controls.Add(this.btnAdicionarCargasNota);
            this.grbCargasPedido.Controls.Add(this.dgvCargasPedido);
            this.grbCargasPedido.Enabled = false;
            this.grbCargasPedido.Location = new System.Drawing.Point(12, 171);
            this.grbCargasPedido.Name = "grbCargasPedido";
            this.grbCargasPedido.Size = new System.Drawing.Size(843, 217);
            this.grbCargasPedido.TabIndex = 10;
            this.grbCargasPedido.TabStop = false;
            this.grbCargasPedido.Text = "Cargas";
            this.grbCargasPedido.Enter += new System.EventHandler(this.grbCargasPedido_Enter);
            // 
            // btnAdicionarCargasNota
            // 
            this.btnAdicionarCargasNota.Location = new System.Drawing.Point(6, 180);
            this.btnAdicionarCargasNota.Name = "btnAdicionarCargasNota";
            this.btnAdicionarCargasNota.Size = new System.Drawing.Size(187, 31);
            this.btnAdicionarCargasNota.TabIndex = 24;
            this.btnAdicionarCargasNota.Text = "Adicionar Cargas Selecionadas";
            this.btnAdicionarCargasNota.UseVisualStyleBackColor = true;
            this.btnAdicionarCargasNota.Click += new System.EventHandler(this.btnAdicionarCargasNota_Click);
            // 
            // grbItensNotaTransporte
            // 
            this.grbItensNotaTransporte.Controls.Add(this.btnNotaTransporte);
            this.grbItensNotaTransporte.Controls.Add(this.btnRemoverItemSelecionado);
            this.grbItensNotaTransporte.Controls.Add(this.btnFinalizarNota);
            this.grbItensNotaTransporte.Controls.Add(this.label8);
            this.grbItensNotaTransporte.Controls.Add(this.dgvCargasAdicionadas);
            this.grbItensNotaTransporte.Enabled = false;
            this.grbItensNotaTransporte.Location = new System.Drawing.Point(12, 394);
            this.grbItensNotaTransporte.Name = "grbItensNotaTransporte";
            this.grbItensNotaTransporte.Size = new System.Drawing.Size(843, 229);
            this.grbItensNotaTransporte.TabIndex = 18;
            this.grbItensNotaTransporte.TabStop = false;
            this.grbItensNotaTransporte.Text = "Nota Transporte";
            this.grbItensNotaTransporte.Enter += new System.EventHandler(this.grpGerarNotaTransporte_Enter);
            // 
            // btnNotaTransporte
            // 
            this.btnNotaTransporte.Enabled = false;
            this.btnNotaTransporte.Location = new System.Drawing.Point(318, 190);
            this.btnNotaTransporte.Name = "btnNotaTransporte";
            this.btnNotaTransporte.Size = new System.Drawing.Size(150, 31);
            this.btnNotaTransporte.TabIndex = 26;
            this.btnNotaTransporte.Text = "Gerar Pdf";
            this.btnNotaTransporte.UseVisualStyleBackColor = true;
            this.btnNotaTransporte.Click += new System.EventHandler(this.btnVisualizarNotaTransporte_Click);
            // 
            // btnRemoverItemSelecionado
            // 
            this.btnRemoverItemSelecionado.Location = new System.Drawing.Point(6, 190);
            this.btnRemoverItemSelecionado.Name = "btnRemoverItemSelecionado";
            this.btnRemoverItemSelecionado.Size = new System.Drawing.Size(150, 31);
            this.btnRemoverItemSelecionado.TabIndex = 25;
            this.btnRemoverItemSelecionado.Text = "Remover Item Selecionado";
            this.btnRemoverItemSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverItemSelecionado.Click += new System.EventHandler(this.btnRemoverItemSelecionado_Click);
            // 
            // btnFinalizarNota
            // 
            this.btnFinalizarNota.Location = new System.Drawing.Point(162, 190);
            this.btnFinalizarNota.Name = "btnFinalizarNota";
            this.btnFinalizarNota.Size = new System.Drawing.Size(150, 31);
            this.btnFinalizarNota.TabIndex = 24;
            this.btnFinalizarNota.Text = "Finalizar Nota Transporte";
            this.btnFinalizarNota.UseVisualStyleBackColor = true;
            this.btnFinalizarNota.Click += new System.EventHandler(this.btnFinalizarNota_Click);
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
            this.dgvCargasAdicionadas.AllowUserToResizeRows = false;
            this.dgvCargasAdicionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCargasAdicionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCargaAdicionada,
            this.ProdutoAdicionada,
            this.QuantidadeAdicionada,
            this.PesoAdicionado,
            this.CubagemAdicionada,
            this.CubagemAssociada,
            this.ValorAdicionado});
            this.dgvCargasAdicionadas.Location = new System.Drawing.Point(6, 34);
            this.dgvCargasAdicionadas.Name = "dgvCargasAdicionadas";
            this.dgvCargasAdicionadas.ReadOnly = true;
            this.dgvCargasAdicionadas.RowHeadersVisible = false;
            this.dgvCargasAdicionadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCargasAdicionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargasAdicionadas.Size = new System.Drawing.Size(831, 150);
            this.dgvCargasAdicionadas.TabIndex = 18;
            this.dgvCargasAdicionadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargasAdicionadas_CellContentClick);
            // 
            // IdCargaAdicionada
            // 
            this.IdCargaAdicionada.HeaderText = "Id";
            this.IdCargaAdicionada.Name = "IdCargaAdicionada";
            this.IdCargaAdicionada.ReadOnly = true;
            this.IdCargaAdicionada.Width = 70;
            // 
            // ProdutoAdicionada
            // 
            this.ProdutoAdicionada.HeaderText = "Produto";
            this.ProdutoAdicionada.Name = "ProdutoAdicionada";
            this.ProdutoAdicionada.ReadOnly = true;
            this.ProdutoAdicionada.Width = 150;
            // 
            // QuantidadeAdicionada
            // 
            this.QuantidadeAdicionada.HeaderText = "Quantidade";
            this.QuantidadeAdicionada.Name = "QuantidadeAdicionada";
            this.QuantidadeAdicionada.ReadOnly = true;
            this.QuantidadeAdicionada.Width = 128;
            // 
            // PesoAdicionado
            // 
            this.PesoAdicionado.HeaderText = "Peso";
            this.PesoAdicionado.Name = "PesoAdicionado";
            this.PesoAdicionado.ReadOnly = true;
            this.PesoAdicionado.Width = 150;
            // 
            // CubagemAdicionada
            // 
            this.CubagemAdicionada.HeaderText = "A x L x C";
            this.CubagemAdicionada.Name = "CubagemAdicionada";
            this.CubagemAdicionada.ReadOnly = true;
            this.CubagemAdicionada.Width = 110;
            // 
            // CubagemAssociada
            // 
            this.CubagemAssociada.HeaderText = "Cubagem M³";
            this.CubagemAssociada.Name = "CubagemAssociada";
            this.CubagemAssociada.ReadOnly = true;
            // 
            // ValorAdicionado
            // 
            this.ValorAdicionado.HeaderText = "Valor";
            this.ValorAdicionado.Name = "ValorAdicionado";
            this.ValorAdicionado.ReadOnly = true;
            this.ValorAdicionado.Width = 120;
            // 
            // txtIdNotaTransporte
            // 
            this.txtIdNotaTransporte.Enabled = false;
            this.txtIdNotaTransporte.Location = new System.Drawing.Point(165, 20);
            this.txtIdNotaTransporte.Name = "txtIdNotaTransporte";
            this.txtIdNotaTransporte.Size = new System.Drawing.Size(135, 20);
            this.txtIdNotaTransporte.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "ID Nota";
            // 
            // grbNotaTransporte
            // 
            this.grbNotaTransporte.Controls.Add(this.btnGerarNotaTransporte);
            this.grbNotaTransporte.Controls.Add(this.txtDistancia);
            this.grbNotaTransporte.Controls.Add(this.label6);
            this.grbNotaTransporte.Controls.Add(this.txtValorFrete);
            this.grbNotaTransporte.Controls.Add(this.cmbTiposFretes);
            this.grbNotaTransporte.Controls.Add(this.label1);
            this.grbNotaTransporte.Controls.Add(this.label3);
            this.grbNotaTransporte.Controls.Add(this.label4);
            this.grbNotaTransporte.Controls.Add(this.label5);
            this.grbNotaTransporte.Controls.Add(this.cmbMotoristas);
            this.grbNotaTransporte.Controls.Add(this.cmbVeiculos);
            this.grbNotaTransporte.Location = new System.Drawing.Point(12, 46);
            this.grbNotaTransporte.Name = "grbNotaTransporte";
            this.grbNotaTransporte.Size = new System.Drawing.Size(843, 119);
            this.grbNotaTransporte.TabIndex = 75;
            this.grbNotaTransporte.TabStop = false;
            this.grbNotaTransporte.Text = "Gerar Nota";
            this.grbNotaTransporte.Enter += new System.EventHandler(this.grbNotaTransporte_Enter);
            // 
            // btnGerarNotaTransporte
            // 
            this.btnGerarNotaTransporte.Location = new System.Drawing.Point(236, 78);
            this.btnGerarNotaTransporte.Name = "btnGerarNotaTransporte";
            this.btnGerarNotaTransporte.Size = new System.Drawing.Size(238, 31);
            this.btnGerarNotaTransporte.TabIndex = 76;
            this.btnGerarNotaTransporte.Text = "Nova Nota Transporte";
            this.btnGerarNotaTransporte.UseVisualStyleBackColor = true;
            this.btnGerarNotaTransporte.Click += new System.EventHandler(this.btnGerarNotaTransporte_Click_1);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(630, 41);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(150, 20);
            this.txtDistancia.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Distância (KM)";
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(480, 41);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Size = new System.Drawing.Size(144, 20);
            this.txtValorFrete.TabIndex = 83;
            // 
            // cmbTiposFretes
            // 
            this.cmbTiposFretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposFretes.FormattingEnabled = true;
            this.cmbTiposFretes.Location = new System.Drawing.Point(12, 84);
            this.cmbTiposFretes.Name = "cmbTiposFretes";
            this.cmbTiposFretes.Size = new System.Drawing.Size(218, 21);
            this.cmbTiposFretes.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Valor Frete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Veiculos Disponiveis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Motoristas Disponiveis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tipos de Fretes";
            // 
            // cmbMotoristas
            // 
            this.cmbMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotoristas.FormattingEnabled = true;
            this.cmbMotoristas.Location = new System.Drawing.Point(12, 40);
            this.cmbMotoristas.Name = "cmbMotoristas";
            this.cmbMotoristas.Size = new System.Drawing.Size(218, 21);
            this.cmbMotoristas.TabIndex = 82;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(236, 40);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(238, 21);
            this.cmbVeiculos.TabIndex = 77;
            // 
            // cmbNotasGeradas
            // 
            this.cmbNotasGeradas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotasGeradas.FormattingEnabled = true;
            this.cmbNotasGeradas.Location = new System.Drawing.Point(693, 19);
            this.cmbNotasGeradas.Name = "cmbNotasGeradas";
            this.cmbNotasGeradas.Size = new System.Drawing.Size(162, 21);
            this.cmbNotasGeradas.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Notas Geradas Pedido";
            // 
            // FrmNotaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 632);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbNotasGeradas);
            this.Controls.Add(this.grbNotaTransporte);
            this.Controls.Add(this.txtIdNotaTransporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbItensNotaTransporte);
            this.Controls.Add(this.grbCargasPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNotaTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Nota Transporte";
            this.Load += new System.EventHandler(this.FrmNotaTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.grbCargasPedido.ResumeLayout(false);
            this.grbItensNotaTransporte.ResumeLayout(false);
            this.grbItensNotaTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasAdicionadas)).EndInit();
            this.grbNotaTransporte.ResumeLayout(false);
            this.grbNotaTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
        private System.Windows.Forms.GroupBox grbCargasPedido;
        private System.Windows.Forms.GroupBox grbItensNotaTransporte;
        private System.Windows.Forms.DataGridView dgvCargasAdicionadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdicionarCargasNota;
        private System.Windows.Forms.TextBox txtIdNotaTransporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbNotaTransporte;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGerarNotaTransporte;
        private System.Windows.Forms.TextBox txtValorFrete;
        private System.Windows.Forms.ComboBox cmbTiposFretes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMotoristas;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Button btnFinalizarNota;
        private System.Windows.Forms.Button btnRemoverItemSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cubagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoCubagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargaAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoAdicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CubagemAdicionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CubagemAssociada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAdicionado;
        private System.Windows.Forms.Button btnNotaTransporte;
        private System.Windows.Forms.ComboBox cmbNotasGeradas;
        private System.Windows.Forms.Label label9;
    }
}