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
            var cep = txtCep.Text.Replace("-","");
            var ws = new WsCorreios.AtendeClienteClient();
            var endereco = ws.consultaCEP(txtCep.Text.Trim());
            txtCep.Text = endereco.cep.ToString();
            txtLogradouro.Text = endereco.end;
        }
        private void FrmEnderecos_Load(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            foreach(var cli in c.ListarCliente())
            {
                cmbClientes.Items.Add(cli.RazaoSocial.ToString());
                cmbClientes.ValueMember = cli.Id.ToString();
            }
        }
        private void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.InserirEndereco(txtLogradouro.Text, txtCep.Text.Replace("-", ""), txtNumero.Text, txtComplemento.Text, txtReferencia.Text, Convert.ToInt32(cmbClientes.ValueMember));
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
    }
}
