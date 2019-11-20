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

namespace Projeto_Desktop.Formularios
{
    public partial class FrmUsuarioCadastrar : Form
    {
        public FrmUsuarioCadastrar()
        {
            InitializeComponent();
        }

        private void FrmUsuarioCadastrar_Load(object sender, EventArgs e)
        {
            Niveis n = new Niveis();
            cmbNivel.DataSource = n.ListarNiveis();
            cmbNivel.DisplayMember = "NomeNivel";
            cmbNivel.ValueMember = "IdNivel";            
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if(txtNome.Text == string.Empty || txtCpf.Text == string.Empty || txtTelefone.Text == string.Empty || txtSenha.Text == string.Empty || txtEmail.Text == string.Empty || cmbNivel.Text == string.Empty)
            {
                MessageBox.Show("É necessario preencher todos os campos");
            }
            else
            {
                user.InserirUsuario(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtSenha.Text, txtEmail.Text, Convert.ToInt32(cmbNivel.SelectedValue));
                if (user.Id > 0)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso", "Sucesso");
                    txtIdUsuario.Text = user.Id.ToString();
                }
                else
                    MessageBox.Show("Falha ao cadastrar usuario", "Erro");
            }            
        }
    }
}
