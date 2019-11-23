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
    public partial class FrmUsuario : Form
    {
        Usuario user;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            var a = mskTelefone.Text.Replace("(", "");
            a = a.Replace(")", "");
            a = a.Replace(" ", "");            
            if (txtIdUsuario.Text != string.Empty && txtEmail.Text != string.Empty && a != string.Empty)
            {
                if (user.AlterarUsuario(Convert.ToInt32(txtIdUsuario.Text), a.Replace("-", ""), txtEmail.Text))
                {
                    MessageBox.Show("Usuario alterado com sucesso", "Sucesso");
                    btnListar_Click(this, e);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos para alterar");
            }            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Niveis n = new Niveis();            
            user = new Usuario();
            user.ConsultarUsuario(mskCpf.Text);
            mskCpf.Text = user.Cpf;
            txtEmail.Text = user.Email;
            txtIdUsuario.Text = user.Id.ToString();
            foreach(var nivel in n.ListarNiveis())
            {
                if (nivel.IdNivel == user.IdNivel.IdNivel)
                    cmbNivel.SelectedValue = nivel.NomeNivel;
            }
            txtNome.Text = user.Nome;
            mskTelefone.Text = user.Telefone;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            dgvListarUsuarios.DataSource = user.ListarUsuarios();
        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            //Removendo qualquer tipo de caracter invalido do numero
            var a = mskTelefone.Text.Replace("(", "");
            a = a.Replace(")", "");
            a = a.Replace(" ", "");
            //Pegando a senha com base no primeiro nome do usuario antes de 1° espaço
            var senha = txtNome.Text.Substring(0, txtNome.Text.IndexOf(" ", 1));
            if (txtNome.Text != string.Empty && mskCpf.Text != string.Empty && txtEmail.Text != string.Empty && mskTelefone.Text != string.Empty && senha.ToLower() != string.Empty)
            {
                user.InserirUsuario(txtNome.Text, mskCpf.Text.Replace("-",""), a.Replace("-",""), senha, txtEmail.Text, Convert.ToInt32(cmbNivel.SelectedValue));
                if(user.Id > 0)
                {
                    MessageBox.Show("Usuario inserido com sucesso","Inserido");
                    MessageBox.Show("Será necessário modificar a senha em seu 1° Acesso\nSenha é definidada como seu primeiro nome automaticamente","Inserido");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos","Aviso");
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //Carregando combo box de Niveis
            Niveis n = new Niveis();
            cmbNivel.DisplayMember = "NomeNivel";
            cmbNivel.ValueMember = "IdNivel";
            cmbNivel.DataSource = n.ListarNiveis();
            //Carregando combo box de usuarios
            user = new Usuario();
            txtNome.DisplayMember = "Nome";
            txtNome.ValueMember = "Id";
            txtNome.DataSource = user.ListarUsuarios();
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = new Usuario();
            user.ConsultarUsuario(Convert.ToInt32(txtNome.SelectedValue));
            txtEmail.Text = user.Email;
            txtIdUsuario.Text = user.Id.ToString();
            mskCpf.Text = user.Cpf;
            mskTelefone.Text = user.Telefone;
            cmbNivel.SelectedValue = user.IdNivel.IdNivel;
        }
    }
}
