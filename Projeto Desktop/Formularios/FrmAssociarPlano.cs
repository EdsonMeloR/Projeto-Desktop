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
    public partial class FrmAssociarPlano : Form
    {
        public FrmAssociarPlano()
        {
            InitializeComponent();
        }
        Cliente c;
        Plano p;
        PlanoCliente pc;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorPlano_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAssociarPlano_Load(object sender, EventArgs e)
        {
            //Carregando combo box de Planos
            c = new Cliente();
            cmbClientes.ValueMember = "Id";
            cmbClientes.DisplayMember = "RazaoSocial";
            cmbClientes.DataSource = c.ListarCliente();
            //Carregando combo box de Clientes
            p = new Plano();
            cmbPlanos.ValueMember = "Id";
            cmbPlanos.DisplayMember = "NomePlano";
            cmbPlanos.DataSource = p.ListarPlanos();
        }

        private void cmbPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = new Plano();
            p.ConsultarPlanoId(Convert.ToInt32(cmbPlanos.SelectedValue));
            txtDescricaoPlano.Text = p.DescricaoPlano;
            txtDuracaoPlano.Text = p.DuracaoPlano.ToString();
            txtLimitePedidos.Text = p.LimitePedido.ToString();
            txtNomePlano.Text = p.NomePlano;
            txtValorPlano.Text = p.ValorPlano.ToString("C");
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            pc.ConsultarPlanoClienteAtivo(Convert.ToInt32(cmbClientes.SelectedValue));
            if(pc.Id > 0)
            {
                if(DialogResult.Yes == MessageBox.Show("O cliente " + cmbClientes.Text + " já possui um plano ativo\nDeseja alterar de plano?","Plano já associado",MessageBoxButtons.YesNo))
                {
                    FrmAssociarPlanoAlterar frm = new FrmAssociarPlanoAlterar();
                    frm.Show();
                }
            }
        }

        private void btnConsultarPlano_Click(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            pc.ConsultarPlanoClienteIdCliente(Convert.ToInt32(cmbClientes.SelectedValue));
            mskDataTerminoPlano.Text = pc.DataTermino.ToString();
            mskDataInicioPlano.Text = pc.DataInicio.ToString();
            txtDescontoPlano.Text = pc.Desconto.ToString("C");
            p = new Plano();
            p.ConsultarPlanoId(pc.IdPlano.Id);
            cmbPlanos.SelectedValue = p.Id;
            txtDescricaoPlano.Text = p.DescricaoPlano;
            txtDuracaoPlano.Text = p.DuracaoPlano.ToString();
            txtLimitePedidos.Text = p.LimitePedido.ToString();
            txtNomePlano.Text = p.NomePlano;
            txtValorPlano.Text = p.ValorPlano.ToString("C");
        }

        private void btnAssociarPlano_Click(object sender, EventArgs e)
        {
            pc = new PlanoCliente();
            var a = Convert.ToDateTime(mskDataInicioPlano.Text);
            a = a.AddMonths(Convert.ToInt32(txtDuracaoPlano.Text));
            pc.ConsultarPlanoClienteIdCliente(Convert.ToInt32(cmbClientes.SelectedValue));
            if (pc.Id > 0 && DateTime.Now < pc.DataTermino)
            {                
                if(DialogResult.Yes == MessageBox.Show("Plano não pode ser associado ao cliente "+cmbClientes.Text+ ".\n Já existe um plano associado ao cliente, deseja alterar?","Plano já associado",MessageBoxButtons.YesNo))
                {
                    FrmAssociarPlanoAlterar frm = new FrmAssociarPlanoAlterar();
                    frm.Show();
                }                
            }
            if(Convert.ToDateTime(mskDataInicioPlano.Text) >= DateTime.Now && Convert.ToDouble(txtDescontoPlano.Text) > 0 && Convert.ToInt32(cmbPlanos.SelectedValue) > 0)
            {
                pc.AssociarPlanoCliente(Convert.ToDateTime(mskDataInicioPlano.Text), a, Convert.ToDouble(txtDescontoPlano.Text), Convert.ToInt32(cmbClientes.SelectedValue), Convert.ToInt32(cmbPlanos.SelectedValue));
                if (pc.Id > 0)
                {
                    MessageBox.Show("Plano associado com sucesso !!");
                    mskDataTerminoPlano.Text = a.ToString();
                }                    
                else
                {
                    MessageBox.Show("Erro ao associar plano ao cliente !!");
                }                    
            }
            else
            {
                MessageBox.Show("Preencha os campos data Inicio e Desconto e selecione um plano");
            }
        }

        private void btnAlterarPlanoCliente_Click(object sender, EventArgs e)
        {
            FrmAssociarPlanoAlterar frm = new FrmAssociarPlanoAlterar();
            frm.Show();
        }

        private void btnCriarPlanoPeronalizado_Click(object sender, EventArgs e)
        {

        }
    }
}
