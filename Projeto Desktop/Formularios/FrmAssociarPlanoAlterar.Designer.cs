namespace Projeto_Desktop.Formularios
{
    partial class FrmAssociarPlanoAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociarPlanoAlterar));
            this.btnConsultarPlano = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.grpAtualizarPlano = new System.Windows.Forms.GroupBox();
            this.txtIdPlanoClienteAssociado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAtualizarPlano = new System.Windows.Forms.Button();
            this.mskDataTerminoPlano = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mskDataInicioPlano = new System.Windows.Forms.MaskedTextBox();
            this.txtDescontoPlano = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.grpAlterarPlano = new System.Windows.Forms.GroupBox();
            this.mskDataTerminoAtualizar = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mskDataInicioAtualizar = new System.Windows.Forms.MaskedTextBox();
            this.txtDescontoAtualizar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAlterarPlanoAssociado = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPlanosAtualizar = new System.Windows.Forms.ComboBox();
            this.txtLimitePedidoAlterar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoPlanoAtualizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPlanoAlterar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuracaoPlanoAlterar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeAtualizar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAssociarPlano = new System.Windows.Forms.Button();
            this.grpAtualizarPlano.SuspendLayout();
            this.grpAlterarPlano.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarPlano
            // 
            this.btnConsultarPlano.Enabled = false;
            this.btnConsultarPlano.Location = new System.Drawing.Point(230, 25);
            this.btnConsultarPlano.Name = "btnConsultarPlano";
            this.btnConsultarPlano.Size = new System.Drawing.Size(126, 23);
            this.btnConsultarPlano.TabIndex = 10;
            this.btnConsultarPlano.Text = "Consultar Plano Cliente";
            this.btnConsultarPlano.UseVisualStyleBackColor = true;
            this.btnConsultarPlano.Click += new System.EventHandler(this.btnConsultarPlano_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clientes";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(12, 26);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(212, 21);
            this.cmbClientes.TabIndex = 4;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // grpAtualizarPlano
            // 
            this.grpAtualizarPlano.Controls.Add(this.txtIdPlanoClienteAssociado);
            this.grpAtualizarPlano.Controls.Add(this.label19);
            this.grpAtualizarPlano.Controls.Add(this.btnAtualizarPlano);
            this.grpAtualizarPlano.Controls.Add(this.mskDataTerminoPlano);
            this.grpAtualizarPlano.Controls.Add(this.label13);
            this.grpAtualizarPlano.Controls.Add(this.mskDataInicioPlano);
            this.grpAtualizarPlano.Controls.Add(this.txtDescontoPlano);
            this.grpAtualizarPlano.Controls.Add(this.label14);
            this.grpAtualizarPlano.Controls.Add(this.label15);
            this.grpAtualizarPlano.Controls.Add(this.txtLimitePedidos);
            this.grpAtualizarPlano.Controls.Add(this.label8);
            this.grpAtualizarPlano.Controls.Add(this.txtDescricaoPlano);
            this.grpAtualizarPlano.Controls.Add(this.label7);
            this.grpAtualizarPlano.Controls.Add(this.txtValorPlano);
            this.grpAtualizarPlano.Controls.Add(this.label6);
            this.grpAtualizarPlano.Controls.Add(this.txtDuracaoPlano);
            this.grpAtualizarPlano.Controls.Add(this.label5);
            this.grpAtualizarPlano.Controls.Add(this.txtNomePlano);
            this.grpAtualizarPlano.Controls.Add(this.label4);
            this.grpAtualizarPlano.Enabled = false;
            this.grpAtualizarPlano.Location = new System.Drawing.Point(12, 54);
            this.grpAtualizarPlano.Name = "grpAtualizarPlano";
            this.grpAtualizarPlano.Size = new System.Drawing.Size(651, 281);
            this.grpAtualizarPlano.TabIndex = 14;
            this.grpAtualizarPlano.TabStop = false;
            this.grpAtualizarPlano.Text = "Plano Atual";
            // 
            // txtIdPlanoClienteAssociado
            // 
            this.txtIdPlanoClienteAssociado.Enabled = false;
            this.txtIdPlanoClienteAssociado.Location = new System.Drawing.Point(356, 76);
            this.txtIdPlanoClienteAssociado.Name = "txtIdPlanoClienteAssociado";
            this.txtIdPlanoClienteAssociado.Size = new System.Drawing.Size(130, 20);
            this.txtIdPlanoClienteAssociado.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(353, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Id Plano Associado Cliente";
            // 
            // btnAtualizarPlano
            // 
            this.btnAtualizarPlano.Enabled = false;
            this.btnAtualizarPlano.Location = new System.Drawing.Point(6, 247);
            this.btnAtualizarPlano.Name = "btnAtualizarPlano";
            this.btnAtualizarPlano.Size = new System.Drawing.Size(126, 23);
            this.btnAtualizarPlano.TabIndex = 22;
            this.btnAtualizarPlano.Text = "Atualizar Plano";
            this.btnAtualizarPlano.UseVisualStyleBackColor = true;
            this.btnAtualizarPlano.Click += new System.EventHandler(this.btnAtualizarPlano_Click);
            // 
            // mskDataTerminoPlano
            // 
            this.mskDataTerminoPlano.Enabled = false;
            this.mskDataTerminoPlano.Location = new System.Drawing.Point(115, 76);
            this.mskDataTerminoPlano.Mask = "00/00/0000 90:00";
            this.mskDataTerminoPlano.Name = "mskDataTerminoPlano";
            this.mskDataTerminoPlano.Size = new System.Drawing.Size(103, 20);
            this.mskDataTerminoPlano.TabIndex = 21;
            this.mskDataTerminoPlano.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Data Termino";
            // 
            // mskDataInicioPlano
            // 
            this.mskDataInicioPlano.Enabled = false;
            this.mskDataInicioPlano.Location = new System.Drawing.Point(6, 76);
            this.mskDataInicioPlano.Mask = "00/00/0000 90:00";
            this.mskDataInicioPlano.Name = "mskDataInicioPlano";
            this.mskDataInicioPlano.Size = new System.Drawing.Size(103, 20);
            this.mskDataInicioPlano.TabIndex = 19;
            this.mskDataInicioPlano.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescontoPlano
            // 
            this.txtDescontoPlano.Enabled = false;
            this.txtDescontoPlano.Location = new System.Drawing.Point(224, 76);
            this.txtDescontoPlano.Name = "txtDescontoPlano";
            this.txtDescontoPlano.Size = new System.Drawing.Size(126, 20);
            this.txtDescontoPlano.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Desconto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Data Inicio";
            // 
            // txtLimitePedidos
            // 
            this.txtLimitePedidos.Enabled = false;
            this.txtLimitePedidos.Location = new System.Drawing.Point(550, 36);
            this.txtLimitePedidos.Name = "txtLimitePedidos";
            this.txtLimitePedidos.Size = new System.Drawing.Size(95, 20);
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
            this.txtDescricaoPlano.Location = new System.Drawing.Point(6, 122);
            this.txtDescricaoPlano.Multiline = true;
            this.txtDescricaoPlano.Name = "txtDescricaoPlano";
            this.txtDescricaoPlano.Size = new System.Drawing.Size(639, 119);
            this.txtDescricaoPlano.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 106);
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
            // grpAlterarPlano
            // 
            this.grpAlterarPlano.Controls.Add(this.mskDataTerminoAtualizar);
            this.grpAlterarPlano.Controls.Add(this.label16);
            this.grpAlterarPlano.Controls.Add(this.mskDataInicioAtualizar);
            this.grpAlterarPlano.Controls.Add(this.txtDescontoAtualizar);
            this.grpAlterarPlano.Controls.Add(this.label17);
            this.grpAlterarPlano.Controls.Add(this.btnAlterarPlanoAssociado);
            this.grpAlterarPlano.Controls.Add(this.label18);
            this.grpAlterarPlano.Controls.Add(this.label12);
            this.grpAlterarPlano.Controls.Add(this.cmbPlanosAtualizar);
            this.grpAlterarPlano.Controls.Add(this.txtLimitePedidoAlterar);
            this.grpAlterarPlano.Controls.Add(this.label1);
            this.grpAlterarPlano.Controls.Add(this.txtDescricaoPlanoAtualizar);
            this.grpAlterarPlano.Controls.Add(this.label2);
            this.grpAlterarPlano.Controls.Add(this.txtValorPlanoAlterar);
            this.grpAlterarPlano.Controls.Add(this.label9);
            this.grpAlterarPlano.Controls.Add(this.txtDuracaoPlanoAlterar);
            this.grpAlterarPlano.Controls.Add(this.label10);
            this.grpAlterarPlano.Controls.Add(this.txtNomeAtualizar);
            this.grpAlterarPlano.Controls.Add(this.label11);
            this.grpAlterarPlano.Enabled = false;
            this.grpAlterarPlano.Location = new System.Drawing.Point(12, 341);
            this.grpAlterarPlano.Name = "grpAlterarPlano";
            this.grpAlterarPlano.Size = new System.Drawing.Size(651, 324);
            this.grpAlterarPlano.TabIndex = 15;
            this.grpAlterarPlano.TabStop = false;
            this.grpAlterarPlano.Text = "Alterar Plano";
            // 
            // mskDataTerminoAtualizar
            // 
            this.mskDataTerminoAtualizar.Enabled = false;
            this.mskDataTerminoAtualizar.Location = new System.Drawing.Point(115, 118);
            this.mskDataTerminoAtualizar.Mask = "00/00/0000 90:00";
            this.mskDataTerminoAtualizar.Name = "mskDataTerminoAtualizar";
            this.mskDataTerminoAtualizar.Size = new System.Drawing.Size(103, 20);
            this.mskDataTerminoAtualizar.TabIndex = 22;
            this.mskDataTerminoAtualizar.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(112, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Data Termino";
            // 
            // mskDataInicioAtualizar
            // 
            this.mskDataInicioAtualizar.Location = new System.Drawing.Point(6, 118);
            this.mskDataInicioAtualizar.Mask = "00/00/0000 90:00";
            this.mskDataInicioAtualizar.Name = "mskDataInicioAtualizar";
            this.mskDataInicioAtualizar.Size = new System.Drawing.Size(103, 20);
            this.mskDataInicioAtualizar.TabIndex = 20;
            this.mskDataInicioAtualizar.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescontoAtualizar
            // 
            this.txtDescontoAtualizar.Location = new System.Drawing.Point(224, 118);
            this.txtDescontoAtualizar.Name = "txtDescontoAtualizar";
            this.txtDescontoAtualizar.Size = new System.Drawing.Size(126, 20);
            this.txtDescontoAtualizar.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(221, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Desconto";
            // 
            // btnAlterarPlanoAssociado
            // 
            this.btnAlterarPlanoAssociado.Location = new System.Drawing.Point(6, 282);
            this.btnAlterarPlanoAssociado.Name = "btnAlterarPlanoAssociado";
            this.btnAlterarPlanoAssociado.Size = new System.Drawing.Size(126, 36);
            this.btnAlterarPlanoAssociado.TabIndex = 16;
            this.btnAlterarPlanoAssociado.Text = "Alterar Plano do Cliente";
            this.btnAlterarPlanoAssociado.UseVisualStyleBackColor = true;
            this.btnAlterarPlanoAssociado.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Data Inicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Planos";
            // 
            // cmbPlanosAtualizar
            // 
            this.cmbPlanosAtualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanosAtualizar.FormattingEnabled = true;
            this.cmbPlanosAtualizar.Location = new System.Drawing.Point(6, 35);
            this.cmbPlanosAtualizar.Name = "cmbPlanosAtualizar";
            this.cmbPlanosAtualizar.Size = new System.Drawing.Size(197, 21);
            this.cmbPlanosAtualizar.TabIndex = 12;
            this.cmbPlanosAtualizar.SelectedIndexChanged += new System.EventHandler(this.cmbPlanosAtualizar_SelectedIndexChanged);
            // 
            // txtLimitePedidoAlterar
            // 
            this.txtLimitePedidoAlterar.Enabled = false;
            this.txtLimitePedidoAlterar.Location = new System.Drawing.Point(550, 75);
            this.txtLimitePedidoAlterar.Name = "txtLimitePedidoAlterar";
            this.txtLimitePedidoAlterar.Size = new System.Drawing.Size(89, 20);
            this.txtLimitePedidoAlterar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Limite Pedidos";
            // 
            // txtDescricaoPlanoAtualizar
            // 
            this.txtDescricaoPlanoAtualizar.Enabled = false;
            this.txtDescricaoPlanoAtualizar.Location = new System.Drawing.Point(6, 161);
            this.txtDescricaoPlanoAtualizar.Multiline = true;
            this.txtDescricaoPlanoAtualizar.Name = "txtDescricaoPlanoAtualizar";
            this.txtDescricaoPlanoAtualizar.Size = new System.Drawing.Size(633, 115);
            this.txtDescricaoPlanoAtualizar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição Plano";
            // 
            // txtValorPlanoAlterar
            // 
            this.txtValorPlanoAlterar.Enabled = false;
            this.txtValorPlanoAlterar.Location = new System.Drawing.Point(418, 75);
            this.txtValorPlanoAlterar.Name = "txtValorPlanoAlterar";
            this.txtValorPlanoAlterar.Size = new System.Drawing.Size(126, 20);
            this.txtValorPlanoAlterar.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Valor Plano";
            // 
            // txtDuracaoPlanoAlterar
            // 
            this.txtDuracaoPlanoAlterar.Enabled = false;
            this.txtDuracaoPlanoAlterar.Location = new System.Drawing.Point(209, 75);
            this.txtDuracaoPlanoAlterar.Name = "txtDuracaoPlanoAlterar";
            this.txtDuracaoPlanoAlterar.Size = new System.Drawing.Size(203, 20);
            this.txtDuracaoPlanoAlterar.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Duração Plano";
            // 
            // txtNomeAtualizar
            // 
            this.txtNomeAtualizar.Enabled = false;
            this.txtNomeAtualizar.Location = new System.Drawing.Point(6, 75);
            this.txtNomeAtualizar.Name = "txtNomeAtualizar";
            this.txtNomeAtualizar.Size = new System.Drawing.Size(197, 20);
            this.txtNomeAtualizar.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome Plano";
            // 
            // btnAssociarPlano
            // 
            this.btnAssociarPlano.Enabled = false;
            this.btnAssociarPlano.Location = new System.Drawing.Point(362, 25);
            this.btnAssociarPlano.Name = "btnAssociarPlano";
            this.btnAssociarPlano.Size = new System.Drawing.Size(126, 23);
            this.btnAssociarPlano.TabIndex = 16;
            this.btnAssociarPlano.Text = "Associar Plano";
            this.btnAssociarPlano.UseVisualStyleBackColor = true;
            this.btnAssociarPlano.Click += new System.EventHandler(this.btnAssociarPlano_Click);
            // 
            // FrmAssociarPlanoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 677);
            this.Controls.Add(this.btnAssociarPlano);
            this.Controls.Add(this.grpAlterarPlano);
            this.Controls.Add(this.grpAtualizarPlano);
            this.Controls.Add(this.btnConsultarPlano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssociarPlanoAlterar";
            this.Text = "Alterar Plano Associado";
            this.Load += new System.EventHandler(this.FrmAssociarPlanoAlterar_Load);
            this.grpAtualizarPlano.ResumeLayout(false);
            this.grpAtualizarPlano.PerformLayout();
            this.grpAlterarPlano.ResumeLayout(false);
            this.grpAlterarPlano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarPlano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.GroupBox grpAtualizarPlano;
        private System.Windows.Forms.TextBox txtLimitePedidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricaoPlano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorPlano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuracaoPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpAlterarPlano;
        private System.Windows.Forms.TextBox txtLimitePedidoAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoPlanoAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPlanoAlterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuracaoPlanoAlterar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeAtualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPlanosAtualizar;
        private System.Windows.Forms.Button btnAlterarPlanoAssociado;
        private System.Windows.Forms.MaskedTextBox mskDataTerminoPlano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskDataInicioPlano;
        private System.Windows.Forms.TextBox txtDescontoPlano;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mskDataTerminoAtualizar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskDataInicioAtualizar;
        private System.Windows.Forms.TextBox txtDescontoAtualizar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAtualizarPlano;
        private System.Windows.Forms.TextBox txtIdPlanoClienteAssociado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAssociarPlano;
    }
}