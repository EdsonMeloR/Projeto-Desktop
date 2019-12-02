using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Classes;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmEntrega : Form
    {
        Entrega en;
        public FrmEntrega()
        {
            InitializeComponent();
        }

        private void FrmEntrega_Load(object sender, EventArgs e)
        {
            en = new Entrega();
            cmbEntregas.ValueMember = "Id";
            cmbEntregas.DisplayMember = "Id";
            cmbEntregas.DataSource = en.ListarEntregas();
        }

        private void cmbEntregas_SelectedIndexChanged(object sender, EventArgs e)
        {
            en = new Entrega();
            en.ConsultarEntrega(Convert.ToInt32(cmbEntregas.SelectedValue));
            this.txtDataEntrega.Text = en.Data.ToString();
            this.txtIdNota.Text = en.IdNotaTransporte.Id.ToString();
            this.pcbAssinatura.Image = ByteToImage(en.Assinatura);
        }
        public Image ByteToImage(byte[] imageArray)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                return (Image)converter.ConvertFrom(imageArray);
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }
    }
}
