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
    public partial class Rela_For : Form
    {
        public Rela_For()
        {
            InitializeComponent();
        }

        private void Rela_For_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_FORNECEDOR' table. You can move, or remove it, as needed.
            this.tBL_FORNECEDORTableAdapter.Fill(this.dataSetMercado.TBL_FORNECEDOR);
            // TODO: This line of code loads data into the 'dataFornecedor.TBL_FORNECEDOR' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
