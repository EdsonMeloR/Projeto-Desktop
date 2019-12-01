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
    public partial class FrmClienteAlterar : Form
    {
        Cliente c;
        public FrmClienteAlterar()
        {
            InitializeComponent();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            c = new Cliente();
            if (txtIdCliente.Text != string.Empty && txtTelefone.Text != string.Empty && txtNomeContato.Text != string.Empty && txtEmail.Text != string.Empty && cmbClientes.Text != string.Empty)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja alterar o cliente " + cmbClientes.Text + "?", "Alterar", MessageBoxButtons.YesNo))
                {
                    if (c.AlterarCliente(Convert.ToInt32(txtIdCliente.Text), txtTelefone.Text, txtNomeContato.Text, txtEmail.Text, cmbClientes.Text))
                        MessageBox.Show("cliente alterado com sucesso");
                    else
                        MessageBox.Show("Falha ao alterar", "Erro");
                }                
            }
            else
                MessageBox.Show("É necessário preencher todos os campos !!", "Erro");
            btnListarClientes_Click(this, e);
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            c = new Cliente();
            dgvClientes.DataSource = c.ListarCliente();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            c = new Cliente();
            if(txtIdCliente.Text != string.Empty)
            {
                c.ConsultarClienteCnpj(txtCnpj.Text);
                txtIdCliente.Text = c.Id.ToString();
                txtCnpj.Text = c.Cnpj.ToString();
                txtEmail.Text = c.Email.ToString();
                txtInscricaoEstadual.Text = c.InscricaoEstadual.ToString();
                txtNomeContato.Text = c.NomeContato;
                cmbClientes.Text = c.RazaoSocial;
                txtTelefone.Text = c.Telefone;
            }
            else
            {
                MessageBox.Show("É necessário consultar pelo cliente antes de alterar !!", "Erro");
            }            
        }

        private void FrmClienteAlterar_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.ValueMember = "Id";
            cmbClientes.DataSource = c.ListarCliente();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                c = new Cliente();
                c.ConsultarClienteId(Convert.ToInt32(cmbClientes.SelectedValue));
                txtCnpj.Text = c.Cnpj.ToString();
                txtEmail.Text = c.Email.ToString();
                txtIdCliente.Text = c.Id.ToString();
                txtInscricaoEstadual.Text = c.InscricaoEstadual.ToString();
                txtNomeContato.Text = c.NomeContato;
                txtTelefone.Text = c.Telefone;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }            
        }
    }
}
