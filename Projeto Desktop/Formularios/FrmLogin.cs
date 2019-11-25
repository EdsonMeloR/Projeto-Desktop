using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Windows.Forms;
using Projeto_Desktop.Classes;
using System.IO;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmLogin : Form
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
        SessaoUsuario Su = new SessaoUsuario();        
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.RecuperarSenha(txtCpf.Text);            
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if (user.EfetuarLogin(txtCpf.Text.Trim(), txtSenha.Text.Trim()))
            {
                if (user.PrimeiroLogin == false)
                {
                    Su = new SessaoUsuario();
                    FrmPrincipal frm = new FrmPrincipal(); 
                    Su.Cpf = user.Cpf;
                    Su.Id = user.Id;
                    Su.Nivel = user.IdNivel.IdNivel;
                    Su.Nome = user.Nome;
                    Su.Sessao = true;
                    BancoLocal.AtualizarSessao(Su);
                    this.Hide();
                    frm.Show();
                }
                else if (user.PrimeiroLogin)
                {
                    this.Hide();
                    FrmPrimeiroLogin frm = new FrmPrimeiroLogin();
                    frm.Show();
                    Program.userLogado = user;                    
                }
            }
            else
                MessageBox.Show("Cpf ou Senha incorretos");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            var a = BancoLocal.ObterListaSessao();
            if (a.Result.Count == 1)
            {
                foreach (var user in a.Result)
                {
                    if(user.Sessao)
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Show();
                        this.Hide();
                        MessageBox.Show("Bem vindo " + user.Nome,"Bem Vindo");
                    }
                }
            }
            else
            {
                Su = new SessaoUsuario();
                BancoLocal.InserirSessao(Su);
            }
        }   
    }
}
