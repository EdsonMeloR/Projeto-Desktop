﻿using System;
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
        TipoFrete tf;
        NotaTransporte nt;
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
            if(txtIdPedido.Text != string.Empty)
            {
                tf = new TipoFrete();
                grbNotaTransporte.Enabled = true;
                cmbTiposFretes.ValueMember = "Id";
                cmbTiposFretes.DisplayMember = "Nome";
                cmbTiposFretes.DataSource = tf.ListarTiposFretes();

            }
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
            var lista = c.ListarCargasPedido(int.Parse(txtIdPedido.Text));
                            
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCargasPedido.Rows.Add();
                dgvCargasPedido.Rows[i].Cells[0].Value = lista[i].Id.ToString();
                dgvCargasPedido.Rows[i].Cells[1].Value = lista[i].NomeProduto;
                dgvCargasPedido.Rows[i].Cells[2].Value = lista[i].Quantidade.ToString();
                dgvCargasPedido.Rows[i].Cells[3].Value = lista[i].Peso.ToString();
                dgvCargasPedido.Rows[i].Cells[4].Value = (lista[i].Largura * lista[i].Altura * lista[i].Comprimento).ToString();
                dgvCargasPedido.Rows[i].Cells[5].Value = lista[i].ValorProduto.ToString("C");                                
            }
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
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[4].Value = (listaSelecionada[i].Largura * listaSelecionada[i].Altura * listaSelecionada[i].Comprimento).ToString();
                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[5].Value = listaSelecionada[i].ValorProduto.ToString("C");
            }
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpGerarNotaTransporte_Enter(object sender, EventArgs e)
        {

        }

        private void btnGerarNotaTransporte_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbTiposFretes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarNotaTransporte_Click_1(object sender, EventArgs e)
        {
            nt = new NotaTransporte();
            try
            {
                if (Convert.ToInt32(cmbTiposFretes.SelectedValue) > 0 && Convert.ToInt32(cmbMotoristas.SelectedValue) > 0 && Convert.ToInt32(cmbVeiculos.SelectedValue) > 0 && txtDistancia.Text != string.Empty && txtValorFrete.Text != string.Empty && txtValorPedagios.Text != string.Empty && txtObservacoes.Text != string.Empty)
                {
                    nt.InserirNotaTransporte(Convert.ToInt32(cmbVeiculos.SelectedValue), Convert.ToInt32(cmbMotoristas.SelectedValue), Convert.ToInt32(cmbTiposFretes.SelectedValue), txtObservacoes.Text, Convert.ToDouble(txtValorFrete.Text), Convert.ToDouble(txtDistancia.Text));
                    if(nt.Id > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso !");
                        grbCargasPedido.Enabled = true;
                        grbGerarNotaTransporte.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar !");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário preencher todos os campos !!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Erro");
            }            
        }
    }
}
