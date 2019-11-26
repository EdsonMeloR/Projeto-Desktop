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
    public partial class FrmTipoFrete : Form
    {
        public FrmTipoFrete()
        {
            InitializeComponent();
        }

        private void FrmTipoFrete_Load(object sender, EventArgs e)
        {
            TipoFrete tf = new TipoFrete();
            cmbNomeTipo.ValueMember = "Id";
            cmbNomeTipo.DisplayMember = "Nome";
            cmbNomeTipo.DataSource = tf.ListarTiposFretes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TipoFrete tf = new TipoFrete();
            if(cmbNomeTipo.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                tf.InserirTipoFrete(cmbNomeTipo.Text, txtDescricao.Text);
                if(tf.Id > 0)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos disponiveis para alteração");
            }            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            TipoFrete tf = new TipoFrete();
            dgvTiposFretes.DataSource = tf.ListarTiposFretes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TipoFrete tf = new TipoFrete();
            if(txtIdTipoFrete.Text != string.Empty && txtDescricao.Text != string.Empty && cmbNomeTipo.Text != string.Empty)
            {
                if (tf.AlterarTipoFrete(cmbNomeTipo.Text, txtDescricao.Text, Convert.ToInt32(txtIdTipoFrete.Text)))
                {
                    MessageBox.Show("Alterado com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos", "Erro ao alterar");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }            
        }
    }
}
