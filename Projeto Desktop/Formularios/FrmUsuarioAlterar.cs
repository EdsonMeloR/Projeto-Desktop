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
    public partial class FrmUsuarioAlterar : Form
    {
        Usuario user;
        public FrmUsuarioAlterar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            if(user.AlterarUsuario(Convert.ToInt32(txtIdUsuario.Text), txtTelefone.Text, txtEmail.Text))
            {
                MessageBox.Show("Usuario alterado com sucesso", "Sucesso");
                btnListar_Click(this, e);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Niveis n = new Niveis();            
            user = new Usuario();
            user.ConsultarUsuario(txtCpf.Text);
            txtCpf.Text = user.Cpf;
            txtEmail.Text = user.Email;
            txtIdUsuario.Text = user.Id.ToString();
            foreach(var nivel in n.ListarNiveis())
            {
                if (nivel.IdNivel == user.IdNivel.IdNivel)
                    txtNivel.Text = nivel.NomeNivel;
            }
            txtNome.Text = user.Nome;
            txtSenha.Text = user.Senha;
            txtTelefone.Text = user.Telefone;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            dgvListarUsuarios.DataSource = user.ListarUsuarios();
        }
    }
}
