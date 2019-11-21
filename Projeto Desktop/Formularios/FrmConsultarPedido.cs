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
    public partial class FrmConsultarPedido : Form
    {
        public FrmConsultarPedido()
        {
            InitializeComponent();
        }
        Cliente cli;
        Pedido Ped;
        Usuario User;
        PedidosEnderecos PedEnd;
        private void FrmConsultarPedido_Load(object sender, EventArgs e)
        {
            //Carregando Combo box com clientes
            CarregarComboBoxClientes();
        }
        private void CarregarComboBoxPedido()
        {
            //Carregando Combo box com Pedidos do cliente
            Ped = new Pedido();
            cmbPedidos.DisplayMember = "Id";
            cmbPedidos.ValueMember = "Id";
            List<Pedido> lista = new List<Pedido>();
            lista = Ped.ConsultarPedidosCliente(Convert.ToInt32(cmbClientes.SelectedValue));
            cmbPedidos.DataSource = lista;
        }
        private void CarregarComboBoxClientes()
        {
            cli = new Cliente();
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.ValueMember = "Id";
            cmbClientes.DataSource = cli.ListarCliente();
        }
        private void CarregarComboBoxUsuario()
        {
            //Carregando combo box de Usuarios
            User = new Usuario();
            Ped.ConsultarPedido(Convert.ToInt32(cmbPedidos.SelectedValue));
            User.ConsultarUsuario(Ped.IdUsuario.Id);
            cmbUsuario.Text = User.Nome;
        }
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboBoxPedido();
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ped = new Pedido();
            Ped.ConsultarPedido(Convert.ToInt32(cmbPedidos.SelectedValue));
            PedEnd.ListarPedidoEndereco();
            txtEnderecoDestino.Text = Ped.
            CarregarComboBoxUsuario();            
        }
    }
}
