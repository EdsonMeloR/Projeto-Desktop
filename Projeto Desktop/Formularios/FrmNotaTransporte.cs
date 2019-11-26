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
    public partial class FrmNotaTransporte : Form
    {
        Pedido p;
        public FrmNotaTransporte()
        {
            InitializeComponent();
        }
        public FrmNotaTransporte(Pedido pedido)
        {
            InitializeComponent();
            p = new Pedido();
            p = pedido;
        }
        Carga c;
        private void FrmNotaTransporte_Load(object sender, EventArgs e)
        {
            //Carregando cargas do Pedido e fazendo calculo de cubagem
            c = new Carga();
            txtIdPedido.Text = p.Id.ToString();
            DataTable dt = new DataTable();
            dt.Load(c.ListarCargasPedidoInnerDR(int.Parse(txtIdPedido.Text)));
            dgvCargasPedido.DataSource = dt;
            double CubagemCargas = new double();
            foreach (var Car in c.ListarCargasPedido(int.Parse(txtIdPedido.Text)))
            {
                CubagemCargas = Car.Largura * Car.Altura * Car.Comprimento;
            }
            txtCargasCubadas.Text = CubagemCargas.ToString();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnAdicionarCargasNota_Click(object sender, EventArgs e)
        {
            dgvCargasPedido.Rows.Remove(dgvCargasPedido.CurrentRow);

        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
