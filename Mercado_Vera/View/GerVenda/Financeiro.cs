using dllDao;
using Mercado_Vera.Dao;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mercado_Vera.View.GerVenda
{
    public partial class Financeiro : Form
    {
   
        //@"Data Source=JEAN-PC\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True"
        //@"Data Source=DESKTOP-JIMHMJU\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True"
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        DaoFechamento daoFechamento = new DaoFechamento();


        public Financeiro()
        {
            InitializeComponent();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            Graf_Pior_Vendas();
            Graf_Melhor_Vendidos();
            divida();
            valor();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //CRIO OS ARRAYS QUE RECEBEM OS DAODS PARA PASSAEM PARA OS GRAFICOS
        ArrayList PRODUTO = new ArrayList();
        ArrayList SAIDAS = new ArrayList();

        // CRIO UM METHOD QUE RECEBE OS DADOS DO BANDO PASSANDO UMA STORED PROCEDURE RETORNANDO OS DADOS ESPECIFICADOS
        private void Graf_Melhor_Vendidos()
        {
            cmd = new SqlCommand("PROD_MAIS_COMPRADOS", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {   //AQUI FAZ OS TESTES E RETORNA A COLUNA EM QUE ESTA O DADO
                PRODUTO.Add(dr.GetString(0));
                SAIDAS.Add(dr.GetInt32(1));

            }
            // AQUI PASSO O NOME DO GRAFICO QUE RECEBE OS DADOS E CONVERTO PARA QUE ENTRE NOS EIXOS X E Y
            chart2.Series[0].Points.DataBindXY(PRODUTO, SAIDAS);
            dr.Close();
            Conn.Close();
        }
        ArrayList PROD = new ArrayList();
        ArrayList SAID = new ArrayList();

        private void Graf_Pior_Vendas()
        {

            cmd = new SqlCommand("PROD_MENOS_VENDIDOS", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PROD.Add(dr.GetString(0));
                SAID.Add(dr.GetInt32(1));

            }
            chart1.Series[0].Points.DataBindXY(PROD, SAID);
            dr.Close();
            Conn.Close();

        }

        private void divida()
        {   // REPITO O MESMO PROCESSO ACIMA
            SqlCommand cmd = new SqlCommand("SELECT SUM(CLI_DIVIDA) AS VALOR FROM TBL_CLIENTE WHERE CLI_ID > 1", Conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            Conn.Open();

            string seuValor = cmd.ExecuteScalar().ToString();

            button2.Text = seuValor;
            Conn.Close();
        }
        private void valor()
        { // AQUI CRIO UM CHAMADO CMD PARA QUE COM O SQLCOMMAND ELE RETORNE OS DADOS DO BANDO EM UMA LABEL
            SqlCommand cmd = new SqlCommand("SELECT SUM(VEN_TOTAL) AS TOTAL FROM TBL_VENDA", Conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            Conn.Open();

            string seuValor = cmd.ExecuteScalar().ToString();

            button1.Text = seuValor;
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
