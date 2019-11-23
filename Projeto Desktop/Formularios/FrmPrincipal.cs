using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Formularios;
using Projeto_Desktop.Classes;

namespace Projeto_Desktop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frm = new FrmClienteCadastrar();
            frm.Show();
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteAlterar frm = new FrmClienteAlterar();
            frm.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteConsultar frm = new FrmClienteConsultar();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();                
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frm = new FrmPedidoNovo();
            frm.Show();
        }

        private void consultarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoConsultar frm = new FrmPedidoConsultar();
            frm.Show();            
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoConsultar frm = new FrmPedidoConsultar();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void associarPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAssociarPlano frm = new FrmAssociarPlano();
            frm.Show();
        }

        private void administraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void niveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNivel frm = new FrmNivel();
            frm.Show();
        }

        private void inserirPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlano frmp = new FrmPlano();
            frmp.Show();
        }

        private void consultarPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanoConsultar frm = new FrmPlanoConsultar();
            frm.Show();
        }

        private void caminhoneirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMotorista frm = new FrmMotorista();
            frm.Show();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeiculo frm = new FrmVeiculo();
            frm.Show();
        }
    }
}
