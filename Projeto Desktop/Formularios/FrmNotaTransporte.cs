using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Classes;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
        ItensNotaTransporte ints;
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
            try
            {
                tf = new TipoFrete();
                cmbTiposFretes.ValueMember = "Id";
                cmbTiposFretes.DisplayMember = "Nome";
                cmbTiposFretes.DataSource = tf.ListarTiposFretes();
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
                txtIdPedido.Text = p.Id.ToString();
                //Listando cargas do pedido
                c = new Carga();
                var lista = c.ListarCargasPedido(int.Parse(txtIdPedido.Text));
                //Listando cargas já associadas a nota de transporte
                ints = new ItensNotaTransporte();
                var itensAssociados = ints.ListarItensNotaTransportePedido(Convert.ToInt32(txtIdPedido.Text));
                for (int i = 0; i < lista.Count; i++)
                {
                    if (itensAssociados.Count > 0)
                    {
                        foreach (var item in itensAssociados)
                        {
                            if (item.IdCarga.Id == lista[i].Id)
                            {
                                lista[i].ConsultarCarga(lista[i].Id);
                                dgvCargasAdicionadas.Rows.Add();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[0].Value = lista[i].Id.ToString();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[1].Value = lista[i].NomeProduto;
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[2].Value = lista[i].Quantidade.ToString();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[3].Value = lista[i].Peso.ToString();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[4].Value = lista[i].Largura.ToString() + " * " + lista[i].Altura.ToString() + " * " + lista[i].Comprimento.ToString();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[5].Value = (lista[i].Largura * lista[i].Altura * lista[i].Comprimento).ToString();
                                dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[6].Value = lista[i].ValorProduto.ToString("C");
                            }                         
                        }
                    }
                    else
                    {
                        dgvCargasPedido.Rows.Add();
                        dgvCargasPedido.Rows[i].Cells[0].Value = lista[i].Id.ToString();
                        dgvCargasPedido.Rows[i].Cells[1].Value = lista[i].NomeProduto;
                        dgvCargasPedido.Rows[i].Cells[2].Value = lista[i].Quantidade.ToString();
                        dgvCargasPedido.Rows[i].Cells[3].Value = lista[i].Peso.ToString();
                        dgvCargasPedido.Rows[i].Cells[4].Value = lista[i].Largura.ToString() + " * " + lista[i].Altura.ToString() + " * " + lista[i].Comprimento.ToString();
                        dgvCargasPedido.Rows[i].Cells[5].Value = (lista[i].Largura * lista[i].Altura * lista[i].Comprimento).ToString();
                        dgvCargasPedido.Rows[i].Cells[6].Value = lista[i].ValorProduto.ToString("C");
                    }
                }
            }      
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnAdicionarCargasNota_Click(object sender, EventArgs e)
        {
            try
            {
                List<Carga> listaSelecionada = new List<Carga>();
                v.ConsultarVeiculoId(Convert.ToInt32(cmbVeiculos.SelectedValue));
                for (int i = 0; i < dgvCargasPedido.SelectedRows.Count; i++)
                {
                    Carga c = new Carga();
                    if (Convert.ToDouble(dgvCargasPedido.SelectedRows[i].Cells[5].Value) > v.Altura * v.Largura * v.Comprimento)
                    {
                        throw new Exception("A carga " + dgvCargasPedido.SelectedRows[i].Cells[0].Value + " possui uma cubagem maior do que o caminhão");
                    }
                    //Somando cubagem dos itens já adicionados
                    double soma = 0;
                    for (int ix = 0; ix < dgvCargasAdicionadas.Rows.Count; ix++)
                    {
                        soma += Convert.ToDouble(dgvCargasAdicionadas.Rows[i].Cells[5].Value);
                    }
                    if (soma + Convert.ToDouble(dgvCargasPedido.Rows[i].Cells[5].Value) > v.Altura * v.Largura * v.Comprimento)
                    {
                        throw new Exception("Limite de cubagem excedido !!");
                    }                    
                    c.Id = Convert.ToInt32(dgvCargasPedido.Rows[dgvCargasPedido.SelectedRows[i].Index].Cells[0].Value);
                    listaSelecionada.Add(c);                                       
                }
                var a = dgvCargasPedido.SelectedRows;
                for (int i = 0; i < a.Count; i++)
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
                    dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[4].Value = listaSelecionada[i].Largura.ToString() + " * " + listaSelecionada[i].Altura.ToString() + " * " + listaSelecionada[i].Comprimento.ToString();
                    dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[5].Value = (listaSelecionada[i].Largura * listaSelecionada[i].Altura * listaSelecionada[i].Comprimento).ToString();
                    dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.Rows.Count - 1].Cells[6].Value = listaSelecionada[i].ValorProduto.ToString("C");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Cubagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCargasPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpGerarNotaTransporte_Enter(object sender, EventArgs e)
        {

        }

        private void btnGerarNotaTransporte_Click_1(object sender, EventArgs e)
        {
            nt = new NotaTransporte();
            try
            {
                if (Convert.ToInt32(cmbTiposFretes.SelectedValue) > 0 && Convert.ToInt32(cmbMotoristas.SelectedValue) > 0 && Convert.ToInt32(cmbVeiculos.SelectedValue) > 0 && txtDistancia.Text != string.Empty && txtValorFrete.Text != string.Empty)
                {
                    nt.InserirNotaTransporte(Convert.ToInt32(cmbVeiculos.SelectedValue), Convert.ToInt32(cmbMotoristas.SelectedValue), Convert.ToInt32(cmbTiposFretes.SelectedValue), Convert.ToDouble(txtValorFrete.Text), Convert.ToDouble(txtDistancia.Text));
                    if(nt.Id > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso !");
                        grbCargasPedido.Enabled = true;
                        grbItensNotaTransporte.Enabled = true;
                        txtIdNotaTransporte.Text = nt.Id.ToString();
                        grbNotaTransporte.Enabled = false;
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

        private void grbNotaTransporte_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemoverItemSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                //Recuperando id das cargas selecionadas
                List<Carga> listaCargasSelecionada = new List<Carga>();
                for (int i = 0; i < dgvCargasAdicionadas.SelectedRows.Count; i++)
                {
                    c = new Carga();
                    c.Id = Convert.ToInt32(dgvCargasAdicionadas.Rows[dgvCargasAdicionadas.SelectedRows[i].Index].Cells[0].Value);
                    listaCargasSelecionada.Add(c);
                }
                //Removendo itens do dgv
                var a = dgvCargasAdicionadas.SelectedRows;
                for (int i = 0; i < a.Count; i++)
                {
                    dgvCargasAdicionadas.Rows.RemoveAt(a[i].Index);
                }
                //
                for (int i = 0; i < listaCargasSelecionada.Count; i++)
                {
                    listaCargasSelecionada[i].ConsultarCarga(listaCargasSelecionada[i].Id);
                    dgvCargasPedido.Rows.Add();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[0].Value = listaCargasSelecionada[i].Id.ToString();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[1].Value = listaCargasSelecionada[i].NomeProduto;
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[2].Value = listaCargasSelecionada[i].Quantidade.ToString();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[3].Value = listaCargasSelecionada[i].Peso.ToString();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[4].Value = listaCargasSelecionada[i].Largura.ToString() + " * " + listaCargasSelecionada[i].Altura.ToString() + " * "+listaCargasSelecionada[i].Comprimento.ToString();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[5].Value = (listaCargasSelecionada[i].Largura * listaCargasSelecionada[i].Comprimento * listaCargasSelecionada[i].Altura).ToString();
                    dgvCargasPedido.Rows[dgvCargasPedido.Rows.Count - 1].Cells[6].Value = listaCargasSelecionada[i].ValorProduto.ToString("C");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCargasAdicionadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinalizarNota_Click(object sender, EventArgs e)
        {
            try
            {
                ints = new ItensNotaTransporte();
                for (int i = 0; i < dgvCargasAdicionadas.Rows.Count; i++)
                {
                    ints.InserirItensNotaTransporte(Convert.ToInt32(dgvCargasAdicionadas.Rows[i].Cells[0].Value), Convert.ToInt32(txtIdNotaTransporte.Text));
                }
                grbCargasPedido.Enabled = false;
                grbNotaTransporte.Enabled = false;
                btnRemoverItemSelecionado.Enabled = false;
                btnFinalizarNota.Enabled = false;
                btnNotaTransporte.Enabled = true;
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnVisualizarNotaTransporte_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            if(!Directory.Exists(@"C:\\Users\" + SystemInformation.UserName + @"\Documents\Notas"))
            {
                Directory.CreateDirectory(@"C:\\Users\" + SystemInformation.UserName + @"\Documents\Notas");
            }
            var caminho = @"C:\\Users\" + SystemInformation.UserName + @"\Documents\Notas\"+txtIdNotaTransporte.Text+".pdf";            
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.AddCreationDate();
                doc.Open();
                iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();
                Paragraph p = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER,
                };
                p.Font.Size = 18;                
                p.Add("Nota de Transporte");
                p.Add("\n");
                doc.Add(p);                
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_LEFT
                };
                p.Font.Size = 14;
                p.Add("\nId Nota Transporte: " + txtIdNotaTransporte.Text + "\n" + DateTime.Now);
                p.Add("\n");
                p.Add(seperator);
                p.Add("\n");                
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER
                };
                p.Font.Size = 18;
                p.Add("Cliente");
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_LEFT
                };
                Pedido ped = new Pedido();
                ped.ConsultarPedido(Convert.ToInt32(txtIdPedido.Text));
                Cliente cli = new Cliente();
                cli.ConsultarClienteId(Convert.ToInt32(ped.IdCliente.Id));
                PedidosEnderecos pedend = new PedidosEnderecos();
                TipoEndereco te = new TipoEndereco();
                te.ConsultarTipoEnderecoNome("Destinatário");
                pedend.ConsultarEnderecoDestinarioPedido(Convert.ToInt32(txtIdPedido.Text), te.Id);
                Endereco end = new Endereco();
                end.ConsultarEndereco(cli.Id, pedend.IdEndereco.Id);
                p.Add("\nRazão Social: " + cli.RazaoSocial);                
                p.Add("\nCNPJ: " + cli.Cnpj.ToString());
                p.Add("\nEmail: " + cli.Email);
                p.Add("\nNome Contato:" + cli.NomeContato + " | Telefone:  " + cli.Telefone);
                p.Add("\n");
                p.Add(seperator);
                p.Add("\n");
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER
                };
                p.Font.Size = 18;
                p.Add("Pedido");
                doc.Add(p);
                p = new Paragraph();
                p.Font.Size = 12;
                p.Add("Pedido :" + txtIdPedido.Text);
                p.Add("\nEndereço Destino: " + end.Cep + ", " + end.Logradouro + ", " + end.Numero.ToString());
                pedend = new PedidosEnderecos();
                te = new TipoEndereco();
                te.ConsultarTipoEnderecoNome("Remetente");
                pedend.ConsultarEnderecoDestinarioPedido(Convert.ToInt32(txtIdPedido.Text), te.Id);
                end = new Endereco();
                end.ConsultarEndereco(cli.Id, pedend.IdEndereco.Id);
                p.Add("\nEndereço Remetente: " + end.Cep + ", " + end.Logradouro + ", " + end.Numero.ToString());
                Plano plano = new Plano();
                PlanoCliente pc = new PlanoCliente();
                pc.ConsultarPlanoClienteAtivo(cli.Id);
                plano.ConsultarPlanoId(pc.IdPlano.Id);
                if (plano.Id > 0)
                    p.Add("\nPlano do Cliente: " + plano.NomePlano.ToString());
                else
                    p.Add("\nPlano do Cliente: Nenhum plano associado");
                p.Add("\n");
                p.Add(seperator);
                p.Add("\n");
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER
                };
                p.Font.Size = 18;
                p.Add("Cargas");
                doc.Add(p);
                p = new Paragraph
                { Alignment = Element.ALIGN_LEFT };
                ints = new ItensNotaTransporte();
                c = new Carga();
                foreach (var item in ints.ListarItensNotaTransporte(Convert.ToInt32(txtIdNotaTransporte.Text)))
                {
                    c.ConsultarCarga(item.IdCarga.Id);
                    p.Add("\nCarga: " + c.Id + " | Nome: " + c.NomeProduto + " | Valor Produto: " + c.ValorProduto.ToString("C"));
                }
                p.Add("\n");
                p.Add(seperator);
                p.Add("\n");
                doc.Add(p);
                p = new Paragraph
                { Alignment = Element.ALIGN_CENTER };
                p.Font.Size = 18;
                p.Add("Transporte");
                doc.Add(p);
                p = new Paragraph { Alignment = Element.ALIGN_LEFT };
                p.Font.Size = 14;
                p.Add("\nVeiculo");
                v = new Veiculo();
                NotaTransporte nt = new NotaTransporte();
                nt.ConsultarNotaTransporteId(Convert.ToInt32(txtIdNotaTransporte.Text));
                v.ConsultarVeiculoId(nt.IdVeiculo.Id);
                p.Add("\nMarca: " + v.Marca + " | Modelo: " + v.Modelo + " | Placa: " + v.Placa);
                m = new Motorista();
                m.ConsultarMotorista(nt.IdMotorista.IdMotorista);
                p.Add("\nMotorsita");
                p.Add("\nNome: " + m.Nome + " | CPF: " + m.Cpf + " | CNH: " + m.Cnh + " | Categoria: " + m.CategoriaCnh);
                p.Add("\n");
                p.Add(seperator);
                p.Add("\n");                
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER
                };
                p.Font.Size = 18;
                p.Add("Valores");
                doc.Add(p);
                p = new Paragraph
                {
                    Alignment = Element.ALIGN_LEFT
                };
                p.Add("Valor frete: " + txtValorFrete.Text);
                if (plano.Id > 0)
                {
                    p.Add("\nDesconto Plano: 5%");
                    var a = Convert.ToDouble(txtValorFrete.Text) - (Convert.ToDouble(txtValorFrete.Text) * 0.05);
                    p.Add("\nValor Final: " + a.ToString("C"));
                }                    
                else
                {
                    p.Add("Desconto Plano: 0%");
                    p.Add("\nValor Final: " + Convert.ToDouble(txtValorFrete.Text).ToString("C"));
                }                
                doc.Add(p);
                doc.Close();
                System.Diagnostics.Process.Start(caminho);                
                if (dgvCargasPedido.Rows.Count > 0 && Convert.ToInt32(dgvCargasPedido.Rows[0].Cells[0].Value) > 0)
                {
                    MessageBox.Show("Ainda há cargas a serem adicionadas\nGere outra nota de transporte !!", "Cargas Pendentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbNotasGeradas.Items.Add(nt.Id);
                    txtDistancia.Text = string.Empty;
                    txtIdNotaTransporte.Text = string.Empty;
                    txtValorFrete.Text = string.Empty;
                    grbNotaTransporte.Enabled = true;                                        
                    btnFinalizarNota.Enabled = true;
                    btnRemoverItemSelecionado.Enabled = true;
                    grbCargasPedido.Enabled = false;
                    grbItensNotaTransporte.Enabled = false;
                    for (int i = 0; i < dgvCargasAdicionadas.Rows.Count; i++)
                    {
                        dgvCargasAdicionadas.Rows.RemoveAt(0);
                    }
                    ped = new Pedido();
                    ped.AlterarPedido("Finalizado", Convert.ToInt32(txtIdPedido.Text));
                }
                else
                {
                    MessageBox.Show("Nota(s) gerada com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void grbCargasPedido_Enter(object sender, EventArgs e)
        {

        }
    }
}
