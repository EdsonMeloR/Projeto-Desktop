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
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }
        Niveis n;
        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = new Niveis();
            n.ConsultarNivel(Convert.ToInt32(cmbNivel.SelectedValue));
            txtIdNivel.Text = n.IdNivel.ToString();
        }
        
        private void FrmNivel_Load(object sender, EventArgs e)
        {
            n = new Niveis();
            cmbNivel.ValueMember = "IdNivel";
            cmbNivel.DisplayMember = "NomeNivel";
            cmbNivel.DataSource = n.ListarNiveis();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            n = new Niveis();
            dgvNiveis.DataSource = n.ListarNiveis();
        }
    }
}
