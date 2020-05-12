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
    public partial class Rela_Cli_Devedores : Form
    {
        public Rela_Cli_Devedores()
        {
            InitializeComponent();
        }

        private void Rela_Cli_Devedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMercado.TBL_CLIENTE' table. You can move, or remove it, as needed.
            this.tBL_CLIENTETableAdapter.Fill(this.dataSetMercado.TBL_CLIENTE);
            // TODO: This line of code loads data into the 'dataCli_Devedores.TBL_CLIENTE' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
