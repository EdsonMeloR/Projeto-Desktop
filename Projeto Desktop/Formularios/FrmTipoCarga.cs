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
    public partial class FrmTipoCarga : Form
    {
        public FrmTipoCarga()
        {
            InitializeComponent();
        }
        TipoCarga tc;
        private void FrmTipoCarga_Load(object sender, EventArgs e)
        {
            tc = new TipoCarga();
            cmbNomeFrete.ValueMember = "Id";
            cmbNomeFrete.DisplayMember = "Nome";
            cmbNomeFrete.DataSource = tc.ListarTiposCargas();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            tc = new TipoCarga();
            if(cmbNomeFrete.Text != string.Empty && txtDescricao.Text !=string.Empty)
            {
                tc.InserirTipoCarga(cmbNomeFrete.Text, txtDescricao.Text);
                if (tc.Id > 0)
                {
                    MessageBox.Show("Cadastrado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            tc = new TipoCarga();
            dgvTiposFretes.DataSource = tc.ListarTiposCargas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tc = new TipoCarga();
            if(txtDescricao.Text != string.Empty && txtIdTipoCarga.Text != string.Empty && cmbNomeFrete.Text != string.Empty)
            {
                if (tc.AlterarTipoCarga(cmbNomeFrete.DisplayMember, txtDescricao.Text, Convert.ToInt32(txtIdTipoCarga.Text)))
                {
                    MessageBox.Show("Alterado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
        }

        private void cmbNomeFrete_SelectedIndexChanged(object sender, EventArgs e)
        {
            tc = new TipoCarga();
            tc.ConsultarTipoCarga(Convert.ToInt32(cmbNomeFrete.SelectedValue));
            txtIdTipoCarga.Text = tc.Id.ToString();
            txtDescricao.Text = tc.Descricao;
            cmbNomeFrete.SelectedValue = tc.Id.ToString();
        }
    }
}
