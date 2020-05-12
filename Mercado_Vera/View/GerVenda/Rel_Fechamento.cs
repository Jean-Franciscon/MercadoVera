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
    public partial class Rel_Fechamento : Form
    {
        public Rel_Fechamento()
        {
            InitializeComponent();
        }

        private void Rel_Fechamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_FECHAMENTO' table. You can move, or remove it, as needed.
            this.tBL_FECHAMENTOTableAdapter.Fill(this.dataSetMercado.TBL_FECHAMENTO);
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_FECHAMENTO' table. You can move, or remove it, as needed.
            this.tBL_FECHAMENTOTableAdapter.Fill(this.dataSetMercado.TBL_FECHAMENTO);
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_FECHAMENTO' table. You can move, or remove it, as needed.
            this.tBL_FECHAMENTOTableAdapter.Fill(this.dataSetMercado.TBL_FECHAMENTO);
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_FECHAMENTO' table. You can move, or remove it, as needed.
            this.tBL_FECHAMENTOTableAdapter.Fill(this.dataSetMercado.TBL_FECHAMENTO);
            // TODO: This line of code loads data into the 'imprimirFechamento.TBL_FECHAMENTO' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
