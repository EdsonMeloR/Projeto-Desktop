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
        
        private void FrmNotaTransporte_Load(object sender, EventArgs e)
        {

        }
    }
}
