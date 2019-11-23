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
    public partial class FrmClienteConsultar : Form
    {
        public FrmClienteConsultar()
        {
            InitializeComponent();
        }
        Cliente c;
        private void FrmClienteConsultar_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.ValueMember = "Id";
            cmbClientes.DataSource = c.ListarCliente();            
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            c = new Cliente();
            dgvClientes.DataSource = c.ListarCliente();
        }
    }
}
