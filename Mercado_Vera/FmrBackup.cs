using dllDao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Vera
{
    public partial class FmrBackup : Form
    {
        Conexao conexao = new Conexao();

        public FmrBackup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "")
            {
                MessageBox.Show("Selecione o arquivo na caixinha antes de realizar a restauração do Banco!");
            }
            else
            {
                string servname = textBox1.Text;
                string dbname = textBox2.Text;

                string stringconexao = @"Data Source=" + servname + ";Initial Catalog=Master;Integrated Security=True";
                SqlConnection con = new SqlConnection(stringconexao);

                try
                {
                    con.Open();

                    string str = "USE master;";
                    string str1 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    string str2 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + textBox3.Text + "' WITH REPLACE ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Banco Restaurado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a restauração do banco! ERROR! " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }          
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.BackupAutomatico();
                MessageBox.Show("Backup realizado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Backup não realizado! ERROR! " + ex.Message);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\database1\";
            openFileDialog.Title = "Browse Text Files";

            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.DefaultExt = "BAK";
            openFileDialog.Filter = "Text files (*.bak)|*.bak";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog.FileName;
            }
        }
    }
}
