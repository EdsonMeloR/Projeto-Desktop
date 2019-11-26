namespace Projeto_Desktop.Formularios
{
    partial class FrmTipoFrete
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
            this.dgvTiposFretes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdTipoFrete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cmbNomeTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposFretes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTiposFretes
            // 
            this.dgvTiposFretes.AllowUserToAddRows = false;
            this.dgvTiposFretes.AllowUserToDeleteRows = false;
            this.dgvTiposFretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposFretes.Location = new System.Drawing.Point(12, 186);
            this.dgvTiposFretes.Name = "dgvTiposFretes";
            this.dgvTiposFretes.ReadOnly = true;
            this.dgvTiposFretes.RowHeadersVisible = false;
            this.dgvTiposFretes.Size = new System.Drawing.Size(385, 222);
            this.dgvTiposFretes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Tipo Frete";
            // 
            // txtIdTipoFrete
            // 
            this.txtIdTipoFrete.Enabled = false;
            this.txtIdTipoFrete.Location = new System.Drawing.Point(12, 29);
            this.txtIdTipoFrete.Name = "txtIdTipoFrete";
            this.txtIdTipoFrete.Size = new System.Drawing.Size(136, 20);
            this.txtIdTipoFrete.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Tipo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 68);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(385, 83);
            this.txtDescricao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descricao";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 157);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(166, 157);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(320, 157);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cmbNomeTipo
            // 
            this.cmbNomeTipo.FormattingEnabled = true;
            this.cmbNomeTipo.Location = new System.Drawing.Point(154, 28);
            this.cmbNomeTipo.Name = "cmbNomeTipo";
            this.cmbNomeTipo.Size = new System.Drawing.Size(242, 21);
            this.cmbNomeTipo.TabIndex = 11;
            // 
            // FrmTipoFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 420);
            this.Controls.Add(this.cmbNomeTipo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTipoFrete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTiposFretes);
            this.Name = "FrmTipoFrete";
            this.Text = "FrmTipoFrete";
            this.Load += new System.EventHandler(this.FrmTipoFrete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposFretes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiposFretes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdTipoFrete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cmbNomeTipo;
    }
}