namespace Projeto_Desktop.Formularios
{
    partial class FrmPedidoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoNovo));
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.chkRetirar = new System.Windows.Forms.CheckBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.mskDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnderecoRemetente = new System.Windows.Forms.ComboBox();
            this.btnAdicionarEnderecoRemetente = new System.Windows.Forms.Button();
            this.btnNovoEnderecoRemetente = new System.Windows.Forms.Button();
            this.grbEnderecosRemetente = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.grbEnderecoDestino = new System.Windows.Forms.GroupBox();
            this.txtReferenciaDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplementoDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCepDestino = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouroDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNovoEnderecoDestino = new System.Windows.Forms.Button();
            this.btnAdicionarEnderecoDestino = new System.Windows.Forms.Button();
            this.cmbEnderecoDestino = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdicionarCargas = new System.Windows.Forms.Button();
            this.grbEnderecosRemetente.SuspendLayout();
            this.grbEnderecoDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(673, 77);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(115, 23);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(12, 31);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Situação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuários";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(12, 80);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(137, 21);
            this.cmbSituacao.TabIndex = 11;
            this.cmbSituacao.SelectedIndexChanged += new System.EventHandler(this.cmbSituacao_SelectedIndexChanged);
            // 
            // chkRetirar
            // 
            this.chkRetirar.AutoSize = true;
            this.chkRetirar.Location = new System.Drawing.Point(610, 81);
            this.chkRetirar.Name = "chkRetirar";
            this.chkRetirar.Size = new System.Drawing.Size(57, 17);
            this.chkRetirar.TabIndex = 13;
            this.chkRetirar.Text = "Retirar";
            this.chkRetirar.UseVisualStyleBackColor = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(284, 79);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(137, 21);
            this.cmbUsuario.TabIndex = 14;
            // 
            // mskDataPedido
            // 
            this.mskDataPedido.Enabled = false;
            this.mskDataPedido.Location = new System.Drawing.Point(155, 81);
            this.mskDataPedido.Mask = "00/00/0000   00:00";
            this.mskDataPedido.Name = "mskDataPedido";
            this.mskDataPedido.Size = new System.Drawing.Size(123, 20);
            this.mskDataPedido.TabIndex = 15;
            this.mskDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(427, 79);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(177, 21);
            this.cmbClientes.TabIndex = 19;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Endereço Remetente";
            // 
            // cmbEnderecoRemetente
            // 
            this.cmbEnderecoRemetente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnderecoRemetente.FormattingEnabled = true;
            this.cmbEnderecoRemetente.Location = new System.Drawing.Point(6, 39);
            this.cmbEnderecoRemetente.Name = "cmbEnderecoRemetente";
            this.cmbEnderecoRemetente.Size = new System.Drawing.Size(344, 21);
            this.cmbEnderecoRemetente.TabIndex = 18;
            this.cmbEnderecoRemetente.SelectedIndexChanged += new System.EventHandler(this.cmbEnderecoRemetente_SelectedIndexChanged);
            // 
            // btnAdicionarEnderecoRemetente
            // 
            this.btnAdicionarEnderecoRemetente.Location = new System.Drawing.Point(356, 76);
            this.btnAdicionarEnderecoRemetente.Name = "btnAdicionarEnderecoRemetente";
            this.btnAdicionarEnderecoRemetente.Size = new System.Drawing.Size(172, 23);
            this.btnAdicionarEnderecoRemetente.TabIndex = 18;
            this.btnAdicionarEnderecoRemetente.Text = "Adicionar Endereços";
            this.btnAdicionarEnderecoRemetente.UseVisualStyleBackColor = true;
            this.btnAdicionarEnderecoRemetente.Click += new System.EventHandler(this.btnAdicionarEndereco_Click);
            // 
            // btnNovoEnderecoRemetente
            // 
            this.btnNovoEnderecoRemetente.Location = new System.Drawing.Point(534, 76);
            this.btnNovoEnderecoRemetente.Name = "btnNovoEnderecoRemetente";
            this.btnNovoEnderecoRemetente.Size = new System.Drawing.Size(166, 23);
            this.btnNovoEnderecoRemetente.TabIndex = 21;
            this.btnNovoEnderecoRemetente.Text = "Novo Endereço";
            this.btnNovoEnderecoRemetente.UseVisualStyleBackColor = true;
            this.btnNovoEnderecoRemetente.Click += new System.EventHandler(this.btnNovoEndereco_Click);
            // 
            // grbEnderecosRemetente
            // 
            this.grbEnderecosRemetente.Controls.Add(this.txtReferencia);
            this.grbEnderecosRemetente.Controls.Add(this.label13);
            this.grbEnderecosRemetente.Controls.Add(this.txtComplemento);
            this.grbEnderecosRemetente.Controls.Add(this.label12);
            this.grbEnderecosRemetente.Controls.Add(this.txtNumero);
            this.grbEnderecosRemetente.Controls.Add(this.lblNumero);
            this.grbEnderecosRemetente.Controls.Add(this.txtCep);
            this.grbEnderecosRemetente.Controls.Add(this.lblCep);
            this.grbEnderecosRemetente.Controls.Add(this.txtLogradouro);
            this.grbEnderecosRemetente.Controls.Add(this.lblLogradouro);
            this.grbEnderecosRemetente.Controls.Add(this.btnNovoEnderecoRemetente);
            this.grbEnderecosRemetente.Controls.Add(this.btnAdicionarEnderecoRemetente);
            this.grbEnderecosRemetente.Controls.Add(this.cmbEnderecoRemetente);
            this.grbEnderecosRemetente.Controls.Add(this.label5);
            this.grbEnderecosRemetente.Enabled = false;
            this.grbEnderecosRemetente.Location = new System.Drawing.Point(12, 128);
            this.grbEnderecosRemetente.Name = "grbEnderecosRemetente";
            this.grbEnderecosRemetente.Size = new System.Drawing.Size(776, 142);
            this.grbEnderecosRemetente.TabIndex = 16;
            this.grbEnderecosRemetente.TabStop = false;
            this.grbEnderecosRemetente.Text = "Endereços Remetente";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Location = new System.Drawing.Point(112, 79);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(238, 20);
            this.txtReferencia.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Referência";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(6, 79);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(679, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(89, 20);
            this.txtNumero.TabIndex = 28;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(676, 24);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Número";
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(552, 40);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(121, 20);
            this.txtCep.TabIndex = 26;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(549, 24);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 25;
            this.lblCep.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(356, 40);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(190, 20);
            this.txtLogradouro.TabIndex = 24;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(353, 24);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 23;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // grbEnderecoDestino
            // 
            this.grbEnderecoDestino.Controls.Add(this.txtReferenciaDestino);
            this.grbEnderecoDestino.Controls.Add(this.label6);
            this.grbEnderecoDestino.Controls.Add(this.txtComplementoDestino);
            this.grbEnderecoDestino.Controls.Add(this.label7);
            this.grbEnderecoDestino.Controls.Add(this.txtNumeroDestino);
            this.grbEnderecoDestino.Controls.Add(this.label8);
            this.grbEnderecoDestino.Controls.Add(this.txtCepDestino);
            this.grbEnderecoDestino.Controls.Add(this.label10);
            this.grbEnderecoDestino.Controls.Add(this.txtLogradouroDestino);
            this.grbEnderecoDestino.Controls.Add(this.label11);
            this.grbEnderecoDestino.Controls.Add(this.btnNovoEnderecoDestino);
            this.grbEnderecoDestino.Controls.Add(this.btnAdicionarEnderecoDestino);
            this.grbEnderecoDestino.Controls.Add(this.cmbEnderecoDestino);
            this.grbEnderecoDestino.Controls.Add(this.label14);
            this.grbEnderecoDestino.Enabled = false;
            this.grbEnderecoDestino.Location = new System.Drawing.Point(12, 276);
            this.grbEnderecoDestino.Name = "grbEnderecoDestino";
            this.grbEnderecoDestino.Size = new System.Drawing.Size(776, 116);
            this.grbEnderecoDestino.TabIndex = 31;
            this.grbEnderecoDestino.TabStop = false;
            this.grbEnderecoDestino.Text = "Endereços Destinatario";
            // 
            // txtReferenciaDestino
            // 
            this.txtReferenciaDestino.Enabled = false;
            this.txtReferenciaDestino.Location = new System.Drawing.Point(112, 79);
            this.txtReferenciaDestino.Name = "txtReferenciaDestino";
            this.txtReferenciaDestino.Size = new System.Drawing.Size(238, 20);
            this.txtReferenciaDestino.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Referência";
            // 
            // txtComplementoDestino
            // 
            this.txtComplementoDestino.Enabled = false;
            this.txtComplementoDestino.Location = new System.Drawing.Point(6, 79);
            this.txtComplementoDestino.Name = "txtComplementoDestino";
            this.txtComplementoDestino.Size = new System.Drawing.Size(100, 20);
            this.txtComplementoDestino.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Complemento";
            // 
            // txtNumeroDestino
            // 
            this.txtNumeroDestino.Enabled = false;
            this.txtNumeroDestino.Location = new System.Drawing.Point(679, 40);
            this.txtNumeroDestino.Name = "txtNumeroDestino";
            this.txtNumeroDestino.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroDestino.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Número";
            // 
            // txtCepDestino
            // 
            this.txtCepDestino.Enabled = false;
            this.txtCepDestino.Location = new System.Drawing.Point(552, 40);
            this.txtCepDestino.Name = "txtCepDestino";
            this.txtCepDestino.Size = new System.Drawing.Size(121, 20);
            this.txtCepDestino.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(549, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "CEP";
            // 
            // txtLogradouroDestino
            // 
            this.txtLogradouroDestino.Enabled = false;
            this.txtLogradouroDestino.Location = new System.Drawing.Point(356, 40);
            this.txtLogradouroDestino.Name = "txtLogradouroDestino";
            this.txtLogradouroDestino.Size = new System.Drawing.Size(190, 20);
            this.txtLogradouroDestino.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Logradouro";
            // 
            // btnNovoEnderecoDestino
            // 
            this.btnNovoEnderecoDestino.Location = new System.Drawing.Point(534, 79);
            this.btnNovoEnderecoDestino.Name = "btnNovoEnderecoDestino";
            this.btnNovoEnderecoDestino.Size = new System.Drawing.Size(166, 23);
            this.btnNovoEnderecoDestino.TabIndex = 21;
            this.btnNovoEnderecoDestino.Text = "Novo Endereço";
            this.btnNovoEnderecoDestino.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEnderecoDestino
            // 
            this.btnAdicionarEnderecoDestino.Location = new System.Drawing.Point(356, 79);
            this.btnAdicionarEnderecoDestino.Name = "btnAdicionarEnderecoDestino";
            this.btnAdicionarEnderecoDestino.Size = new System.Drawing.Size(172, 23);
            this.btnAdicionarEnderecoDestino.TabIndex = 18;
            this.btnAdicionarEnderecoDestino.Text = "Adicionar Endereços";
            this.btnAdicionarEnderecoDestino.UseVisualStyleBackColor = true;
            this.btnAdicionarEnderecoDestino.Click += new System.EventHandler(this.btnAdicionarEnderecoDestino_Click);
            // 
            // cmbEnderecoDestino
            // 
            this.cmbEnderecoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnderecoDestino.FormattingEnabled = true;
            this.cmbEnderecoDestino.Location = new System.Drawing.Point(6, 39);
            this.cmbEnderecoDestino.Name = "cmbEnderecoDestino";
            this.cmbEnderecoDestino.Size = new System.Drawing.Size(344, 21);
            this.cmbEnderecoDestino.TabIndex = 18;
            this.cmbEnderecoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbEnderecoDestino_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Endereço Destinatario";
            // 
            // btnAdicionarCargas
            // 
            this.btnAdicionarCargas.Enabled = false;
            this.btnAdicionarCargas.Location = new System.Drawing.Point(629, 398);
            this.btnAdicionarCargas.Name = "btnAdicionarCargas";
            this.btnAdicionarCargas.Size = new System.Drawing.Size(129, 40);
            this.btnAdicionarCargas.TabIndex = 32;
            this.btnAdicionarCargas.Text = "Adicionar Cargas";
            this.btnAdicionarCargas.UseVisualStyleBackColor = true;
            this.btnAdicionarCargas.Click += new System.EventHandler(this.btnAdicionarCargas_Click);
            // 
            // FrmPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarCargas);
            this.Controls.Add(this.grbEnderecoDestino);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grbEnderecosRemetente);
            this.Controls.Add(this.mskDataPedido);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.chkRetirar);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.grbEnderecosRemetente.ResumeLayout(false);
            this.grbEnderecosRemetente.PerformLayout();
            this.grbEnderecoDestino.ResumeLayout(false);
            this.grbEnderecoDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRetirar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.MaskedTextBox mskDataPedido;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEnderecoRemetente;
        private System.Windows.Forms.Button btnAdicionarEnderecoRemetente;
        private System.Windows.Forms.Button btnNovoEnderecoRemetente;
        private System.Windows.Forms.GroupBox grbEnderecosRemetente;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.GroupBox grbEnderecoDestino;
        private System.Windows.Forms.TextBox txtReferenciaDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplementoDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCepDestino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouroDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNovoEnderecoDestino;
        private System.Windows.Forms.Button btnAdicionarEnderecoDestino;
        private System.Windows.Forms.ComboBox cmbEnderecoDestino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdicionarCargas;
        private System.Windows.Forms.ComboBox cmbSituacao;
    }
}