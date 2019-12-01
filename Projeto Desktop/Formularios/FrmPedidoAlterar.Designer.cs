namespace Projeto_Desktop.Formularios
{
    partial class FrmPedidoAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoAlterar));
            this.cmbDataPedido = new System.Windows.Forms.ComboBox();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.cmbEnderecoRemetente = new System.Windows.Forms.ComboBox();
            this.cmbEnderecoDestino = new System.Windows.Forms.ComboBox();
            this.btnListarCargasPedido = new System.Windows.Forms.Button();
            this.dgvPedidosCargas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.btnListarPedidos = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.chkRetirar = new System.Windows.Forms.CheckBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPedidos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).BeginInit();
            this.grpPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDataPedido
            // 
            this.cmbDataPedido.Enabled = false;
            this.cmbDataPedido.FormattingEnabled = true;
            this.cmbDataPedido.Location = new System.Drawing.Point(304, 36);
            this.cmbDataPedido.Name = "cmbDataPedido";
            this.cmbDataPedido.Size = new System.Drawing.Size(158, 21);
            this.cmbDataPedido.TabIndex = 76;
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarPedido.Location = new System.Drawing.Point(6, 359);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(115, 26);
            this.btnAlterarPedido.TabIndex = 75;
            this.btnAlterarPedido.Text = "Alterar Pedido";
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // cmbEnderecoRemetente
            // 
            this.cmbEnderecoRemetente.Enabled = false;
            this.cmbEnderecoRemetente.FormattingEnabled = true;
            this.cmbEnderecoRemetente.Location = new System.Drawing.Point(8, 88);
            this.cmbEnderecoRemetente.Name = "cmbEnderecoRemetente";
            this.cmbEnderecoRemetente.Size = new System.Drawing.Size(374, 21);
            this.cmbEnderecoRemetente.TabIndex = 74;
            // 
            // cmbEnderecoDestino
            // 
            this.cmbEnderecoDestino.Enabled = false;
            this.cmbEnderecoDestino.FormattingEnabled = true;
            this.cmbEnderecoDestino.Location = new System.Drawing.Point(389, 88);
            this.cmbEnderecoDestino.Name = "cmbEnderecoDestino";
            this.cmbEnderecoDestino.Size = new System.Drawing.Size(379, 21);
            this.cmbEnderecoDestino.TabIndex = 73;
            // 
            // btnListarCargasPedido
            // 
            this.btnListarCargasPedido.Enabled = false;
            this.btnListarCargasPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListarCargasPedido.Location = new System.Drawing.Point(141, 115);
            this.btnListarCargasPedido.Name = "btnListarCargasPedido";
            this.btnListarCargasPedido.Size = new System.Drawing.Size(115, 23);
            this.btnListarCargasPedido.TabIndex = 72;
            this.btnListarCargasPedido.Text = "Listar Cargas";
            this.btnListarCargasPedido.UseVisualStyleBackColor = true;
            this.btnListarCargasPedido.Click += new System.EventHandler(this.btnListarCargasPedido_Click);
            // 
            // dgvPedidosCargas
            // 
            this.dgvPedidosCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosCargas.Location = new System.Drawing.Point(6, 144);
            this.dgvPedidosCargas.Name = "dgvPedidosCargas";
            this.dgvPedidosCargas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidosCargas.RowHeadersVisible = false;
            this.dgvPedidosCargas.Size = new System.Drawing.Size(762, 209);
            this.dgvPedidosCargas.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(386, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Endereço Destino";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(21, 24);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(280, 21);
            this.cmbClientes.TabIndex = 61;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(18, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Endereço Remetente";
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(8, 36);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(137, 21);
            this.cmbPedidos.TabIndex = 68;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged_2);
            // 
            // btnListarPedidos
            // 
            this.btnListarPedidos.Enabled = false;
            this.btnListarPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListarPedidos.Location = new System.Drawing.Point(6, 115);
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.Size = new System.Drawing.Size(115, 23);
            this.btnListarPedidos.TabIndex = 67;
            this.btnListarPedidos.Text = "Listar Pedidos";
            this.btnListarPedidos.UseVisualStyleBackColor = true;
            this.btnListarPedidos.Click += new System.EventHandler(this.btnListarPedidos_Click_1);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(468, 36);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(158, 21);
            this.cmbUsuario.TabIndex = 65;
            // 
            // chkRetirar
            // 
            this.chkRetirar.AutoSize = true;
            this.chkRetirar.Enabled = false;
            this.chkRetirar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRetirar.Location = new System.Drawing.Point(632, 38);
            this.chkRetirar.Name = "chkRetirar";
            this.chkRetirar.Size = new System.Drawing.Size(57, 17);
            this.chkRetirar.TabIndex = 64;
            this.chkRetirar.Text = "Retirar";
            this.chkRetirar.UseVisualStyleBackColor = true;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Aberto",
            "Em Progresso",
            "Finalizado"});
            this.cmbSituacao.Location = new System.Drawing.Point(151, 36);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(147, 21);
            this.cmbSituacao.TabIndex = 63;
            this.cmbSituacao.SelectedIndexChanged += new System.EventHandler(this.cmbSituacao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(465, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(301, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Data Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Situação";
            // 
            // grpPedidos
            // 
            this.grpPedidos.Controls.Add(this.cmbDataPedido);
            this.grpPedidos.Controls.Add(this.btnAlterarPedido);
            this.grpPedidos.Controls.Add(this.cmbEnderecoRemetente);
            this.grpPedidos.Controls.Add(this.cmbEnderecoDestino);
            this.grpPedidos.Controls.Add(this.btnListarCargasPedido);
            this.grpPedidos.Controls.Add(this.dgvPedidosCargas);
            this.grpPedidos.Controls.Add(this.label6);
            this.grpPedidos.Controls.Add(this.label5);
            this.grpPedidos.Controls.Add(this.cmbPedidos);
            this.grpPedidos.Controls.Add(this.btnListarPedidos);
            this.grpPedidos.Controls.Add(this.cmbUsuario);
            this.grpPedidos.Controls.Add(this.chkRetirar);
            this.grpPedidos.Controls.Add(this.cmbSituacao);
            this.grpPedidos.Controls.Add(this.label4);
            this.grpPedidos.Controls.Add(this.label3);
            this.grpPedidos.Controls.Add(this.label2);
            this.grpPedidos.Controls.Add(this.label1);
            this.grpPedidos.Enabled = false;
            this.grpPedidos.Location = new System.Drawing.Point(13, 53);
            this.grpPedidos.Name = "grpPedidos";
            this.grpPedidos.Size = new System.Drawing.Size(774, 391);
            this.grpPedidos.TabIndex = 62;
            this.grpPedidos.TabStop = false;
            this.grpPedidos.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID Pedido";
            // 
            // FrmPedidoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidoAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Pedido";
            this.Load += new System.EventHandler(this.FrmPedidoAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).EndInit();
            this.grpPedidos.ResumeLayout(false);
            this.grpPedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataPedido;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.ComboBox cmbEnderecoRemetente;
        private System.Windows.Forms.ComboBox cmbEnderecoDestino;
        private System.Windows.Forms.Button btnListarCargasPedido;
        private System.Windows.Forms.DataGridView dgvPedidosCargas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.Button btnListarPedidos;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.CheckBox chkRetirar;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.Label label1;
    }
}