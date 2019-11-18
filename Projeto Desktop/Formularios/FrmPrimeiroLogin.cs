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
using Projeto_Desktop.Formularios;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmPrimeiroLogin : Form
    {
        public FrmPrimeiroLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrimeiroLogin_Load(object sender, EventArgs e)
        {                       
            this.lblPrimeiroLogin.Text = "Primeiro Login? " + Program.userLogado.Nome + " Modifique sua senha";
        }

        private void btnModificarSenha_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if(txtSenha.Text == txtSenha2.Text)
            {
                if(user.AlterarSenha(Program.userLogado.Id,txtSenha.Text.ToString()))
                {
                    user.AlterarFirstLogin(Program.userLogado.Id);
                    this.Hide();
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("As senhas devem ser compativeis");
            }
        }
    }
}
