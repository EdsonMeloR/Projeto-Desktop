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
    public partial class FrmNovoPedido : Form
    {
        public FrmNovoPedido()
        {
            InitializeComponent();
        }
        
        private void FrmPedido_Load(object sender, EventArgs e)
        {
            string[] teste = new string[3];
            teste[0] = "Aberto";
            teste[1] = "Em Progesso";
            teste[2] = "Finalizado";
            for (var i = 0; i < teste.Count(); i++)
            {
                cmbSituacao.Items.Add(teste[i]);
            }
            Cliente c = new Cliente();
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.ValueMember = "Id";
            cmbClientes.DataSource = c.ListarCliente();            
            cmbClientes.SelectedIndex = 0;
            Usuario u = new Usuario();
            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.DataSource = u.ListarUsuarios();                   
            Endereco en = new Endereco();
            cmbEnderecoDestino.DisplayMember = "Logradouro";
            cmbEnderecoDestino.ValueMember = "Id";
            cmbEnderecoDestino.DataSource = en.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue));
            en = new Endereco();
            cmbEnderecoRemetente.DisplayMember = "Logradouro";
            cmbEnderecoRemetente.ValueMember = "Id";
            cmbEnderecoRemetente.DataSource = en.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue));            
        }

        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {
            PedidosEnderecos pe = new PedidosEnderecos();
            TipoEndereco te = new TipoEndereco();
            te.ConsultarTipoEnderecoNome("Remetente");
            pe.InserirPedidoEndereco(Convert.ToInt32(cmbEnderecoDestino.SelectedValue), Convert.ToInt32(txtIdPedido.Text), te.Id);
            if(pe.Id > 0)
            {
                MessageBox.Show("Endereço de remetente inserido com sucesso !!");
                grbEnderecosRemetente.Enabled = false;
                grbEnderecoDestino.Enabled = true;
            }
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Endereco en = new Endereco();
            if(en.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue)).Count < 2)
            {
                var result = MessageBox.Show("É necessário que o cliente tenha mais de dois endereços \n Deseja cadastrar um novo endereço?","Erro",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    FrmEnderecos frm = new FrmEnderecos();
                    frm.Show();
                }
            }
            else
            {
                cmbEnderecoDestino.DisplayMember = "Logradouro";
                cmbEnderecoDestino.ValueMember = "Id";
                cmbEnderecoDestino.DataSource = en.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue));
                cmbEnderecoRemetente.DisplayMember = "Logradouro";
                cmbEnderecoRemetente.ValueMember = "Id";
                cmbEnderecoRemetente.DataSource = en.ListarEnderecosCliente(Convert.ToInt32(cmbClientes.SelectedValue));
            }
        }

        private void cmbEnderecoRemetente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Endereco en = new Endereco();
            en.ConsultarEndereco(Convert.ToInt32(cmbClientes.SelectedValue), Convert.ToInt32(cmbEnderecoRemetente.SelectedValue));
            txtLogradouro.Text = en.Logradouro;
            txtCep.Text = en.Cep;
            txtNumero.Text = en.Numero.ToString();
            txtComplemento.Text = en.Complemento;
            txtReferencia.Text = en.Referencia;                
        }

        private void cmbEnderecoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            Endereco en = new Endereco();
            en.ConsultarEndereco(Convert.ToInt32(cmbClientes.SelectedValue), Convert.ToInt32(cmbEnderecoDestino.SelectedValue));
            txtLogradouroDestino.Text = en.Logradouro;
            txtCepDestino.Text = en.Cep;
            txtNumeroDestino.Text = en.Numero.ToString();
            txtComplementoDestino.Text = en.Complemento;
            txtReferenciaDestino.Text = en.Referencia;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            if(cmbSituacao.Text != string.Empty && Convert.ToInt32(cmbUsuario.SelectedValue) != 0 && Convert.ToInt32(cmbClientes.SelectedValue) != 0)
            {
                p.InserirPedido(cmbSituacao.Text, chkRetirar.Checked, Convert.ToInt32(cmbUsuario.SelectedValue), Convert.ToInt32(cmbClientes.SelectedValue));
                mskDataPedido.Text = p.DataPedido.ToString();
                txtIdPedido.Text = p.Id.ToString();
                grbEnderecosRemetente.Enabled = true;
                grbEnderecoDestino.Enabled = false;
                cmbClientes.Enabled = false;
            } 
            else
            {
                MessageBox.Show("É necessários preencher todos os campos ");
            }
        }

        private void btnAdicionarEnderecoDestino_Click(object sender, EventArgs e)
        {               
            if(cmbEnderecoRemetente.SelectedValue.ToString() == cmbEnderecoDestino.SelectedValue.ToString())
            {
                MessageBox.Show("Os endereços devem ser diferentes");
            }
            else
            {
                PedidosEnderecos pe = new PedidosEnderecos();
                TipoEndereco te = new TipoEndereco();
                te.ConsultarTipoEnderecoNome("Destinatário");
                pe.InserirPedidoEndereco(Convert.ToInt32(cmbEnderecoDestino.SelectedValue), Convert.ToInt32(txtIdPedido.Text), te.Id);
                if (pe.Id > 0)
                {
                    MessageBox.Show("Endereço de Destino inserido com sucesso !!");
                    grbEnderecoDestino.Enabled = false;
                    btnAdicionarCargas.Enabled = true;
                }
            }
        }

        private void btnAdicionarCargas_Click(object sender, EventArgs e)                       
        {
            Usuario user = new Usuario { Id = Convert.ToInt32(cmbUsuario.SelectedValue) };
            Cliente c = new Cliente { Id = Convert.ToInt32(cmbClientes.SelectedValue) };
            Pedido PedidoFinalizado = new Pedido(Convert.ToInt32(txtIdPedido.Text), cmbSituacao.Text,
            Convert.ToDateTime(mskDataPedido.Text), chkRetirar.Checked, user, c);
            FrmCarga frm = new FrmCarga(PedidoFinalizado);
            this.Hide();
            frm.Show();
        }
    }
}
