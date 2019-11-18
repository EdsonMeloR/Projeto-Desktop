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
using Projeto_Desktop.Formularios;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmClienteAlterar : Form
    {
        Cliente c;
        public FrmClienteAlterar()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            c = new Cliente();
            if (c.AlterarCliente(Convert.ToInt32(txtIdCliente.Text), txtTelefone.Text, txtNomeContato.Text, txtEmail.Text, txtRazaoSocial.Text))
                MessageBox.Show("cliente alterado com sucesso");
            else
                MessageBox.Show("Falha ao alterar", "Erro");
        }
    }
}
