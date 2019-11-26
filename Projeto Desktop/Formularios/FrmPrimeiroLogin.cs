using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Classes;
using Projeto_Desktop.Formularios;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmPrimeiroLogin : Form
    {
        static BancoSqLite bancoLocal;
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
        public FrmPrimeiroLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrimeiroLogin_Load(object sender, EventArgs e)
        {                       
            this.lblPrimeiroLogin.Text = "Primeiro Login?\n" + Program.userLogado.Nome + "\nModifique sua senha";
        }

        private void btnModificarSenha_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if(txtSenha.Text == txtSenha2.Text)
            {
                if(user.AlterarSenha(Program.userLogado.Id,txtSenha.Text.ToString()))
                {
                    SessaoUsuario su = new SessaoUsuario();
                    user.AlterarFirstLogin(Program.userLogado.Id);
                    this.Hide();
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    su.Cpf = Program.userLogado.Cpf;
                    su.Id = 1;
                    su.Nivel = Program.userLogado.IdNivel.IdNivel;
                    su.Nome = Program.userLogado.Nome;
                    su.Sessao = false;
                    BancoLocal.AtualizarSessao(su);
                }
            }
            else
            {
                MessageBox.Show("As senhas devem ser compativeis");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
