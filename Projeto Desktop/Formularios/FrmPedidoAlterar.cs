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
    public partial class FrmPedidoAlterar : Form
    {
        public FrmPedidoAlterar()
        {
            InitializeComponent();
        }
        Cliente cli;
        Pedido Ped;
        Usuario User;
        PedidosEnderecos PedEnd;
        private void FrmPedidoAlterar_Load(object sender, EventArgs e)
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
        
        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            Ped = new Pedido();
            if(Convert.ToInt32(cmbPedidos.SelectedValue) > 0 && cmbSituacao.Text != string.Empty)
            {
                if(cmbSituacao.Text != "Finalizado")
                {
                    if (Ped.AlterarPedido(cmbSituacao.Text, Convert.ToInt32(cmbPedidos.SelectedValue)))
                    {
                        MessageBox.Show("Status alterado com sucesso !!");
                    }
                    else
                    {
                        MessageBox.Show("Status não pode ser alterado !!");
                    }
                }
                else
                {
                    MessageBox.Show("Status não pode ser alterado !!\nNão é possivel alterar um pedido já finalizado");
                }                
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void cmbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarComboBoxPedido();
            btnListarPedidos.Enabled = true;
            grpPedidos.Enabled = true;
        }

        private void cmbPedidos_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            btnListarCargasPedido.Enabled = true;
            //Listando endereço de destino do pedido
            PedEnd = new PedidosEnderecos();
            TipoEndereco te = new TipoEndereco();
            te.ConsultarTipoEnderecoNome("Destinatário");
            PedEnd.ConsultarEnderecoDestinarioPedido(Convert.ToInt32(cmbPedidos.SelectedValue), te.Id);
            Endereco end = new Endereco();
            end.ConsultarEndereco(Convert.ToInt32(cmbClientes.SelectedValue), PedEnd.IdEndereco.Id);
            if (end.Id > 0)
            {
                cmbEnderecoDestino.Text = end.Logradouro + ", " + end.Cep + ", N° " + end.Numero;
            }
            //Listando endereço de envio do pedido            
            te = new TipoEndereco();
            te.ConsultarTipoEnderecoNome("Remetente");
            //Consultando endereço Pedido
            PedEnd.ConsultarEnderecoDestinarioPedido(Convert.ToInt32(cmbPedidos.SelectedValue), te.Id);
            end = new Endereco();
            end.ConsultarEndereco(Convert.ToInt32(cmbClientes.SelectedValue), PedEnd.IdEndereco.Id);
            if (end.Id > 0)
            {
                cmbEnderecoRemetente.Text = end.Logradouro + ", " + end.Cep + ", N° " + end.Numero;
            }
            Ped = new Pedido();
            Ped.ConsultarPedido(Convert.ToInt32(cmbPedidos.SelectedValue));
            cmbDataPedido.Text = Ped.DataPedido.ToString();
            cmbSituacao.Text = Ped.Situacao;
            //Consultando usuario
            Usuario u = new Usuario();
            u.ConsultarUsuario(Ped.IdUsuario.Id);
            cmbUsuario.Text = u.Nome;
        }

        private void btnListarPedidos_Click_1(object sender, EventArgs e)
        {
            Ped = new Pedido();
            dgvPedidosCargas.DataSource = Ped.ConsultarPedidosCliente(Convert.ToInt32(cmbClientes.SelectedValue));
        }

        private void btnListarCargasPedido_Click(object sender, EventArgs e)
        {
            Carga c = new Carga();
            dgvPedidosCargas.DataSource = c.ListarCargasPedidoInner(Convert.ToInt32(cmbPedidos.SelectedValue));
            dgvPedidosCargas.AutoResizeColumns();
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
