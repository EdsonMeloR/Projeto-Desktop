using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Classes;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmLogin : Form
    {
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
                if(user.PrimeiroLogin == false)
                {
                    this.Hide();
                    FrmPrincipal frm = new FrmPrincipal();                    
                    frm.Show();                    
                    Program.userLogado = user;
                }
                else if (user.PrimeiroLogin)
                {
                    this.Hide();
                    FrmPrimeiroLogin frm = new FrmPrimeiroLogin();                    
                    frm.Show();                    
                    //Program.userLogado = user;                    
                }                              
            }
        }
    }
}
