namespace Projeto_Desktop.Formularios
{
    partial class FrmTipoCarga
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
            this.cmbNomeFrete = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTiposFretes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposFretes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNomeFrete
            // 
            this.cmbNomeFrete.FormattingEnabled = true;
            this.cmbNomeFrete.Location = new System.Drawing.Point(154, 25);
            this.cmbNomeFrete.Name = "cmbNomeFrete";
            this.cmbNomeFrete.Size = new System.Drawing.Size(242, 21);
            this.cmbNomeFrete.TabIndex = 20;
            this.cmbNomeFrete.SelectedIndexChanged += new System.EventHandler(this.cmbNomeFrete_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(166, 154);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 154);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 65);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(385, 83);
            this.txtDescricao.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descricao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome Tipo";
            // 
            // txtIdTipoCarga
            // 
            this.txtIdTipoCarga.Enabled = false;
            this.txtIdTipoCarga.Location = new System.Drawing.Point(12, 26);
            this.txtIdTipoCarga.Name = "txtIdTipoCarga";
            this.txtIdTipoCarga.Size = new System.Drawing.Size(136, 20);
            this.txtIdTipoCarga.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Tipo Carga";
            // 
            // dgvTiposFretes
            // 
            this.dgvTiposFretes.AllowUserToAddRows = false;
            this.dgvTiposFretes.AllowUserToDeleteRows = false;
            this.dgvTiposFretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposFretes.Location = new System.Drawing.Point(12, 183);
            this.dgvTiposFretes.Name = "dgvTiposFretes";
            this.dgvTiposFretes.ReadOnly = true;
            this.dgvTiposFretes.RowHeadersVisible = false;
            this.dgvTiposFretes.Size = new System.Drawing.Size(385, 222);
            this.dgvTiposFretes.TabIndex = 12;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(322, 154);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmTipoCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 424);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cmbNomeFrete);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTipoCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTiposFretes);
            this.Name = "FrmTipoCarga";
            this.Text = "Tipo Carga";
            this.Load += new System.EventHandler(this.FrmTipoCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposFretes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNomeFrete;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiposFretes;
        private System.Windows.Forms.Button btnAlterar;
    }
}