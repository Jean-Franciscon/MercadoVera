using Mercado_Vera.Dao;
using Mercado_Vera.Exceptions;
using Mercado_Vera.View.GerVenda.Relatorios;
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
    public partial class PesqCliente : Form
    {
        DaoCliente daoCliente = new DaoCliente();
        string busca = "";
        string id;
        string valor;

        public PesqCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PesqCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daoCliente.PesqCliente("", "");

            //dataGridView1.Columns.Add(new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.lupa3,
            //    Name = "someName",
            //    HeaderText = "Some Text"
            //});

        }



        private void txtNomePes_KeyDown(object sender, KeyEventArgs e)
        {
            busca = txtNomePes.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente("", busca);
        }

        private void txtNomePes_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>.,:;°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita letras e espaços!");
            }

            busca = txtNomePes.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente("", busca);
        }

        private void txtNomePes_KeyUp(object sender, KeyEventArgs e)
        {
            busca = txtNomePes.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente("", busca);
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            busca = txtId.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente(busca,"");
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }


            busca = txtId.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente(busca, "");
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            busca = txtId.Text;
            dataGridView1.DataSource = daoCliente.PesqCliente(busca, "");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FmrCliente fmrCliente = new FmrCliente();
            fmrCliente.ShowDialog();
            Atualizar();
            this.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Selecione o cliente primeiro!");
            }
            else
            {
                try
                {
                    DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        daoCliente.DeleteCli(id);
                        Atualizar();
                        MessageBox.Show("Cliente Excluido com sucesso!");

                        id = null;
                    }
                }
                catch (DomainExceptions ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //ao clicar duas vezes passa o nome eo id para os txtbox
            this.txtId.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_ID"].Value);
            this.txtNomePes.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_NOME"].Value);
            id = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_ID"].Value);
            valor = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_DIVIDA"].Value);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Selecione o cliente primeiro!");
            }
            else
            {
                this.Visible = false;
                EditarCli editarCli = new EditarCli();
                editarCli.GetId(id);
                editarCli.ShowDialog();
                Atualizar();
                this.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (id == null)
            {
                MessageBox.Show("Selecione o cliente primeiro!");
            }
            else if(valor == "0.00")
            {
                MessageBox.Show("Cliente não possui pendencia!", "Pagamento de cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                this.Visible = false;
                FmrCliPagamento pag = new FmrCliPagamento();
                pag.GetId(id);
                pag.GetNome(txtNomePes.Text);
                pag.MudarNome();
                pag.ShowDialog();
                Atualizar();
                this.Visible = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Atualizar()
        {
            dataGridView1.DataSource = daoCliente.PesqCliente("", "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "AbrirDetalhes")
                {
                    id = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_ID"].Value);
                    string nome = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CLI_NOME"].Value);
                    FmrVendaDetalhada fmrVendaDetalhada = new FmrVendaDetalhada();
                    fmrVendaDetalhada.GetId(id);
                    fmrVendaDetalhada.GetNome(nome);
                    fmrVendaDetalhada.ShowDialog();
                    PesqCliente pesqCliente = new PesqCliente();
                    pesqCliente.Visible = false;
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
