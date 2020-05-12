using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Vera.View.GerVenda.Relatorios
{
    public partial class Rel_Estoque : Form
    {
        public Rel_Estoque()
        {
            InitializeComponent();
        }

        private void Rel_Estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_PRODUTO' table. You can move, or remove it, as needed.
            this.tBL_PRODUTOTableAdapter.Fill(this.dataSetMercado.TBL_PRODUTO);
            // TODO: This line of code loads data into the 'dataProdEstoque.TBL_PRODUTO' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
