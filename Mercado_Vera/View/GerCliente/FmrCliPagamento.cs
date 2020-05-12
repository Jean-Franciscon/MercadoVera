using Mercado_Vera.Dao;
using Mercado_Vera.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Vera.View.GerCliente
{
    public partial class FmrCliPagamento : Form
    {
        DaoCliente daoCliente = new DaoCliente();
        DaoDividaDetalhada dividaDetalhada = new DaoDividaDetalhada();
        
        string id;
        string nome;

        public void GetId(string id)
        {
            this.id = id;
        }

        public void GetNome(string nome)
        {
            this.nome = nome;
        }

        public void MudarNome()
        {
            lblId.Text = id;
            lblCli.Text = nome;
        }

        public FmrCliPagamento()
        {
            InitializeComponent();
        }

        private void FmrCliPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                daoCliente.PagCliente(id, Decimal.Parse(txtValor.Text));

                DividaDetalhada divida = new DividaDetalhada(id, txtValor.Text);
                dividaDetalhada.AlterStausVendaDetalhada(divida);

                MessageBox.Show("Pagamento confirmado!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!!! " + ex);
            }

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
