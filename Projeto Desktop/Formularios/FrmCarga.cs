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
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserirCarga_Click(object sender, EventArgs e)
        {
            carga = new Carga();
            carga.InserirCarga(Pedido.Id, Convert.ToDouble(mskPeso.Text), Convert.ToDouble(mskLargura.Text), Convert.ToDouble(mskAltura.Text), Convert.ToDouble(mskComprimento.Text), txtNomeProduto.Text, txtDetalhes.Text, Convert.ToInt32(cmbTiposCargas.SelectedValue), Convert.ToDouble(mskValorProduto.Text));
            if(carga.Id > 0)
            {
                MessageBox.Show("Carga inserido com sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao inserir a carga");
            }            
            dgvCargasPedido.Columns.Clear();
            dgvCargasPedido.Columns.Add("idPedido", "Pedido ID");
            dgvCargasPedido.Columns.Add("idCarga", "Carga ID");
            dgvCargasPedido.Columns.Add("nomeProduto", "Nome Produto");
            dgvCargasPedido.Columns.Add("pesoProduto", "Peso");
            dgvCargasPedido.Columns.Add("largura", "Largura");
            dgvCargasPedido.Columns.Add("altura", "Altura");
            dgvCargasPedido.Columns.Add("comprimento", "Comprimento");
            dgvCargasPedido.Columns.Add("valor", "Valor");
            dgvCargasPedido.Columns.Add("tipo", "Tipo");
            foreach (var car in carga.ListarCargasPedidoInner(Pedido.Id))
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvCargasPedido);
                item.Cells[0].Value = car.IdPedido.Id;
                item.Cells[1].Value = car.Id;
                item.Cells[2].Value = car.NomeProduto;
                item.Cells[3].Value = car.Peso;
                item.Cells[4].Value = car.Largura;
                item.Cells[5].Value = car.Altura;
                item.Cells[6].Value = car.Comprimento;
                item.Cells[7].Value = car.ValorProduto.ToString("C");
                item.Cells[8].Value = car.IdTipo.Nome;
                dgvCargasPedido.Rows.Add(item);
            }            
        }

        private void mskValorProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConsultarCargas_Click(object sender, EventArgs e)
        {
            carga = new Carga();
            tc = new TipoCarga();            
            carga.ConsultarCarga(Convert.ToInt32(txtIdCarga.Text));
            tc.ConsultarTipoCarga(carga.IdTipo.Id);
            txtIdCarga.Text = carga.Id.ToString();
            txtDetalhes.Text = carga.DetalhesProduto;
            txtNomeProduto.Text = carga.NomeProduto;
            mskAltura.Text = carga.Altura.ToString();
            mskComprimento.Text = carga.Comprimento.ToString();
            mskLargura.Text = carga.Largura.ToString();
            mskPeso.Text = carga.Peso.ToString();
            mskValorProduto.Text = carga.ValorProduto.ToString();
            cmbTiposCargas.Text = tc.Nome;
        }
    }
}
