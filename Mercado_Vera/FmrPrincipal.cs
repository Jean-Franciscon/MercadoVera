using dllDao;
using Mercado_Vera.View.GerCliente;
using Mercado_Vera.View.GerFornecedor;
using Mercado_Vera.View.GerProduto;
using Mercado_Vera.View.GerVenda;
using Mercado_Vera.View.GerVenda.Relatorios;
using System;
using System.Windows.Forms;

namespace Mercado_Vera
{//teste jean
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
   

        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            FmrCaixa caixa = new FmrCaixa();
            caixa.ShowDialog();
        }

        private void aberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAbertura abertura = new FmrAbertura();
            abertura.ShowDialog();
    
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FmrPesquisa fmrPesquisa = new FmrPesquisa();
            fmrPesquisa.ShowDialog();
    
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            FmrCliente fmrCliente = new FmrCliente();
            fmrCliente.ShowDialog();

        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FmrProduto fmrProduto = new FmrProduto();
            fmrProduto.ShowDialog();

            

        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            PesqCliente pesqCliente = new PesqCliente();
            pesqCliente.ShowDialog();
         
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
     
            FmrPesquisaFor fmrPesquisa = new FmrPesquisaFor();
            fmrPesquisa.ShowDialog();
       
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FmrFornecedor fmrFornecedor = new FmrFornecedor();
            fmrFornecedor.ShowDialog();
         
        }

        private void aberturaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
            
            FmrAbertura fmrAbertura = new FmrAbertura();
            fmrAbertura.ShowDialog();
           
        }

        private void caixaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
       
            FmrCaixa fmrCaixa = new FmrCaixa();
            fmrCaixa.ShowDialog();
 
        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                conexao.BackupAutomatico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Backup!!! " + ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            FmrCliente cli = new FmrCliente();
            cli.Show();
          
        }

        private void pesquisarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FmrPesquisaFor fornecedor = new FmrPesquisaFor();
            fornecedor.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            Rela_For forn = new Rela_For();
            forn.Show();
       
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
      
            FmrAbertura CAIXA = new FmrAbertura();
            CAIXA.Show();
    
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            FmrProduto prod = new FmrProduto();
            prod.Show();

        }

        private void pesquisarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            FmrPesquisa pesquisa = new FmrPesquisa();
            pesquisa.Show();
        
        }

        private void novoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FmrFornecedor fornecedor = new FmrFornecedor();
            fornecedor.Show();
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            
        }

        private void clientesDevedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            Rela_Cli_Devedores devedores = new Rela_Cli_Devedores();
            devedores.Show();
      
        }

        private void produtosEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            Rel_Estoque estoque = new Rel_Estoque ();
            estoque.Show();
     
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair!? ", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
   
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
  
        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PesqCliente cli = new PesqCliente();
            cli.ShowDialog();
            this.Visible = true;
     
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FmrCliente cli = new FmrCliente();
            cli.ShowDialog();
            this.Visible = true;
        
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrBackup fmrBackup = new FmrBackup();
            fmrBackup.ShowDialog();
        }
    }
}
