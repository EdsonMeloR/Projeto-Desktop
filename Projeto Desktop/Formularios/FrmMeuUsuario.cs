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
    public partial class FrmMeuUsuario : Form
    {
        public FrmMeuUsuario()
        {
            InitializeComponent();
        }

        private void FrmMeuUsuario_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            Niveis n = new Niveis();
            user.ConsultarUsuario(Program.userLogado.Id);
            this.txtIdUsuario.Text = user.Id.ToString();
            this.txtCpf.Text = user.Cpf;
            this.txtEmail.Text = user.Email;
            n.ConsultarNivel(user.IdNivel.IdNivel);
            this.txtNivel.Text = n.NomeNivel;
            this.txtNome.Text = user.Nome;
            this.mskTelefone.Text = user.Telefone;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if (DialogResult.Yes == MessageBox.Show("Deseja alterar a senha?","Alterar senha",MessageBoxButtons.YesNo))
            {
                if (txtNovaSenha.Text == txtRepitaNovaSenha.Text && txtNovaSenha.Text != string.Empty)
                {
                    if (Program.userLogado.Senha.ToString() == user.GerarSenhaMd5(txtNovaSenha.Text))
                    {
                        MessageBox.Show("A senha é igual a atual\nNão foi possivel alterar");
                    }
                    else
                    {
                        if (user.AlterarSenha(Program.userLogado.Id, txtNovaSenha.Text))
                        {
                            MessageBox.Show("Senha alterada com sucesso !!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("As senhas devem ser iguais !!");
                }
            }
            var a = mskTelefone.Text.Replace("(", "");
            a = mskTelefone.Text.Replace(")", "");
            a = mskTelefone.Text.Replace("-", "");
            if(user.AlterarUsuario(Convert.ToInt32(txtIdUsuario.Text), a, txtEmail.Text))
            {
                MessageBox.Show("Usuario alterado com sucesso !!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar Usuario !!");
            }
        }
    }
}
