namespace Projeto_Desktop.Formularios
{
    partial class FrmNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel));
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Enabled = false;
            this.txtIdNivel.Location = new System.Drawing.Point(12, 29);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(125, 20);
            this.txtIdNivel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Nivel";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 98);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar Niveis";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Location = new System.Drawing.Point(12, 127);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.Size = new System.Drawing.Size(284, 147);
            this.dgvNiveis.TabIndex = 7;
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(12, 71);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(284, 21);
            this.cmbNivel.TabIndex = 8;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged);
            // 
            // FrmNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 286);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.dgvNiveis);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdNivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel";
            this.Load += new System.EventHandler(this.FrmNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.ComboBox cmbNivel;
    }
}