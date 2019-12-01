namespace Projeto_Desktop.Formularios
{
    partial class FrmEntrega
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
            this.pcbAssinatura = new System.Windows.Forms.PictureBox();
            this.cmbEntregas = new System.Windows.Forms.ComboBox();
            this.txtIdNota = new System.Windows.Forms.TextBox();
            this.lblEntregas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAssinatura)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAssinatura
            // 
            this.pcbAssinatura.Location = new System.Drawing.Point(12, 65);
            this.pcbAssinatura.Name = "pcbAssinatura";
            this.pcbAssinatura.Size = new System.Drawing.Size(336, 87);
            this.pcbAssinatura.TabIndex = 0;
            this.pcbAssinatura.TabStop = false;
            // 
            // cmbEntregas
            // 
            this.cmbEntregas.FormattingEnabled = true;
            this.cmbEntregas.Location = new System.Drawing.Point(12, 25);
            this.cmbEntregas.Name = "cmbEntregas";
            this.cmbEntregas.Size = new System.Drawing.Size(121, 21);
            this.cmbEntregas.TabIndex = 1;
            // 
            // txtIdNota
            // 
            this.txtIdNota.Location = new System.Drawing.Point(139, 25);
            this.txtIdNota.Name = "txtIdNota";
            this.txtIdNota.Size = new System.Drawing.Size(121, 20);
            this.txtIdNota.TabIndex = 2;
            // 
            // lblEntregas
            // 
            this.lblEntregas.AutoSize = true;
            this.lblEntregas.Location = new System.Drawing.Point(9, 8);
            this.lblEntregas.Name = "lblEntregas";
            this.lblEntregas.Size = new System.Drawing.Size(49, 13);
            this.lblEntregas.TabIndex = 3;
            this.lblEntregas.Text = "Entregas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assinatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Entrega";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(266, 25);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(121, 20);
            this.txtDataEntrega.TabIndex = 6;
            // 
            // FrmEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEntregas);
            this.Controls.Add(this.txtIdNota);
            this.Controls.Add(this.cmbEntregas);
            this.Controls.Add(this.pcbAssinatura);
            this.Name = "FrmEntrega";
            this.Text = "Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAssinatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAssinatura;
        private System.Windows.Forms.ComboBox cmbEntregas;
        private System.Windows.Forms.TextBox txtIdNota;
        private System.Windows.Forms.Label lblEntregas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataEntrega;
    }
}