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
    public partial class FrmPlanoConsultar : Form
    {
        public FrmPlanoConsultar()
        {
            InitializeComponent();
        }
        Plano p;
        private void cmbPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.ConsultarPlanoId(Convert.ToInt32(cmbPlanos.SelectedValue));
            txtDescricao.Text = p.DescricaoPlano;
            txtDuracaoPlano.Text = p.DuracaoPlano.ToString();
            txtId.Text = p.Id.ToString();
            txtLimitePedidos.Text = p.LimitePedido.ToString();
            txtValor.Text = p.ValorPlano.ToString("C");
            cmbPlanos.Text = p.NomePlano;
        }

        private void FrmPlanoConsultar_Load(object sender, EventArgs e)
        {
            p = new Plano();
            cmbPlanos.ValueMember = "Id";
            cmbPlanos.DisplayMember = "NomePlano";
            cmbPlanos.DataSource = p.ListarPlanos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            p = new Plano();
            dgvListarPlanos.DataSource = p.ListarPlanos();
        }
    }
}
