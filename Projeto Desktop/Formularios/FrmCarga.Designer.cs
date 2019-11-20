namespace Projeto_Desktop.Formularios
{
    partial class FrmCarga
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
            this.txtIdCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirCarga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.grbCarga = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.cmbTiposCargas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultarCargas = new System.Windows.Forms.Button();
            this.btnAlterarCarga = new System.Windows.Forms.Button();
            this.grbCarga.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCarga
            // 
            this.txtIdCarga.Enabled = false;
            this.txtIdCarga.Location = new System.Drawing.Point(9, 46);
            this.txtIdCarga.Name = "txtIdCarga";
            this.txtIdCarga.Size = new System.Drawing.Size(135, 20);
            this.txtIdCarga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Carga";
            // 
            // btnInserirCarga
            // 
            this.btnInserirCarga.Location = new System.Drawing.Point(185, 201);
            this.btnInserirCarga.Name = "btnInserirCarga";
            this.btnInserirCarga.Size = new System.Drawing.Size(104, 23);
            this.btnInserirCarga.TabIndex = 2;
            this.btnInserirCarga.Text = "Inserir Carga";
            this.btnInserirCarga.UseVisualStyleBackColor = true;
            this.btnInserirCarga.Click += new System.EventHandler(this.btnInserirCarga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Pedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(6, 32);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Largura";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(9, 162);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(135, 20);
            this.txtLargura.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(9, 122);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(135, 20);
            this.txtAltura.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comprimento";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(9, 204);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(135, 20);
            this.txtComprimento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detalhes Produto";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Enabled = false;
            this.txtDetalhes.Location = new System.Drawing.Point(185, 85);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(276, 57);
            this.txtDetalhes.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(9, 85);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(135, 20);
            this.txtPeso.TabIndex = 17;
            // 
            // grbCarga
            // 
            this.grbCarga.Controls.Add(this.btnAlterarCarga);
            this.grbCarga.Controls.Add(this.btnConsultarCargas);
            this.grbCarga.Controls.Add(this.label3);
            this.grbCarga.Controls.Add(this.cmbTiposCargas);
            this.grbCarga.Controls.Add(this.label10);
            this.grbCarga.Controls.Add(this.txtValorProduto);
            this.grbCarga.Controls.Add(this.btnInserirCarga);
            this.grbCarga.Controls.Add(this.label1);
            this.grbCarga.Controls.Add(this.label8);
            this.grbCarga.Controls.Add(this.label9);
            this.grbCarga.Controls.Add(this.txtDetalhes);
            this.grbCarga.Controls.Add(this.txtIdCarga);
            this.grbCarga.Controls.Add(this.txtPeso);
            this.grbCarga.Controls.Add(this.txtLargura);
            this.grbCarga.Controls.Add(this.label5);
            this.grbCarga.Controls.Add(this.txtAltura);
            this.grbCarga.Controls.Add(this.label7);
            this.grbCarga.Controls.Add(this.label6);
            this.grbCarga.Controls.Add(this.txtComprimento);
            this.grbCarga.Location = new System.Drawing.Point(12, 12);
            this.grbCarga.Name = "grbCarga";
            this.grbCarga.Size = new System.Drawing.Size(561, 242);
            this.grbCarga.TabIndex = 19;
            this.grbCarga.TabStop = false;
            this.grbCarga.Text = "Inserir Cargas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ValorProduto";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(185, 162);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(135, 20);
            this.txtValorProduto.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCargasPedido);
            this.groupBox2.Controls.Add(this.txtIdPedido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 264);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargas Pedidos";
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 58);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.Size = new System.Drawing.Size(549, 200);
            this.dgvCargasPedido.TabIndex = 5;
            this.dgvCargasPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargasPedido_CellContentClick);
            // 
            // cmbTiposCargas
            // 
            this.cmbTiposCargas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposCargas.FormattingEnabled = true;
            this.cmbTiposCargas.Location = new System.Drawing.Point(185, 46);
            this.cmbTiposCargas.Name = "cmbTiposCargas";
            this.cmbTiposCargas.Size = new System.Drawing.Size(135, 21);
            this.cmbTiposCargas.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipos de Cargas";
            // 
            // btnConsultarCargas
            // 
            this.btnConsultarCargas.Location = new System.Drawing.Point(295, 201);
            this.btnConsultarCargas.Name = "btnConsultarCargas";
            this.btnConsultarCargas.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarCargas.TabIndex = 23;
            this.btnConsultarCargas.Text = "Consultar Carga";
            this.btnConsultarCargas.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCarga
            // 
            this.btnAlterarCarga.Location = new System.Drawing.Point(405, 201);
            this.btnAlterarCarga.Name = "btnAlterarCarga";
            this.btnAlterarCarga.Size = new System.Drawing.Size(104, 23);
            this.btnAlterarCarga.TabIndex = 24;
            this.btnAlterarCarga.Text = "Alterar Carga";
            this.btnAlterarCarga.UseVisualStyleBackColor = true;
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCarga);
            this.Name = "FrmCarga";
            this.Text = "FrmCarga";
            this.Load += new System.EventHandler(this.FrmCarga_Load);
            this.grbCarga.ResumeLayout(false);
            this.grbCarga.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirCarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.GroupBox grbCarga;
        private System.Windows.Forms.Button btnAlterarCarga;
        private System.Windows.Forms.Button btnConsultarCargas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposCargas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
    }
}