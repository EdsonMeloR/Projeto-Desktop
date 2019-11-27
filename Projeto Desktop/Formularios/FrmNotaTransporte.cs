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
            double CubagemCargas = new double();
            var lista = c.ListarCargasPedido(int.Parse(txtIdPedido.Text));
            foreach (var Car in lista)
            {
                dgvCargasPedido.Rows.Add();
                for (int i = 0; i < lista.Count; i++)
                {                    
                    dgvCargasPedido.Rows[i].Cells[0].Value = Car.Id.ToString();
                    dgvCargasPedido.Rows[i].Cells[1].Value = Car.NomeProduto;
                    dgvCargasPedido.Rows[i].Cells[2].Value = Car.Quantidade.ToString();
                    dgvCargasPedido.Rows[i].Cells[3].Value = Car.Peso.ToString();
                    dgvCargasPedido.Rows[i].Cells[4].Value = Car.Largura.ToString();
                    dgvCargasPedido.Rows[i].Cells[5].Value = Car.Altura.ToString();
                    dgvCargasPedido.Rows[i].Cells[6].Value = Car.Comprimento.ToString();
                    dgvCargasPedido.Rows[i].Cells[7].Value = Car.ValorProduto.ToString("C");
                }                
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
            List<Carga> listaSelecionada = new List<Carga>();
            for (int i = 0; i < dgvCargasPedido.SelectedRows.Count; i++)
            {
                Carga c = new Carga();
                c.Id = Convert.ToInt32(dgvCargasPedido.Rows[dgvCargasPedido.CurrentRow.Index].Cells[0].Value);
                listaSelecionada.Add(c);                
            }
            dgvCargasPedido.Rows.Remove(dgvCargasPedido.CurrentRow);
            foreach (var Car in listaSelecionada)
            {
                Car.ConsultarCarga(Car.Id);
                for (int i = 0; i < listaSelecionada.Count; i++)
                {
                    dgvCargasAdicionadas.Rows.Add();
                    dgvCargasAdicionadas.Rows[i].Cells[0].Value = Car.Id.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[1].Value = Car.NomeProduto;
                    dgvCargasAdicionadas.Rows[i].Cells[2].Value = Car.Quantidade.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[3].Value = Car.Peso.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[4].Value = Car.Largura.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[5].Value = Car.Altura.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[6].Value = Car.Comprimento.ToString();
                    dgvCargasAdicionadas.Rows[i].Cells[7].Value = Car.ValorProduto.ToString("C");
                }
            }
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
