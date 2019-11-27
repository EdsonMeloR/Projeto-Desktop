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
        Carga c;
        Motorista m;
        Veiculo v;
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
        private void FrmNotaTransporte_Load(object sender, EventArgs e)
        {
            //Carregando combo box de Motoristas
            m = new Motorista();
            var listaM = m.ListaMotoristas();
            cmbMotoristas.ValueMember = "IdMotorista";
            cmbMotoristas.DisplayMember = "Nome";
            cmbMotoristas.DataSource = listaM;
            cmbMotoristas.Text += listaM[cmbMotoristas.SelectedIndex].Rg;
            //Carregando combo box de Veiculos
            v = new Veiculo();
            var listaV = v.ListarVeiculos();            
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";
            cmbVeiculos.DataSource = listaV;
            cmbVeiculos.Text += listaV[cmbMotoristas.SelectedIndex].Placa;
            //Carregando cargas do Pedido e fazendo calculo de cubagem
            c = new Carga();
            txtIdPedido.Text = p.Id.ToString();            
            double CubagemCargas = new double();
            var lista = c.ListarCargasPedido(int.Parse(txtIdPedido.Text));
                            
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCargasPedido.Rows.Add();
                dgvCargasPedido.Rows[i].Cells[0].Value = lista[i].Id.ToString();
                dgvCargasPedido.Rows[i].Cells[1].Value = lista[i].NomeProduto;
                dgvCargasPedido.Rows[i].Cells[2].Value = lista[i].Quantidade.ToString();
                dgvCargasPedido.Rows[i].Cells[3].Value = lista[i].Peso.ToString();
                dgvCargasPedido.Rows[i].Cells[4].Value = lista[i].Largura.ToString();
                dgvCargasPedido.Rows[i].Cells[5].Value = lista[i].Altura.ToString();
                dgvCargasPedido.Rows[i].Cells[6].Value = lista[i].Comprimento.ToString();
                dgvCargasPedido.Rows[i].Cells[7].Value = lista[i].ValorProduto.ToString("C");                                
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
                c.Id = Convert.ToInt32(dgvCargasPedido.Rows[dgvCargasPedido.SelectedRows[i].Index].Cells[0].Value);
                listaSelecionada.Add(c);               
            }
            var a = dgvCargasPedido.SelectedRows;
            for (int i = 0; i < a.Count ; i++)
            {
                dgvCargasPedido.Rows.RemoveAt(a[i].Index);
            }
            for (int i = 0; i < listaSelecionada.Count; i++)
            {
                listaSelecionada[i].ConsultarCarga(listaSelecionada[i].Id); 
                dgvCargasAdicionadas.Rows.Add();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[0].Value = listaSelecionada[i].Id.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[1].Value = listaSelecionada[i].NomeProduto;
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[2].Value = listaSelecionada[i].Quantidade.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[3].Value = listaSelecionada[i].Peso.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[4].Value = listaSelecionada[i].Largura.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[5].Value = listaSelecionada[i].Altura.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[6].Value = listaSelecionada[i].Comprimento.ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[7].Value = listaSelecionada[i].ValorProduto.ToString("C");
                txtCargasCubadas.Text = (Convert.ToInt32(txtCargasCubadas.Text) + Convert.ToInt32(dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[2].Value) * (Convert.ToInt32(dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[4].Value) * Convert.ToInt32(dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[5].Value) * Convert.ToInt32(dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[6].Value))).ToString();
            }
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
