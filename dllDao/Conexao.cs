using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllDao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            //con.ConnectionString = @"Data Source=DESKTOP-JIMHMJU\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";
            //con.ConnectionString = @"Data Source=JEAN-PC\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";
            con.ConnectionString = @"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";
        }

        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(StrConexao());
            return connection;
        }

        //se a conexao estiver fechada vai abrir a conexao
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        // vai fechar a conexão
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        //retorna a string de conexao para ser utilizada.
        public string StrConexao()
        {
            //return @"Data Source=DESKTOP-JIMHMJU\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";

            //return @"Data Source=JEAN-PC\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";

            return @"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=MERCADO_01;Integrated Security=True";
        }

        //Executa query simples.
        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {
            string strConxao = StrConexao();
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }
        //pega os dados na base e retorna
        public DataTable CarregarDados(string sql)
        {
            string query = sql;
            //Cria conexão com banco de dados
            SqlConnection con = new SqlConnection(StrConexao());

            con.Open();
            //Cria um dataadapter para receber o select do banco de dados
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;

        }
        public SqlDataReader CarregarVariosDados(string sql)
        {
            string query = sql;
            //Cria conexão com banco de dados
            SqlConnection con = new SqlConnection(StrConexao());
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader dr = null;

            con.Open();
            dr = sqlCommand.ExecuteReader();
            dr.Read();

            return dr;
        }
        //Busca os Estados no banco de dados
        public DataTable RetornaEstado()
        {
            string query = "SELECT EST_INT_CODUF, EST_STR_NOME FROM TBL_ESTADO";
            DataTable dt = CarregarDados(query);
            return dt;
        }
        //Busca as cidades no banco de dados
        public DataTable RetornaCidade(string id)
        {
            string query = "SELECT CID_INT_ID, CID_STR_NOME FROM TBL_CIDADE WHERE EST_INT_CODUF=" + id;
            DataTable dt = CarregarDados(query);
            return dt;
        }
        //Retorna Empresa
        public DataTable RetornaEmpresa()
        {
            string query = "SELECT EMP_INT_ID, EMP_STR_NOME FROM TBL_EMPRESA";
            DataTable dt = CarregarDados(query);
            return dt;
        }
        //Retorna apenas o ID
        public string SelecioneId(string query)
        {
            string id;
            Conexao conexao = new Conexao();
            string Sqlquery = query;

            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand sqlCommand = new SqlCommand(Sqlquery, con);

            con.Open();

            id = sqlCommand.ExecuteScalar().ToString();

            con.Close();
            return id;
        }
        //Backup
        public void BackupAutomatico()
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "-" + d.Month + "-" + d.Year;

            SqlConnection con = new SqlConnection(StrConexao());

            con.Open();

            string str = "USE MERCADO_01;";
            string strl = "BACKUP DATABASE MERCADO_01" +
                " TO DISK = 'C:\\database1\\MERCADO_01_" + dd +
                ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of MERCADO_01';";

            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlCommand cmd2 = new SqlCommand(strl, con);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            con.Close();
        }
    }
}

