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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoConsultar));
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpPedidos = new System.Windows.Forms.GroupBox();
            this.cmbEnderecoRemetente = new System.Windows.Forms.ComboBox();
            this.cmbEnderecoDestino = new System.Windows.Forms.ComboBox();
            this.btnListarCargasPedido = new System.Windows.Forms.Button();
            this.dgvPedidosCargas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.btnListarPedidos = new System.Windows.Forms.Button();
            this.mskDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.chkRetirar = new System.Windows.Forms.CheckBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            resources.ApplyResources(this.cmbClientes, "cmbClientes");
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // grpPedidos
            // 
            resources.ApplyResources(this.grpPedidos, "grpPedidos");
            this.grpPedidos.Controls.Add(this.btnAlterarPedido);
            this.grpPedidos.Controls.Add(this.cmbEnderecoRemetente);
            this.grpPedidos.Controls.Add(this.cmbEnderecoDestino);
            this.grpPedidos.Controls.Add(this.btnListarCargasPedido);
            this.grpPedidos.Controls.Add(this.dgvPedidosCargas);
            this.grpPedidos.Controls.Add(this.label6);
            this.grpPedidos.Controls.Add(this.label5);
            this.grpPedidos.Controls.Add(this.cmbPedidos);
            this.grpPedidos.Controls.Add(this.btnListarPedidos);
            this.grpPedidos.Controls.Add(this.mskDataPedido);
            this.grpPedidos.Controls.Add(this.cmbUsuario);
            this.grpPedidos.Controls.Add(this.chkRetirar);
            this.grpPedidos.Controls.Add(this.cmbSituacao);
            this.grpPedidos.Controls.Add(this.label4);
            this.grpPedidos.Controls.Add(this.label3);
            this.grpPedidos.Controls.Add(this.label2);
            this.grpPedidos.Controls.Add(this.label1);
            this.grpPedidos.Name = "grpPedidos";
            this.grpPedidos.TabStop = false;
            // 
            // cmbEnderecoRemetente
            // 
            resources.ApplyResources(this.cmbEnderecoRemetente, "cmbEnderecoRemetente");
            this.cmbEnderecoRemetente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnderecoRemetente.FormattingEnabled = true;
            this.cmbEnderecoRemetente.Name = "cmbEnderecoRemetente";
            // 
            // cmbEnderecoDestino
            // 
            resources.ApplyResources(this.cmbEnderecoDestino, "cmbEnderecoDestino");
            this.cmbEnderecoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnderecoDestino.FormattingEnabled = true;
            this.cmbEnderecoDestino.Name = "cmbEnderecoDestino";
            // 
            // btnListarCargasPedido
            // 
            resources.ApplyResources(this.btnListarCargasPedido, "btnListarCargasPedido");
            this.btnListarCargasPedido.Name = "btnListarCargasPedido";
            this.btnListarCargasPedido.UseVisualStyleBackColor = true;
            // 
            // dgvPedidosCargas
            // 
            resources.ApplyResources(this.dgvPedidosCargas, "dgvPedidosCargas");
            this.dgvPedidosCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosCargas.Name = "dgvPedidosCargas";
            this.dgvPedidosCargas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidosCargas.RowHeadersVisible = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cmbPedidos
            // 
            resources.ApplyResources(this.cmbPedidos, "cmbPedidos");
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Name = "cmbPedidos";
            // 
            // btnListarPedidos
            // 
            resources.ApplyResources(this.btnListarPedidos, "btnListarPedidos");
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.UseVisualStyleBackColor = true;
            // 
            // mskDataPedido
            // 
            resources.ApplyResources(this.mskDataPedido, "mskDataPedido");
            this.mskDataPedido.Name = "mskDataPedido";
            this.mskDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // cmbUsuario
            // 
            resources.ApplyResources(this.cmbUsuario, "cmbUsuario");
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Name = "cmbUsuario";
            // 
            // chkRetirar
            // 
            resources.ApplyResources(this.chkRetirar, "chkRetirar");
            this.chkRetirar.Name = "chkRetirar";
            this.chkRetirar.UseVisualStyleBackColor = true;
            // 
            // cmbSituacao
            // 
            resources.ApplyResources(this.cmbSituacao, "cmbSituacao");
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Name = "cmbSituacao";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAlterarPedido
            // 
            resources.ApplyResources(this.btnAlterarPedido, "btnAlterarPedido");
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoConsultar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPedidos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label9);
            this.Name = "FrmPedidoConsultar";
            this.Load += new System.EventHandler(this.FrmConsultarPedido_Load);
            this.grpPedidos.ResumeLayout(false);
            this.grpPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.ComboBox cmbEnderecoRemetente;
        private System.Windows.Forms.ComboBox cmbEnderecoDestino;
        private System.Windows.Forms.Button btnListarCargasPedido;
        private System.Windows.Forms.DataGridView dgvPedidosCargas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.Button btnListarPedidos;
        private System.Windows.Forms.MaskedTextBox mskDataPedido;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.CheckBox chkRetirar;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}