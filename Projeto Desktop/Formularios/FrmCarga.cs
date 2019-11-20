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
    public partial class FrmCarga : Form
    {
        private Pedido pedido;
        public FrmCarga(Pedido p)
        {
            pedido = p;
            InitializeComponent();
        }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        Carga carga;
        TipoCarga tc;
        private void FrmCarga_Load(object sender, EventArgs e)
        {
            carga = new Carga();
            tc = new TipoCarga();
            cmbTiposCargas.DisplayMember = "Nome";
            cmbTiposCargas.ValueMember = "Id";
            cmbTiposCargas.DataSource = tc.ListarTiposCargas();
            txtIdPedido.Text = Pedido.Id.ToString();
            dgvCargasPedido.DataSource = carga.ListarCargasPedido(Pedido.Id);
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserirCarga_Click(object sender, EventArgs e)
        {
            carga = new Carga();
            dgvCargasPedido.DataSource = carga.ListarCargasPedido(Pedido.Id);
        }
    }
}
