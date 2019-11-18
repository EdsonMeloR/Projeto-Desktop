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
            FrmUsuarioCadastrar f = new FrmUsuarioCadastrar();
            f.Show();                
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarioAlterar f = new FrmUsuarioAlterar();
            f.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanos frmp = new FrmPlanos();
            frmp.Show();
        }
    }
}
