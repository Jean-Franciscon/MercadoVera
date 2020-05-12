using dllDao;
using Mercado_Vera.Entity;
using Mercado_Vera.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Vera.Dao
{
    class DaoDividaDetalhada
    {
        Conexao conexao = new Conexao();

        public void InsertVendaDetalhada()
        {
            //Traz o ultimo ID
            string query = "SELECT MAX(VEN_ID) AS ID FROM TBL_VENDA";
            string id = conexao.SelecioneId(query);


            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand cmd1 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_VENDA_DETALHADA (VEN_ID,VEN_DET_VALOR_PAGO,VEN_DET_STATUS) VALUES (@idVenda,0.00,'NÃO PAGO')";
            cmd1.Parameters.Add(new SqlParameter("@idVenda", id));

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                tran.Commit();

            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw new DomainExceptions("Error!!! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void AlterStausVendaDetalhada(DividaDetalhada divida)
        {
            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd = new SqlCommand("p_ALTERANDO_VALORES_VD_DETALHADA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VALOR_PAGO", divida.ValorPago);
            cmd.Parameters.AddWithValue("@ID", divida.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable SelectVendaPorData(string date1, string date2, string id)
        {
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand cmd = new SqlCommand("p_SELECT_VENDA_DETALHADA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DATA1", date1);
            cmd.Parameters.AddWithValue("@DATA2", date2);          
            cmd.Parameters.AddWithValue("@ID", id);

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

           con.Close();

            return dt;  
        }

    }
}

