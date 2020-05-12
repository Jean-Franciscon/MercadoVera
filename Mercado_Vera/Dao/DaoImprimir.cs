using dllDao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Vera.Dao
{
    class DaoImprimir
    {
        Conexao conexao = new Conexao();

        public SqlDataReader SelectEmpresa()
        {
            string query = "select E.EMP_NOME_FANT,E.EMP_CNPJ, ED.END_RUA, ED.END_NUMERO from TBL_EMPRESA AS E"
            + " INNER JOIN TBL_EMP_END AS EE ON EE.EMP_ID = E.EMP_ID"
            + " INNER JOIN TBL_ENDERECO AS ED ON ED.END_ID = EE.END_ID";

            SqlDataReader dr = conexao.CarregarVariosDados(query);

            return dr;
        }

        public SqlDataReader SelectLestFechamento()
        {
            string query = "SELECT FECH_CREDIARIO, FECH_CREDITO, FECH_DEBITO, FECH_DINHEIRO , CONVERT(VARCHAR(10),FECH_DATA, 103) AS DATA, CONVERT(VARCHAR(8),FECH_HORA, 108) AS HORA,"
            +" FECH_TOTAL FROM TBL_FECHAMENTO where FECH_ID = (select max(FECH_ID) from TBL_FECHAMENTO)";

            SqlDataReader dr = conexao.CarregarVariosDados(query);

            return dr;
        }

        public DataTable SelectNotaFiscal()
        {
            string query = "SELECT  C.CLI_NOME, V.VEN_ID, V.VEN_PAGAMENTO,V.VEN_PARCELA, P.PROD_NOME, IV.ITEM_QTD, IV.ITEM_VALOR, V.VEN_TOTAL, CONVERT(VARCHAR(10),V.VEN_DATE, 103) AS DATA FROM TBL_ITEM_VENDA AS IV"
           +" INNER JOIN TBL_PRODUTO AS P ON P.PROD_ID = IV.PROD_ID"
           +" INNER JOIN TBL_VENDA AS V ON V.VEN_ID = IV.VEN_ID"
           +" INNER JOIN TBL_CLIENTE AS C ON C.CLI_ID = V.CLI_ID"
           +" WHERE V.VEN_ID = (SELECT MAX(VEN_ID) FROM TBL_VENDA)"
           +" ORDER BY IV.VEN_ID";

            DataTable dt = conexao.CarregarDados(query);

            return dt;
        }
    }
}
