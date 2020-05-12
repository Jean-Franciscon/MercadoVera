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

namespace Mercado_Vera.View.GerVenda.Relatorios
{
    public partial class FmrVendaDetalhada : Form
    {
        string id;

        public void GetId(string id)
        {
            this.id = id;
        }

        public void GetNome(string nome)
        {
            lblNome.Text = nome;
        }

        DaoDividaDetalhada daoDivida = new DaoDividaDetalhada();

        public FmrVendaDetalhada()
        {
            InitializeComponent();
        }

        private void FmrVendaDetalhada_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string data1 = datePickerInicial.Value.ToString("yyyy-MM-dd");
            string data2 = datePickerFinal.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = daoDivida.SelectVendaPorData(data1, data2, id);

            lblTotalSoma.Text = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[preco.Name].Value ?? 0)).ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string linha = "";
            int offset = 150;
            string prodNome;
            string qtd;
            string total;
            string data;

            for (Int32 i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if ( i <= 1)
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

                    string cliente = "Cliente: " + lblNome.Text;

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

                prodNome = dataGridView1.Rows[i].Cells[0].Value.ToString();// coluna 1
                qtd = dataGridView1.Rows[i].Cells[1].Value.ToString();// coluna 2
                total = dataGridView1.Rows[i].Cells[2].Value.ToString();// coluna 3
                data = dataGridView1.Rows[i].Cells[3].Value.ToString();// coluna 3


                int tam = prodNome.Length;
                if (tam > 28)
                {
                    prodNome = prodNome.Substring(0, 28) + "...";
                }

                e.Graphics.DrawString(prodNome, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset);
                e.Graphics.DrawString(qtd, new Font("Arial", 8), new SolidBrush(Color.Black), 188, offset);
                e.Graphics.DrawString(total, new Font("Arial", 8), new SolidBrush(Color.Black), 235, offset);
                offset += 15;

            }
            //bottom
            e.Graphics.DrawString(linha, new Font("Arial", 14), new SolidBrush(Color.Black), 0, offset);
            offset += 20;
            //e.Graphics.DrawString(total, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, offset);
            //e.Graphics.DrawString(pagamento, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 150, offset);
            //offset += 20;
            //e.Graphics.DrawString(data, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset);
            offset += 20;
        }
    }
}
