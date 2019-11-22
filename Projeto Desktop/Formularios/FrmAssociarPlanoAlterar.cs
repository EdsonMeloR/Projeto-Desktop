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
    public partial class FrmAssociarPlanoAlterar : Form
    {
        public FrmAssociarPlanoAlterar()
        {
            InitializeComponent();
        }
        Plano p;
        Cliente c;
        PlanoCliente pc;
        private void button1_Click(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            var a = Convert.ToDateTime(mskDataInicioAtualizar.Text);
            a = a.AddMonths(Convert.ToInt32(txtDuracaoPlanoAlterar.Text));
            if (mskDataInicioAtualizar.Text != string.Empty && txtDescontoAtualizar.Text != string.Empty)
            {            
                if (pc.AlterarPlanoAssociado(Convert.ToInt32(txtIdPlanoClienteAssociado.Text), Convert.ToInt32(cmbPlanosAtualizar.SelectedValue),
                Convert.ToInt32(cmbClientes.SelectedValue), Convert.ToDateTime(mskDataInicioAtualizar.Text), a, Convert.ToDouble(txtDescontoAtualizar.Text)))
                {
                    MessageBox.Show("Plano alterado com sucesso", "Sucesso");
                }            
                else
                {
                    MessageBox.Show("Falha ao alterar o plano", "Erro");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro");
            }
        }

        private void FrmAssociarPlanoAlterar_Load(object sender, EventArgs e)
        {
            //Carregando combo box de Planos
            c = new Cliente();
            cmbClientes.ValueMember = "Id";
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.DataSource = c.ListarCliente();
            //Carregando combo box de Clientes
            p = new Plano();
            cmbPlanosAtualizar.ValueMember = "Id";
            cmbPlanosAtualizar.DisplayMember = "NomePlano";
            cmbPlanosAtualizar.DataSource = p.ListarPlanos();
        }

        private void btnConsultarPlano_Click(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            pc.ConsultarPlanoClienteAtivo(Convert.ToInt32(cmbClientes.SelectedValue));
            p = new Plano();
            p.ConsultarPlanoId(pc.IdPlano.Id);
            txtNomePlano.Text = p.NomePlano;
            txtDuracaoPlano.Text = p.DuracaoPlano.ToString();
            txtValorPlano.Text = p.ValorPlano.ToString("C");
            txtLimitePedidos.Text = p.LimitePedido.ToString();
            txtDescricaoPlano.Text = p.DescricaoPlano.ToString();
            mskDataInicioPlano.Text = pc.DataInicio.ToString();
            mskDataTerminoPlano.Text = pc.DataTermino.ToString();
            txtDescontoPlano.Text = pc.Desconto.ToString("C");
            txtIdPlanoClienteAssociado.Text = pc.Id.ToString();
            grpAtualizarPlano.Enabled = true;
            if (txtIdPlanoClienteAssociado.Text != string.Empty)
            {
                btnAtualizarPlano.Enabled = true;
                grpAlterarPlano.Enabled = true;
                txtDescontoPlano.Enabled = true;
            }
            else
            {
                if(DialogResult.Yes ==  MessageBox.Show("Nenhum plano ativo foi encontrado\nDeseja associar um novo plano?","Plano não encontrado",MessageBoxButtons.YesNo))
                {
                    FrmAssociarPlano frm = new FrmAssociarPlano();
                    frm.Show();
                }
            }
        }

        private void cmbPlanosAtualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = new Plano();
            p.ConsultarPlanoId(Convert.ToInt32(cmbPlanosAtualizar.SelectedValue));
            txtNomeAtualizar.Text = p.NomePlano;
            txtDuracaoPlanoAlterar.Text = p.DuracaoPlano.ToString();
            txtValorPlanoAlterar.Text = p.ValorPlano.ToString("C");
            txtLimitePedidoAlterar.Text = p.LimitePedido.ToString();
            txtDescricaoPlanoAtualizar.Text = p.DescricaoPlano.ToString();
        }

        private void btnAtualizarPlano_Click(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            pc.AlterarPlanoCliente(Convert.ToInt32(txtIdPlanoClienteAssociado.Text), Convert.ToDouble(txtDescontoPlano.Text));
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cmbClientes.SelectedValue) > 0)
            {
                btnConsultarPlano.Enabled = true;
            }
        }
    }
}
