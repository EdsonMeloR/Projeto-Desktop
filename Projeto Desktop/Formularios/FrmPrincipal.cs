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
using System.IO;

namespace Projeto_Desktop
{
    public partial class FrmPrincipal : Form
    {
        static BancoSqLite bancoLocal;
        Niveis niveis;
        public static BancoSqLite BancoLocal
        {
            get
            {
                if (bancoLocal == null)
                {
                    bancoLocal = new BancoSqLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjetoSQLite.db"));
                }
                return bancoLocal;
            }
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = BancoLocal.ObterListaSessao();
            niveis = new Niveis();
            
            foreach(var user in a.Result)
            {
                MessageBox.Show("Bem vindo " + user.Nome);
                lblNomeUsuarioLogado.Text = user.Nome;
                niveis.ConsultarNivel(user.Nivel);
                if (niveis.NomeNivel == "Operador")
                {
                    veiculoToolStripMenuItem.Visible = false;
                    administraçãoToolStripMenuItem.Visible = false;
                    caminhoneirosToolStripMenuItem.Visible = false;
                }
                else if(niveis.NomeNivel == "Gerente")
                {

                }
                else if(niveis.NomeNivel == "Administrador")
                {

                }
            }        
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
            FrmPedidoAlterar frm = new FrmPedidoAlterar();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMeuUsuario frm = new FrmMeuUsuario();
            frm.Show();
        }

        private void tiposFretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoFrete frm = new FrmTipoFrete();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SessaoUsuario su = new SessaoUsuario();
            foreach(var a in BancoLocal.ObterListaSessao().Result)
            {
                if(a.Sessao)
                {
                    a.Sessao = false;
                    BancoLocal.AtualizarSessao(a);
                    if(DialogResult.Yes == MessageBox.Show("Sessão encerrada, deseja finalizar a aplicação?", "Sessão encerrada", MessageBoxButtons.YesNo))
                    {
                        this.Close();
                    }
                    else
                    {                        
                        FrmLogin frm = new FrmLogin();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {                    
                    this.Close();                    
                }
            }
        }

        private void tiposCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoCarga frm = new FrmTipoCarga();
            frm.Show();
        }
    }
}
