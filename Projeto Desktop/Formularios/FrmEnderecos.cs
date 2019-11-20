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
    public partial class FrmEnderecos : Form
    {
        public FrmEnderecos()
        {
            InitializeComponent();
        }
        private void btnConsultarCep_Click(object sender, EventArgs e)
        {
            if(txtCep.Text == string.Empty)
            {
                MessageBox.Show("É necessário prencheer o campo cep");
            }
            else
            {
                var cep = txtCep.Text.Replace("-", "");
                var ws = new WsCorreios.AtendeClienteClient();
                var endereco = ws.consultaCEP(txtCep.Text.Trim());
                txtCep.Text = endereco.cep.ToString();
                txtLogradouro.Text = endereco.end;
            }            
        }
        private void FrmEnderecos_Load(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            cmbClientes.DataSource = c.ListarCliente();
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.ValueMember = "Id";
            
        }
        private void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.InserirEndereco(txtLogradouro.Text, txtCep.Text.Replace("-", ""), txtNumero.Text, txtComplemento.Text, txtReferencia.Text, Convert.ToInt32(cmbClientes.SelectedValue));
            if(end.Id > 0)
            {
                MessageBox.Show("Endereço inserido com sucesso");
                txtId.Text = end.Id.ToString();
            }
            else
            {
                MessageBox.Show("Falha ao inserir endereço");
            }
        }

        private void btnConsultarEndereco_Click(object sender, EventArgs e)
        {
            dgvEnderecos.Rows.Clear();
            dgvEnderecos.Columns.Clear();
            dgvEnderecos.Columns.Add("Logradouro", "Logradouro");
            dgvEnderecos.Columns.Add("Cep", "Cep");
            dgvEnderecos.Columns.Add("Numero", "Numero");
            dgvEnderecos.Columns.Add("Complemento", "Complemento");
            dgvEnderecos.Columns.Add("RazaoSocial", "RazaoSocial");
            Endereco end = new Endereco();            
            foreach(var endereco in end.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue)))
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvEnderecos);
                item.Cells[0].Value = endereco.Logradouro.ToString();
                item.Cells[1].Value = endereco.Cep.ToString();
                item.Cells[2].Value = endereco.Numero.ToString();
                item.Cells[3].Value = endereco.Complemento;
                item.Cells[4].Value = endereco.IdCliente.RazaoSocial;
                dgvEnderecos.Rows.Add(item);
            }            
        }

        private void dgvEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
