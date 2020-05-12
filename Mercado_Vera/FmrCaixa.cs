using dllDao;
using Mercado_Vera.Dao;
using Mercado_Vera.Entity;
using Mercado_Vera.Exceptions;
using Mercado_Vera.View.GerCliente;
using Mercado_Vera.View.GerVenda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercado_Vera
{
    public partial class FmrCaixa : Form
    {
        DaoVenda daoVenda = new DaoVenda();
        DaoDividaDetalhada dividaDetalhada = new DaoDividaDetalhada();
        DaoFoto daoFoto = new DaoFoto();
        ObservableCollection<ItemVenda> listaItens = new ObservableCollection<ItemVenda>();

        static string statusCaixa = "Aberto";
        public void GetStatusCaixa(string status)
        {
            statusCaixa = status;
        }
        static string statusAtalho = "";
        string statusVenda = "Fechada";
        string parcelas;
        string bandeira;
        string pagamento;
        string dataHora = DateTime.Now.ToString();
        public static string qtd = "1";
        static decimal totalprod;
        byte[] foto = new Byte[0];
        public static string cliId { get; set; }
        public static string nomeCli { get; set; }
        public static string idProd { get; set; }
        public static string nomeProd { get; set; }

  
        public FmrCaixa()
        {
            InitializeComponent();
            panelFinalizar.Visible = false;
            panelCredito.Visible = false;
            BtnVenda.Focus();
        }

        private void FmrCaixa_Load(object sender, EventArgs e)
        {
            lblRsDinheiro.Visible = false;
            TravarBotoes();
            btnDinheira.Focus();
        }


        #region Metodos

        #region PrencheProduto
        //Metodo que prenche o txtbox com o produto do BD
        public void PrencheProduto()
        {
            if (txtQtd.Text != "")
            {
                qtd = txtQtd.Text;
            }

            lblProdID.Enabled = false;
            txtQtd.Enabled = false;
            try
            {
                daoVenda.ConsultaQuantidade(txtBarra.Text, qtd, idProd);
                SqlDataReader dr = daoVenda.RetornaProd(txtBarra.Text, idProd);

                txtBarra.Text = dr["PROD_COD"].ToString();
                lblValorUni.Text = dr["PROD_VALOR_VENDA"].ToString();
                lblPod.Text = dr["PROD_NOME"].ToString();
                lblProdID.Text = dr["PROD_ID"].ToString();

                totalprod = (int.Parse(qtd) * decimal.Parse(lblValorUni.Text));
                lblTotaltem.Text = totalprod.ToString();

                foto = daoFoto.RetornaImg(lblProdID.Text);

                if (foto == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream stream = new MemoryStream(foto);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromStream(stream);
                }

                GetProdDg();
                PrencheDg();
            }

            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtBarra.Text = "";
                qtd = "1";
                idProd = "";
                lblProdID.Text = "";
                txtQtd.Text = "";
                lblSubTotal.Text = dataGridView2.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[total.Name].Value ?? 0)).ToString("##0.00");
            }

        }
        #endregion

        public void adicionarQuantidade()
        {
            LimparDadosVenda();

            txtQtd.BackColor = System.Drawing.Color.LightSteelBlue;
            txtBarra.BackColor = System.Drawing.Color.Lime;
            txtBarra.Enabled = false;
            txtQtd.Enabled = true;
            txtQtd.Focus();
        }

        private void NovaVenda()
        {
            if (statusCaixa == "Fechado")
            {
                MessageBox.Show("Faça a abertura do caixa!", "Abertura de caixa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (statusCaixa == "Aberto")
            {
                txtBarra.Enabled = true;
                btnQld.Enabled = true;
                btnDel.Enabled = true;
                btnFin.Enabled = true;
                btnOutros.Enabled = true;
                txtBarra.BackColor = System.Drawing.Color.LightSteelBlue;
                txtBarra.Focus();
                BtnVenda.Enabled = false;
                statusVenda = "Aberta";
            }
        }

        public void redirecionarParaFinalizarVenda()
        {
            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Lista de produtos está vazia!", "Lista de produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LimparDadosVenda();

                //txtBarra.BackColor = System.Drawing.Color.SteelBlue;
                txtBarra.Enabled = false;
                lblTotal2.Text = lblSubTotal.Text;
                panelFinalizar.Visible = true;
                BtnVenda.Enabled = false;
                statusAtalho = "TelaPag";
            }
        }

        public void DeletarProduto()
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    //ao clicar pega o ID e QTD do datagrid
                    int idProd = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                    string codProd = Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value);
                    int qtdProd = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[4].Value);
                    daoVenda.UpdateEstoqueAdicionar(idProd, qtdProd, codProd);//Adiciona ao estoque o produto removido

                    #region Remover pelo ID expressão Lambida
                    //var itemToRemove = listaItens.Single(r => r.ProdId == idProd);
                    //listaItens.Remove(itemToRemove);
                    #endregion

                    int indice = this.dataGridView2.CurrentRow.Index;
                    listaItens.RemoveAt(indice);

                    //Remove do datagrid       
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    lblSubTotal.Text = dataGridView2.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[total.Name].Value ?? 0)).ToString("##00.00");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione o produto antes de excluir!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtBarra.Focus();
                dataGridView2.ClearSelection();
                dataGridView2.CurrentCell = null;
            }
        }

        public void PesquisarCliente()
        {
            ResetarPagamento();

            BuscaCliente buscaCli = new BuscaCliente();
            buscaCli.ShowDialog();

            lblClienteID.Text = buscaCli.id;
            lblNomeCli.Text = buscaCli.nome;
            if (lblClienteID.Text != "")
            {
                lblPagamento.Text = "CREDIÁRIO";
                pagamento = "Crediário";
            }
        }

        private void FinalizarVenda()
        {
            if (pagamento != null && pagamento != "")

            {
                if (cliId == null || cliId == "")
                {
                    cliId = "1";
                }
                try
                {
                    if (txtDinheiro.Text == "" && pagamento == "Dinheiro")
                    {
                        MessageBox.Show("Digite o valor a ser pago!");
                    }

                    else
                    {
                        string qtdTotal = dataGridView2.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[quantidade.Name].Value ?? 0)).ToString("##");
                        Venda venda = new Venda(cliId, qtdTotal, lblSubTotal.Text, dataHora, pagamento, bandeira, parcelas);
                        daoVenda.RegistraVenda(venda);

                        foreach (ItemVenda V in listaItens)
                        {
                            daoVenda.RegistrarItemVenda(V.ProdId, V.ValorTotal, V.Qtd);
                        }

                        //Acrecenta valor negativo aos clientes de crediário
                        daoVenda.UpdateCrediario(lblClienteID.Text, lblSubTotal.Text);
                        if (lblClienteID.Text != "1")
                        {
                            dividaDetalhada.InsertVendaDetalhada();//Adiciona divida detalhada
                        }


                        MessageBox.Show("Venda Finalizada !");

                    


                        dataGridView2.Rows.Clear();//limpa o datagrid e mantem o header
                        statusVenda = "Fechada";

                        DialogResult confirm = MessageBox.Show("Deseja imprimir comprovante?", "Imprimir comprovante.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                        if (confirm.ToString().ToUpper() == "YES")
                        {
                            Document.Print();
                        }

                        listaItens.Clear();
                        LimparDados();
                        NovaVenda();                   
                    }
                }
                catch (DomainExceptions ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Selecione a forma de pagamento!", "Forma de pagamento.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Credito()
        {
            ResetarPagamento();

            txtParcela.BackColor = System.Drawing.Color.LightSteelBlue;
            panelCredito.Visible = true;
            panelCredito.Height = 395;
            txtDinheiro.BackColor = System.Drawing.Color.Lime;
            bandeira = cbxBandCred.Text;
            pagamento = "Crédito";
            lblPagamento.Text = "CRÉDITO";
            lblValorCred.Text = lblSubTotal.Text;
            lblCredito.Text = lblSubTotal.Text;
            txtParcela.Focus();
        }

        public void Debito()
        {
            ResetarPagamento();

            panelDebito.Height = 395;
            lblDebito.Text = lblSubTotal.Text;
            lblValorDebito.Text = lblSubTotal.Text;
            bandeira = cbxBandeira.Text;
            pagamento = "Débito";
            lblPagamento.Text = "DÉBITO";
        }

        public void Dinheiro()
        {
            ResetarPagamento();

            lblPagamento.Text = "CAIXA";
            pagamento = "Dinheiro";
            txtDinheiro.BackColor = System.Drawing.Color.LimeGreen;  
            lblRsDinheiro.Visible = true;
            txtDinheiro.Enabled = true;
            txtDinheiro.Focus();
        }

        public void Cancelarvenda()
        {

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Cancelar venda", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                //Percorrer o Dg para pegar todos os produtos da venda que foi cancelada e adicionar ao estoque novamente
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    int idItens = Convert.ToInt32(this.dataGridView2.Rows[i].Cells[0].Value);
                    int qtdItens = Convert.ToInt32(this.dataGridView2.Rows[i].Cells[4].Value);

                    daoVenda.UpdateEstoqueAdicionar(idItens, qtdItens);
                }

                LimparDados();

                qtd = "1";
                txtQtd.Text = "";
                lblProdID.Text = "";
                lblPod.Text = "";
                lblTotaltem.Text = "0,00";
                lblSubTotal.Text = "0,00";
                panelFinalizar.Visible = false;
                BtnVenda.Enabled = true;
                pictureBox1.Image = null;
                lblTotaltem.Text = "0,00";
                lblValorUni.Text = "0,00";
                panelFinalizar.Visible = false;
                lblPagamento.Text = "CAIXA";
                dataGridView2.Rows.Clear();//limpa o datagrid e mantem o header
                statusVenda = "Fechada";
                statusAtalho = "";

                NovaVenda();
            }
        }

        public void Sair()
        {
            if (dataGridView2.RowCount > 0)
            {
                MessageBox.Show("A venda está em aberto! Para poder sair cancele a venda na tela de pagamento.", "Venda em aberto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Sair venda.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    Close();
                    statusVenda = "Fechada";
                    FmrAbertura forn = new FmrAbertura();
                    forn.Show();
                }
            }
        }

        public void PesquisarProdutos()
        {
            FmrPesqProd pesqPrd = new FmrPesqProd();
            pesqPrd.ShowDialog();

            if (statusVenda == "Aberta")
            {
                idProd = pesqPrd.id;
                if (idProd != null)
                {
                    PrencheProduto();
                    txtQtd.Text = "";
                    txtBarra.Focus();
                }
            }
        }

        //preenche datagridview com as informações do produto
        public void PrencheDg()
        {
            dataGridView2.Rows.Add(lblProdID.Text, txtBarra.Text, lblPod.Text, lblValorUni.Text, qtd, lblTotaltem.Text);

            //Atualiza estoque ao escolher o produto
            daoVenda.UpdateEstoque(int.Parse(lblProdID.Text), int.Parse(qtd), txtBarra.Text);

            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
            //int rowindex = dataGridView2.CurrentCell.RowIndex;
        }
        //pega o ID e a qantidade do produto para armazenar em uma lista
        public void GetProdDg()
        {
            ItemVenda itemVenda = new ItemVenda(lblProdID.Text, lblTotaltem.Text, qtd);
            listaItens.Add(itemVenda);
        }

        private void TravarBotoes()
        {
            txtBarra.Enabled = false;
            txtQtd.Enabled = false;
            btnQld.Enabled = false;
            btnDel.Enabled = false;
            btnFin.Enabled = false;
            btnOutros.Enabled = false;
        }

        public void vendaDiversos()
        {
            FmrOutros outros = new FmrOutros();
            outros.ShowDialog();

            if (statusVenda == "Aberta")
            {
                txtBarra.Text = "102030405060";

                PrencheProduto();
                txtQtd.Text = "";
                txtBarra.Focus();

                daoVenda.UpdateOutros("0,00");
            }
        }

        //METODOS DE LIMPEZA DE CAMPOS
        public void ResetarPagamento()
        {
            cliId = null;
            bandeira = "";
            parcelas = "";
            pagamento = "";
            panelDebito.Height = 10;
            panelCredito.Height = 10;
            lblClienteID.Text = "1";
            lblNomeCli.Text = "CLIENTE - 1";
            cbxBandCred.Text = null;
            cbxBandeira.Text = null;
            txtDinheiro.Text = "";
            txtDinheiro.BackColor = System.Drawing.Color.Lime;
            lblRsDinheiro.Visible = false;
            lblDebito.Text = "0,00";
            lblCredito.Text = "0,00";
            txtDinheiro.Enabled = false;
            lblTotalRec.Text = "0,00";
            lblTroco.Text = "0,00";

        }

        public void LimparDados()
        {
            qtd = "1";
            cliId = null;
            statusAtalho = "";
            parcelas = null;
            bandeira = null;
            pagamento = "";
            lblClienteID.Text = "1";
            lblNomeCli.Text = "CLIENTE - 1";
            lblCredito.Text = "0,00";
            lblDebito.Text = "0,00";
            lblTroco.Text = "0,00";
            lblValorDebito.Text = "0,00";
            lblValorCred.Text = "0,00";
            lblValorParcela.Text = "0,00";
            lblTotalRec.Text = "0,00";
            lblSubTotal.Text = "0,00";
            lblTroco.Text = "0,00";       
            txtParcela.Text = "";
            txtDinheiro.Text = "";
            cbxBandCred.Text = null;
            cbxBandeira.Text = null;
            lblRsDinheiro.Visible = false;
            lblPagamento.Text = "CAIXA";
            panelCredito.Height = 10;
            panelDebito.Height = 10;
            lblRsDinheiro.Visible = false;
            panelFinalizar.Visible = false;
            txtQtd.BackColor = System.Drawing.Color.Lime;
            txtDinheiro.BackColor = System.Drawing.Color.Lime;
            txtQtd.BackColor = System.Drawing.Color.Lime;
            lblProdID.Text = "";
        }

        public void LimparDadosVenda()
        {
            lblPod.Text = "";
            lblValorUni.Text = "0,00";
            lblTotaltem.Text = "0,00";
            lblProdID.Text = "";
            txtBarra.Text = "";
            txtQtd.Text = "";
            idProd = "";
            txtBarra.BackColor = System.Drawing.Color.Lime;
            pictureBox1.Image = null;
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:

                    NovaVenda();

                    break;

                case Keys.F2:

                    adicionarQuantidade();

                    break;

                case Keys.F3:

                    DeletarProduto();

                    break;

                case Keys.F4:

                    redirecionarParaFinalizarVenda();

                    break;

                case Keys.F5:

                    PesquisarProdutos();

                    break;


                case Keys.F6:

                    Sair();

                    break;

                case Keys.F7:

                    if (statusAtalho == "TelaPag")
                    {
                        PesquisarCliente();
                    }

                    break;

                case Keys.F8:

                    if (statusAtalho == "TelaPag")
                    {
                        FinalizarVenda();
                    }

                    break;

                case Keys.F9:

                    if (statusAtalho == "TelaPag")
                    {
                        Cancelarvenda();
                    }

                    break;

                case Keys.F10:
                    if (statusAtalho == "TelaPag")
                    {
                        Dinheiro();
                    }
                    break;

                case Keys.F11:

                    if (statusAtalho == "TelaPag")
                    {
                        Credito();
                    }

                    break;

                case Keys.F12:

                    if (statusAtalho == "TelaPag")
                    {
                        Debito();
                    }

                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Botoes

        private void btnQld_Click(object sender, EventArgs e)
        {
            adicionarQuantidade();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            NovaVenda();
        }
        //Botão de finalizar venda da primeira tela, leva para tela de pagamento
        private void btnFin_Click(object sender, EventArgs e)
        {
            redirecionarParaFinalizarVenda();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeletarProduto();
        }
        //botão para abrir a busca de clientes para pagamento em crediário
        private void button6_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }
        //botão para finalizar a venda
        private void btnFinal_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }
        //botão crédito
        private void button7_Click(object sender, EventArgs e)
        {
            Credito();
        }
        //botão débito
        private void button8_Click(object sender, EventArgs e)
        {
            Debito();
        }
        //Botão Dinheiro
        private void button1_Click(object sender, EventArgs e)
        {
            Dinheiro();
        }
        //botão ok débito
        private void button2_Click(object sender, EventArgs e)
        {
            bandeira = cbxBandeira.Text;

            if (bandeira != "")
            {
                panelDebito.Height = 10;
            }
            else
            {
                MessageBox.Show("Selecione a bandeira do cartão de Débito!");
            }
        }
        //botão ok crédito
        private void btnOkCredito_Click(object sender, EventArgs e)
        {

            bandeira = cbxBandCred.Text;

            if (txtParcela.Text == "" || txtParcela.Text == "0")
            {
                MessageBox.Show("Coloque um valor maior que zero na parcela !");
            }

            else if (bandeira == "")
            {
                MessageBox.Show("Selecione a bandeira do cartão de crédito !");
            }

            else
            {
                panelCredito.Height = 10;
            }
        }
        //botão EscDebito
        private void button1_Click_1(object sender, EventArgs e)
        {
            panelDebito.Height = 10;
            lblValorDebito.Text = "0,00";
            panelCredito.Height = 10;
            cbxBandeira.Text = null;
        }
        //cancelar Venda
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            Cancelarvenda();
        }
        //Nota Fiscal
        private void btnNotaFisc_Click(object sender, EventArgs e)
        {
            Document.Print();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtParcela.Text = "";
            lblValorCred.Text = "0,00";
            lblValorParcela.Text = "0,00";
            panelCredito.Height = 10;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            vendaDiversos();
        }


        #endregion

        #region txt
        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;

            if (e.KeyChar == 13 && txtBarra.Text != "")
            {
                PrencheProduto();
            }
        }

        private void txtBarra_Leave(object sender, EventArgs e)
        {

        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;

            if (e.KeyChar == 13)
            {
                txtQtd.Enabled = false;
                txtQtd.BackColor = System.Drawing.Color.Lime;
                txtBarra.BackColor = System.Drawing.Color.LightSteelBlue;
                txtBarra.Enabled = true;
                txtBarra.Focus();
            }
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {

            //este campo aceita somente uma virgula
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }

            if (e.KeyChar == 13 && txtDinheiro.Text != "")
            {
                if (decimal.Parse(txtDinheiro.Text) < decimal.Parse(lblSubTotal.Text))
                {
                    MessageBox.Show("Valor de entrada menor doque o valor da compra!", "Valor menor");
                }
                else
                {

                    txtDinheiro.BackColor = System.Drawing.Color.Lime;
                    btnFin.Focus();
                    decimal subt = decimal.Parse(txtDinheiro.Text) - decimal.Parse(lblSubTotal.Text);
                    txtDinheiro.Text = txtDinheiro.Text;
                    lblTotalRec.Text = txtDinheiro.Text;
                    lblTroco.Text = subt.ToString();
                }
            }

        }

        private void txtParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;

        }
        //É um txt
        private void lblId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>.,:;°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;

            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

            }

            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void txtBarra_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Label
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label31_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DaoImprimir DaoImprimir = new DaoImprimir();
            DataTable dt = DaoImprimir.SelectNotaFiscal();
            int offset = 150;
            int cont = 0;
            string linha = "";
            string total = "";
            string data = "";
            string pagamento = "";

            foreach (DataRow dataRow in dt.Rows)
            {
                if (cont < 1)
                {
                    //HEADER
                    string empresa = "LOJINHA DA VERA";
                    string cnpj = "Cnpj: 13.060.953/0001-97";
                    string end = "Rua Capitão F. Teixeira Nogueira  N° 12 ";
                    string cel = "WhatsApp: (11) 9 8862-7715";
                    string email = "E-mail: loja.vera05@gmail.com";
                    linha = "-----------------------------------------------------";
                    //ITENS
                    string Desc = "DESC                                            QTD          VALOR";
                    //BOTTOM

                    string cliente = "Cliente: " + dataRow["CLI_NOME"].ToString();
                    pagamento = dataRow["VEN_PAGAMENTO"].ToString();
                    data = "Data: " + dataRow["DATA"].ToString();
                    total = "TOTAL:  R$ " + dataRow["VEN_TOTAL"].ToString();

                    //header center
                    e.Graphics.DrawString(empresa, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(60, 0));
                    e.Graphics.DrawString(cnpj, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(40, 16));
                    e.Graphics.DrawString(end, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(13, 30));
                    e.Graphics.DrawString(cel, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(40, 48));
                    e.Graphics.DrawString(email, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(31, 66));

                    e.Graphics.DrawString(linha, new Font("Arial", 14), new SolidBrush(Color.Black), new Point(0, 72));
                    e.Graphics.DrawString(cliente, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(5, 90));

                    e.Graphics.DrawString(linha, new Font("Arial", 14), new SolidBrush(Color.Black), new Point(0, 105));
                    e.Graphics.DrawString(Desc, new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, 130));



                }

                //Adiciona na lista Especificando a clouna 
                string nome = dataRow["PROD_NOME"].ToString();
                string quantidade = dataRow["ITEM_QTD"].ToString();
                string preco = dataRow["ITEM_VALOR"].ToString();
                // listaProd.Add(new Produto(nome, preco, quantidade));

                e.Graphics.DrawString(nome, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset);
                e.Graphics.DrawString(quantidade, new Font("Arial", 8), new SolidBrush(Color.Black), 188, offset);
                e.Graphics.DrawString(preco, new Font("Arial", 8), new SolidBrush(Color.Black), 235, offset);
                offset += 15;
            }
            //bottom
            e.Graphics.DrawString(linha, new Font("Arial", 14), new SolidBrush(Color.Black), 0, offset);
            offset += 20;
            e.Graphics.DrawString(total, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, offset);
            e.Graphics.DrawString(pagamento, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 150, offset);
            offset += 20;
            e.Graphics.DrawString(data, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset);
            offset += 20;
        }



        #region Eventos
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FmrCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FmrCaixa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtParcela_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtParcela_KeyUp(object sender, KeyEventArgs e)
        {
            parcelas = txtParcela.Text;

            if (parcelas != "")
            {
                if (decimal.Parse(parcelas) == 0)
                {
                    MessageBox.Show("O número de parcelas não pode ser " + parcelas);
                    parcelas = "";
                    txtParcela.Text = "";
                }

                else
                {
                    decimal valor = decimal.Parse(lblSubTotal.Text) / decimal.Parse(parcelas);
                    lblValorParcela.Text = valor.ToString();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Painel
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTotalCli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelFinalizar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelCredito_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion


    }
}