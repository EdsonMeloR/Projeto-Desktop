namespace Projeto_Desktop.Formularios
{
    partial class FrmAssociarPlano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociarPlano));
            this.cmbPlanos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.grpPlano = new System.Windows.Forms.GroupBox();
            this.txtLimitePedidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoPlano = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorPlano = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuracaoPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssociarPlano = new System.Windows.Forms.Button();
            this.btnCriarPlanoPeronalizado = new System.Windows.Forms.Button();
            this.btnAlterarPlanoCliente = new System.Windows.Forms.Button();
            this.btnConsultarPlano = new System.Windows.Forms.Button();
            this.grbAssociarPlanoCliente = new System.Windows.Forms.GroupBox();
            this.mskDataTerminoPlano = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskDataInicioPlano = new System.Windows.Forms.MaskedTextBox();
            this.txtDescontoPlano = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpPlano.SuspendLayout();
            this.grbAssociarPlanoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPlanos
            // 
            this.cmbPlanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanos.FormattingEnabled = true;
            this.cmbPlanos.Location = new System.Drawing.Point(18, 31);
            this.cmbPlanos.Name = "cmbPlanos";
            this.cmbPlanos.Size = new System.Drawing.Size(197, 21);
            this.cmbPlanos.TabIndex = 2;
            this.cmbPlanos.SelectedIndexChanged += new System.EventHandler(this.cmbPlanos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Planos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clientes";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(6, 35);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(212, 21);
            this.cmbClientes.TabIndex = 4;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // grpPlano
            // 
            this.grpPlano.Controls.Add(this.txtLimitePedidos);
            this.grpPlano.Controls.Add(this.label8);
            this.grpPlano.Controls.Add(this.txtDescricaoPlano);
            this.grpPlano.Controls.Add(this.label7);
            this.grpPlano.Controls.Add(this.txtValorPlano);
            this.grpPlano.Controls.Add(this.label6);
            this.grpPlano.Controls.Add(this.txtDuracaoPlano);
            this.grpPlano.Controls.Add(this.label5);
            this.grpPlano.Controls.Add(this.txtNomePlano);
            this.grpPlano.Controls.Add(this.label4);
            this.grpPlano.Location = new System.Drawing.Point(12, 58);
            this.grpPlano.Name = "grpPlano";
            this.grpPlano.Size = new System.Drawing.Size(645, 198);
            this.grpPlano.TabIndex = 6;
            this.grpPlano.TabStop = false;
            this.grpPlano.Text = "Plano";
            // 
            // txtLimitePedidos
            // 
            this.txtLimitePedidos.Enabled = false;
            this.txtLimitePedidos.Location = new System.Drawing.Point(550, 36);
            this.txtLimitePedidos.Name = "txtLimitePedidos";
            this.txtLimitePedidos.Size = new System.Drawing.Size(89, 20);
            this.txtLimitePedidos.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Limite Pedidos";
            // 
            // txtDescricaoPlano
            // 
            this.txtDescricaoPlano.Enabled = false;
            this.txtDescricaoPlano.Location = new System.Drawing.Point(6, 83);
            this.txtDescricaoPlano.Multiline = true;
            this.txtDescricaoPlano.Name = "txtDescricaoPlano";
            this.txtDescricaoPlano.Size = new System.Drawing.Size(633, 109);
            this.txtDescricaoPlano.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descrição Plano";
            // 
            // txtValorPlano
            // 
            this.txtValorPlano.Enabled = false;
            this.txtValorPlano.Location = new System.Drawing.Point(418, 36);
            this.txtValorPlano.Name = "txtValorPlano";
            this.txtValorPlano.Size = new System.Drawing.Size(126, 20);
            this.txtValorPlano.TabIndex = 7;
            this.txtValorPlano.TextChanged += new System.EventHandler(this.txtValorPlano_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor Plano";
            // 
            // txtDuracaoPlano
            // 
            this.txtDuracaoPlano.Enabled = false;
            this.txtDuracaoPlano.Location = new System.Drawing.Point(209, 36);
            this.txtDuracaoPlano.Name = "txtDuracaoPlano";
            this.txtDuracaoPlano.Size = new System.Drawing.Size(203, 20);
            this.txtDuracaoPlano.TabIndex = 5;
            this.txtDuracaoPlano.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração Plano";
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Enabled = false;
            this.txtNomePlano.Location = new System.Drawing.Point(6, 36);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.Size = new System.Drawing.Size(197, 20);
            this.txtNomePlano.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Plano";
            // 
            // btnAssociarPlano
            // 
            this.btnAssociarPlano.Location = new System.Drawing.Point(18, 397);
            this.btnAssociarPlano.Name = "btnAssociarPlano";
            this.btnAssociarPlano.Size = new System.Drawing.Size(144, 23);
            this.btnAssociarPlano.TabIndex = 7;
            this.btnAssociarPlano.Text = "Associar Plano";
            this.btnAssociarPlano.UseVisualStyleBackColor = true;
            this.btnAssociarPlano.Click += new System.EventHandler(this.btnAssociarPlano_Click);
            // 
            // btnCriarPlanoPeronalizado
            // 
            this.btnCriarPlanoPeronalizado.Location = new System.Drawing.Point(318, 397);
            this.btnCriarPlanoPeronalizado.Name = "btnCriarPlanoPeronalizado";
            this.btnCriarPlanoPeronalizado.Size = new System.Drawing.Size(144, 23);
            this.btnCriarPlanoPeronalizado.TabIndex = 8;
            this.btnCriarPlanoPeronalizado.Text = "Criar Plano Personalizado";
            this.btnCriarPlanoPeronalizado.UseVisualStyleBackColor = true;
            this.btnCriarPlanoPeronalizado.Click += new System.EventHandler(this.btnCriarPlanoPeronalizado_Click);
            // 
            // btnAlterarPlanoCliente
            // 
            this.btnAlterarPlanoCliente.Location = new System.Drawing.Point(168, 397);
            this.btnAlterarPlanoCliente.Name = "btnAlterarPlanoCliente";
            this.btnAlterarPlanoCliente.Size = new System.Drawing.Size(144, 23);
            this.btnAlterarPlanoCliente.TabIndex = 9;
            this.btnAlterarPlanoCliente.Text = "Alterar Plano";
            this.btnAlterarPlanoCliente.UseVisualStyleBackColor = true;
            this.btnAlterarPlanoCliente.Click += new System.EventHandler(this.btnAlterarPlanoCliente_Click);
            // 
            // btnConsultarPlano
            // 
            this.btnConsultarPlano.Location = new System.Drawing.Point(224, 35);
            this.btnConsultarPlano.Name = "btnConsultarPlano";
            this.btnConsultarPlano.Size = new System.Drawing.Size(126, 23);
            this.btnConsultarPlano.TabIndex = 10;
            this.btnConsultarPlano.Text = "Consultar Plano Cliente";
            this.btnConsultarPlano.UseVisualStyleBackColor = true;
            this.btnConsultarPlano.Click += new System.EventHandler(this.btnConsultarPlano_Click);
            // 
            // grbAssociarPlanoCliente
            // 
            this.grbAssociarPlanoCliente.Controls.Add(this.mskDataTerminoPlano);
            this.grbAssociarPlanoCliente.Controls.Add(this.btnConsultarPlano);
            this.grbAssociarPlanoCliente.Controls.Add(this.label9);
            this.grbAssociarPlanoCliente.Controls.Add(this.mskDataInicioPlano);
            this.grbAssociarPlanoCliente.Controls.Add(this.txtDescontoPlano);
            this.grbAssociarPlanoCliente.Controls.Add(this.label10);
            this.grbAssociarPlanoCliente.Controls.Add(this.label12);
            this.grbAssociarPlanoCliente.Controls.Add(this.label3);
            this.grbAssociarPlanoCliente.Controls.Add(this.cmbClientes);
            this.grbAssociarPlanoCliente.Location = new System.Drawing.Point(12, 262);
            this.grbAssociarPlanoCliente.Name = "grbAssociarPlanoCliente";
            this.grbAssociarPlanoCliente.Size = new System.Drawing.Size(645, 129);
            this.grbAssociarPlanoCliente.TabIndex = 12;
            this.grbAssociarPlanoCliente.TabStop = false;
            this.grbAssociarPlanoCliente.Text = "Plano Cliente";
            // 
            // mskDataTerminoPlano
            // 
            this.mskDataTerminoPlano.Enabled = false;
            this.mskDataTerminoPlano.Location = new System.Drawing.Point(115, 103);
            this.mskDataTerminoPlano.Mask = "00/00/0000 90:00";
            this.mskDataTerminoPlano.Name = "mskDataTerminoPlano";
            this.mskDataTerminoPlano.Size = new System.Drawing.Size(103, 20);
            this.mskDataTerminoPlano.TabIndex = 15;
            this.mskDataTerminoPlano.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data Termino";
            // 
            // mskDataInicioPlano
            // 
            this.mskDataInicioPlano.Location = new System.Drawing.Point(6, 103);
            this.mskDataInicioPlano.Mask = "00/00/0000 90:00";
            this.mskDataInicioPlano.Name = "mskDataInicioPlano";
            this.mskDataInicioPlano.Size = new System.Drawing.Size(103, 20);
            this.mskDataInicioPlano.TabIndex = 13;
            this.mskDataInicioPlano.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescontoPlano
            // 
            this.txtDescontoPlano.Location = new System.Drawing.Point(224, 103);
            this.txtDescontoPlano.Name = "txtDescontoPlano";
            this.txtDescontoPlano.Size = new System.Drawing.Size(126, 20);
            this.txtDescontoPlano.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Desconto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Data Inicio";
            // 
            // FrmAssociarPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 482);
            this.Controls.Add(this.grbAssociarPlanoCliente);
            this.Controls.Add(this.btnAlterarPlanoCliente);
            this.Controls.Add(this.btnCriarPlanoPeronalizado);
            this.Controls.Add(this.btnAssociarPlano);
            this.Controls.Add(this.grpPlano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlanos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssociarPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Plano ao Cliente";
            this.Load += new System.EventHandler(this.FrmAssociarPlano_Load);
            this.grpPlano.ResumeLayout(false);
            this.grpPlano.PerformLayout();
            this.grbAssociarPlanoCliente.ResumeLayout(false);
            this.grbAssociarPlanoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPlanos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.GroupBox grpPlano;
        private System.Windows.Forms.TextBox txtDescricaoPlano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorPlano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuracaoPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLimitePedidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAssociarPlano;
        private System.Windows.Forms.Button btnCriarPlanoPeronalizado;
        private System.Windows.Forms.Button btnAlterarPlanoCliente;
        private System.Windows.Forms.Button btnConsultarPlano;
        private System.Windows.Forms.GroupBox grbAssociarPlanoCliente;
        private System.Windows.Forms.TextBox txtDescontoPlano;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskDataInicioPlano;
        private System.Windows.Forms.MaskedTextBox mskDataTerminoPlano;
        private System.Windows.Forms.Label label9;
    }
}