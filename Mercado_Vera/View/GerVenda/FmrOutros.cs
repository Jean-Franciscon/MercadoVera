using Mercado_Vera.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Vera.View.GerVenda
{
    public partial class FmrOutros : Form
    {
        DaoVenda daoVenda = new DaoVenda();

        public FmrOutros()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                daoVenda.UpdateOutros(txtValor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
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

            if (e.KeyChar == 13 && txtValor.Text != "")
            {
                try
                {
                    daoVenda.UpdateOutros(txtValor.Text);
                }
                catch (Exception ex)
                {
                    daoVenda.UpdateOutros(txtValor.Text);
                }

                this.Close();
            }          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
