namespace Projeto_Desktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associarPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposFretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirPlanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPlanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoneirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblNomeUsuarioLogado = new System.Windows.Forms.Label();
            this.btnMeuUsuario = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.visualizarEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(179)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.planoToolStripMenuItem,
            this.caminhoneirosToolStripMenuItem,
            this.veiculoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Stretch = false;
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.consultarPedidoToolStripMenuItem,
            this.alterarToolStripMenuItem});
            resources.ApplyResources(this.pedidosToolStripMenuItem, "pedidosToolStripMenuItem");
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            resources.ApplyResources(this.novoPedidoToolStripMenuItem, "novoPedidoToolStripMenuItem");
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // consultarPedidoToolStripMenuItem
            // 
            this.consultarPedidoToolStripMenuItem.Name = "consultarPedidoToolStripMenuItem";
            resources.ApplyResources(this.consultarPedidoToolStripMenuItem, "consultarPedidoToolStripMenuItem");
            this.consultarPedidoToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidoToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            resources.ApplyResources(this.alterarToolStripMenuItem, "alterarToolStripMenuItem");
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.alterarClienteToolStripMenuItem,
            this.associarPlanoToolStripMenuItem});
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            resources.ApplyResources(this.cadastrarClienteToolStripMenuItem, "cadastrarClienteToolStripMenuItem");
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            resources.ApplyResources(this.consultarClienteToolStripMenuItem, "consultarClienteToolStripMenuItem");
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            resources.ApplyResources(this.alterarClienteToolStripMenuItem, "alterarClienteToolStripMenuItem");
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // associarPlanoToolStripMenuItem
            // 
            this.associarPlanoToolStripMenuItem.Name = "associarPlanoToolStripMenuItem";
            resources.ApplyResources(this.associarPlanoToolStripMenuItem, "associarPlanoToolStripMenuItem");
            this.associarPlanoToolStripMenuItem.Click += new System.EventHandler(this.associarPlanoToolStripMenuItem_Click);
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarEntregaToolStripMenuItem});
            resources.ApplyResources(this.entregasToolStripMenuItem, "entregasToolStripMenuItem");
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.niveisToolStripMenuItem,
            this.tiposFretesToolStripMenuItem,
            this.tiposCargasToolStripMenuItem});
            resources.ApplyResources(this.administraçãoToolStripMenuItem, "administraçãoToolStripMenuItem");
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Click += new System.EventHandler(this.administraçãoToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            resources.ApplyResources(this.usuáriosToolStripMenuItem, "usuáriosToolStripMenuItem");
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // niveisToolStripMenuItem
            // 
            this.niveisToolStripMenuItem.Name = "niveisToolStripMenuItem";
            resources.ApplyResources(this.niveisToolStripMenuItem, "niveisToolStripMenuItem");
            this.niveisToolStripMenuItem.Click += new System.EventHandler(this.niveisToolStripMenuItem_Click);
            // 
            // tiposFretesToolStripMenuItem
            // 
            this.tiposFretesToolStripMenuItem.Name = "tiposFretesToolStripMenuItem";
            resources.ApplyResources(this.tiposFretesToolStripMenuItem, "tiposFretesToolStripMenuItem");
            this.tiposFretesToolStripMenuItem.Click += new System.EventHandler(this.tiposFretesToolStripMenuItem_Click);
            // 
            // tiposCargasToolStripMenuItem
            // 
            this.tiposCargasToolStripMenuItem.Name = "tiposCargasToolStripMenuItem";
            resources.ApplyResources(this.tiposCargasToolStripMenuItem, "tiposCargasToolStripMenuItem");
            this.tiposCargasToolStripMenuItem.Click += new System.EventHandler(this.tiposCargasToolStripMenuItem_Click);
            // 
            // planoToolStripMenuItem
            // 
            this.planoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirPlanosToolStripMenuItem,
            this.consultarPlanosToolStripMenuItem});
            resources.ApplyResources(this.planoToolStripMenuItem, "planoToolStripMenuItem");
            this.planoToolStripMenuItem.Name = "planoToolStripMenuItem";
            this.planoToolStripMenuItem.Click += new System.EventHandler(this.planoToolStripMenuItem_Click);
            // 
            // inserirPlanosToolStripMenuItem
            // 
            this.inserirPlanosToolStripMenuItem.Name = "inserirPlanosToolStripMenuItem";
            resources.ApplyResources(this.inserirPlanosToolStripMenuItem, "inserirPlanosToolStripMenuItem");
            this.inserirPlanosToolStripMenuItem.Click += new System.EventHandler(this.inserirPlanosToolStripMenuItem_Click);
            // 
            // consultarPlanosToolStripMenuItem
            // 
            this.consultarPlanosToolStripMenuItem.Name = "consultarPlanosToolStripMenuItem";
            resources.ApplyResources(this.consultarPlanosToolStripMenuItem, "consultarPlanosToolStripMenuItem");
            this.consultarPlanosToolStripMenuItem.Click += new System.EventHandler(this.consultarPlanosToolStripMenuItem_Click);
            // 
            // caminhoneirosToolStripMenuItem
            // 
            resources.ApplyResources(this.caminhoneirosToolStripMenuItem, "caminhoneirosToolStripMenuItem");
            this.caminhoneirosToolStripMenuItem.Name = "caminhoneirosToolStripMenuItem";
            this.caminhoneirosToolStripMenuItem.Click += new System.EventHandler(this.caminhoneirosToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            resources.ApplyResources(this.veiculoToolStripMenuItem, "veiculoToolStripMenuItem");
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(179)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDesconectar);
            this.panel1.Controls.Add(this.lblNomeUsuarioLogado);
            this.panel1.Controls.Add(this.btnMeuUsuario);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDesconectar
            // 
            resources.ApplyResources(this.btnDesconectar, "btnDesconectar");
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblNomeUsuarioLogado
            // 
            resources.ApplyResources(this.lblNomeUsuarioLogado, "lblNomeUsuarioLogado");
            this.lblNomeUsuarioLogado.Name = "lblNomeUsuarioLogado";
            // 
            // btnMeuUsuario
            // 
            resources.ApplyResources(this.btnMeuUsuario, "btnMeuUsuario");
            this.btnMeuUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMeuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMeuUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeuUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMeuUsuario.Name = "btnMeuUsuario";
            this.btnMeuUsuario.UseVisualStyleBackColor = true;
            this.btnMeuUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // visualizarEntregaToolStripMenuItem
            // 
            this.visualizarEntregaToolStripMenuItem.Name = "visualizarEntregaToolStripMenuItem";
            resources.ApplyResources(this.visualizarEntregaToolStripMenuItem, "visualizarEntregaToolStripMenuItem");
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolStripMenuItem associarPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirPlanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPlanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoneirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMeuUsuario;
        private System.Windows.Forms.Label lblNomeUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem tiposFretesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.ToolStripMenuItem tiposCargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEntregaToolStripMenuItem;
    }
}

