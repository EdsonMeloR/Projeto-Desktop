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
    public partial class FrmMotorista : Form
    {
        public FrmMotorista()
        {
            InitializeComponent();
        }
        Motorista m;
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CarregarCmbMotorista()
        {
            //Carregando combo box de motoristas
            m = new Motorista();
            cmbCaminhoneiros.ValueMember = "IdMotorista";
            cmbCaminhoneiros.DisplayMember = "Nome";
            cmbCaminhoneiros.DataSource = m.ListaMotoristas();
        }
        private void FrmMotorista_Load(object sender, EventArgs e)
        {
            CarregarCmbMotorista();
        }

        private void cmbCaminhoneiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            m = new Motorista();
            m.ConsultarMotorista(Convert.ToInt32(cmbCaminhoneiros.SelectedValue));
            txtCnh.Text = m.Cnh;
            txtIdMotorista.Text = m.IdMotorista.ToString();
            txtRg.Text = m.Rg;
            mskCpf.Text = m.Cpf;
            mskValidadeCnh.Text = m.ValidadeCnh.ToString();
            cmbCategoriasCnh.Text = m.CategoriaCnh;            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            m = new Motorista();
            m.ConsultarMotorista(txtCnh.Text);
            if(m.IdMotorista > 0)
            {
                MessageBox.Show("Motorista " + m.Nome + " Já cadastrado\n Com esta CNH");
            }    
            else
            {
                m = new Motorista();
                if (cmbCaminhoneiros.Text != string.Empty && mskCpf.Text != string.Empty && mskValidadeCnh.Text != string.Empty && txtCnh.Text != string.Empty && txtRg.Text != string.Empty && cmbCategoriasCnh.Text != string.Empty)
                {
                    var senha = cmbCaminhoneiros.Text.Substring(0, cmbCaminhoneiros.Text.IndexOf(" ", 1));
                    m.InserirMotorista(cmbCaminhoneiros.Text, mskCpf.Text.Replace("-",""), txtRg.Text, txtCnh.Text, Convert.ToDateTime(mskValidadeCnh.Text), cmbCategoriasCnh.Text, senha.ToLower(), true);
                    if (m.IdMotorista > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        MessageBox.Show("Será necessário modificar a senha em seu 1° Acesso\nSenha é definidada como seu primeiro nome automaticamente", "Inserido");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário preencher todos os campos");
                }
            }
            CarregarCmbMotorista();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            m = new Motorista();
            dgvMotoristas.DataSource = m.ListaMotoristas();
            CarregarCmbMotorista();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            m = new Motorista();
            if(mskValidadeCnh.Text != string.Empty && cmbCategoriasCnh.Text != string.Empty && txtIdMotorista.Text != string.Empty)
            {
                if(m.AlterarMotorista(Convert.ToDateTime(mskValidadeCnh.Text), cmbCategoriasCnh.Text, Convert.ToInt32(txtIdMotorista.Text)))
                {
                    MessageBox.Show("Alterado com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar");
                }
                
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
            CarregarCmbMotorista();
        }
    }
}
