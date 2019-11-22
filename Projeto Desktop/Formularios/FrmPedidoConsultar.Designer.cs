namespace Projeto_Desktop.Formularios
{
    partial class FrmPedidoConsultar
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
            this.btnListarPedidos = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.chkRetirar = new System.Windows.Forms.CheckBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.txtEnderecoRemetente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPedidosCargas = new System.Windows.Forms.DataGridView();
            this.txtEnderecoDestino = new System.Windows.Forms.TextBox();
            this.btnListarCargasPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarPedidos
            // 
            this.btnListarPedidos.Enabled = false;
            this.btnListarPedidos.Location = new System.Drawing.Point(12, 155);
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.Size = new System.Drawing.Size(129, 23);
            this.btnListarPedidos.TabIndex = 47;
            this.btnListarPedidos.Text = "Listar Pedidos";
            this.btnListarPedidos.UseVisualStyleBackColor = true;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(14, 28);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(280, 21);
            this.cmbClientes.TabIndex = 45;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Clientes";
            // 
            // mskDataPedido
            // 
            this.mskDataPedido.Enabled = false;
            this.mskDataPedido.Location = new System.Drawing.Point(300, 78);
            this.mskDataPedido.Mask = "00/00/0000   00:00";
            this.mskDataPedido.Name = "mskDataPedido";
            this.mskDataPedido.Size = new System.Drawing.Size(172, 20);
            this.mskDataPedido.TabIndex = 42;
            this.mskDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(478, 77);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(172, 21);
            this.cmbUsuario.TabIndex = 41;
            // 
            // chkRetirar
            // 
            this.chkRetirar.AutoSize = true;
            this.chkRetirar.Enabled = false;
            this.chkRetirar.Location = new System.Drawing.Point(656, 79);
            this.chkRetirar.Name = "chkRetirar";
            this.chkRetirar.Size = new System.Drawing.Size(57, 17);
            this.chkRetirar.TabIndex = 40;
            this.chkRetirar.Text = "Retirar";
            this.chkRetirar.UseVisualStyleBackColor = true;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.Enabled = false;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(157, 77);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(137, 21);
            this.cmbSituacao.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Situação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id Pedido";
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(14, 77);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(137, 21);
            this.cmbPedidos.TabIndex = 48;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // txtEnderecoRemetente
            // 
            this.txtEnderecoRemetente.Location = new System.Drawing.Point(14, 129);
            this.txtEnderecoRemetente.Name = "txtEnderecoRemetente";
            this.txtEnderecoRemetente.Size = new System.Drawing.Size(375, 20);
            this.txtEnderecoRemetente.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Endereço Remetente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Endereço Destino";
            // 
            // dgvPedidosCargas
            // 
            this.dgvPedidosCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosCargas.Location = new System.Drawing.Point(12, 184);
            this.dgvPedidosCargas.Name = "dgvPedidosCargas";
            this.dgvPedidosCargas.Size = new System.Drawing.Size(776, 202);
            this.dgvPedidosCargas.TabIndex = 53;
            // 
            // txtEnderecoDestino
            // 
            this.txtEnderecoDestino.Location = new System.Drawing.Point(395, 129);
            this.txtEnderecoDestino.Name = "txtEnderecoDestino";
            this.txtEnderecoDestino.Size = new System.Drawing.Size(375, 20);
            this.txtEnderecoDestino.TabIndex = 54;
            // 
            // btnListarCargasPedido
            // 
            this.btnListarCargasPedido.Enabled = false;
            this.btnListarCargasPedido.Location = new System.Drawing.Point(12, 397);
            this.btnListarCargasPedido.Name = "btnListarCargasPedido";
            this.btnListarCargasPedido.Size = new System.Drawing.Size(129, 23);
            this.btnListarCargasPedido.TabIndex = 55;
            this.btnListarCargasPedido.Text = "Listar Cargas";
            this.btnListarCargasPedido.UseVisualStyleBackColor = true;
            this.btnListarCargasPedido.Click += new System.EventHandler(this.btnListarCargasPedido_Click);
            // 
            // FrmPedidoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.btnListarCargasPedido);
            this.Controls.Add(this.txtEnderecoDestino);
            this.Controls.Add(this.dgvPedidosCargas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderecoRemetente);
            this.Controls.Add(this.cmbPedidos);
            this.Controls.Add(this.btnListarPedidos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskDataPedido);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.chkRetirar);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidoConsultar";
            this.Text = "Consultar Pedidos";
            this.Load += new System.EventHandler(this.FrmConsultarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPedidos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskDataPedido;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.CheckBox chkRetirar;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.TextBox txtEnderecoRemetente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPedidosCargas;
        private System.Windows.Forms.TextBox txtEnderecoDestino;
        private System.Windows.Forms.Button btnListarCargasPedido;
    }
}