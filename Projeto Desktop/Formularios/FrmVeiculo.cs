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
    public partial class FrmVeiculo : Form
    {
        public FrmVeiculo()
        {
            InitializeComponent();
        }
        Veiculo v;
        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            v = new Veiculo();
            //Carrgando combo box de placas
            cmbPlacas.ValueMember = "Id";
            cmbPlacas.DisplayMember = "Placa";
            cmbPlacas.DataSource = v.ListarVeiculos();
        }

        private void cmbPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {
            v.ConsultarVeiculoId(Convert.ToInt32(cmbPlacas.SelectedValue));
            txtIdVeiculo.Text = v.Id.ToString();
            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            txtRenavam.Text = v.Renavam;
            mskAltura.Text = v.Altura.ToString();
            mskComprimento.Text = v.Comprimento.ToString();
            mskLargura.Text = v.Largura.ToString();
            mskPesoMaximo.Text = v.PesoMaximo.ToString();
            txtEixos.Text = v.Eixos.ToString();
            mskCustoPorKm.Text = v.CustoPorKm.ToString("C");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            v = new Veiculo();
            v.ConsultarVeiculoPlaca(cmbPlacas.Text);
            if(v.Id > 0)
            {
                MessageBox.Show("Placa já cadastrada no sistema");
                txtIdVeiculo.Text = v.Id.ToString();
                txtMarca.Text = v.Marca;
                txtModelo.Text = v.Modelo;
                txtRenavam.Text = v.Renavam;
                mskAltura.Text = v.Altura.ToString();
                mskComprimento.Text = v.Comprimento.ToString();
                mskLargura.Text = v.Largura.ToString();
                mskPesoMaximo.Text = v.PesoMaximo.ToString();
            }
            else
            {
                try
                {
                    v.InserirVeiculo(cmbPlacas.Text, txtMarca.Text, txtModelo.Text, txtRenavam.Text, Convert.ToDouble(mskPesoMaximo.Text), Convert.ToDouble(mskAltura.Text), Convert.ToDouble(mskLargura.Text), Convert.ToDouble(mskComprimento.Text), Convert.ToInt32(txtEixos.Text),Convert.ToDouble(mskCustoPorKm.Text));
                    if (v.Id > 0)
                    {
                        txtIdVeiculo.Text = v.Id.ToString();
                        MessageBox.Show("Inserido com sucesso !");
                    }
                    else if (cmbPlacas.Text == string.Empty)
                        MessageBox.Show("É necessário inserir uma placa");
                    else if (txtEixos.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir a quantidade de eixos");
                    }
                    else if (txtMarca.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir a marca do veiculo");
                    }
                    else if (txtModelo.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir o modelo do veiculo");
                    }
                    else if (txtRenavam.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir o renavam do veiculo");
                    }
                    else if (mskAltura.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir a altura do veiculo");
                    }
                    else if (mskComprimento.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir o comprimento do veiculo");
                    }
                    else if (mskLargura.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir a largura do veiculo");
                    }
                    else if (mskPesoMaximo.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir o peso maximo");
                    }
                    else if(mskCustoPorKm.Text == string.Empty)
                    {
                        MessageBox.Show("É necessário inserir o Custo por Km");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }                    
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            v = new Veiculo();
            dgvVeiculos.DataSource = v.ListarVeiculos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            v = new Veiculo();
            if(Convert.ToInt32(cmbPlacas.SelectedValue) > 0 && mskPesoMaximo.Text != string.Empty && mskLargura.Text != string.Empty && mskComprimento.Text != string.Empty && mskAltura.Text != string.Empty)
            {
                if (v.AlterarVeiculo(Convert.ToInt32(cmbPlacas.SelectedValue), Convert.ToDouble(mskPesoMaximo.Text), Convert.ToDouble(mskAltura.Text), Convert.ToDouble(mskLargura.Text), Convert.ToDouble(mskComprimento.Text)))
                {
                    MessageBox.Show("Alterado com sucesso ");
                    btnListar_Click(this, null);
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos\nPlacas\nPeso\nAltura\nLargura\nComprimento ");
            }
        }
    }
}
