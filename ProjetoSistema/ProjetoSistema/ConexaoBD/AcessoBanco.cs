using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema.ConexaoBD
{
    public class AcessoBanco
    {

        // Construtor 
        // Abrir Conexão
        // Fechar Conexão
        // Abrir uma transação
        // Fechar uma transação

        #region Variaveis

        private SqlConnection conectar;
        private string strConn = String.Empty;
        private SqlTransaction Tran;
        private SqlDataAdapter da;

        #endregion Variaveis

        #region Construtor


        //
        //Construtor da classe AcessoBancoDB
        //
        public AcessoBanco()
        {

        }



        #endregion Construtor

        #region Metodos

        // Método que cria uma conexão com o banco de dados.
        public SqlConnection ConcetarBD()
        {
            //SqlConnection con = new SqlConnection();
            try
            {
                if (strConn.Trim().Length == 0)
                {


                    strConn = ConfigurationManager.ConnectionStrings["stringConexao"].ToString();

                }
                conectar = new SqlConnection(strConn);
                return conectar;
            }
            catch (Exception)
            {
                throw;
            }

        }

        // Abre uma conexão com o banco de dados.
        public SqlConnection AbrirConexao()
        {
            conectar.Open();
            return conectar;

        }

        // Fecha uma conexão com o banco de dados.
        public void FecharConexao()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

        // Metodo que inicia uma transação
        public SqlTransaction IniciarSqlTransaction(SqlCommand cmd)
        {
            //Começa uma transação local
            Tran = conectar.BeginTransaction("TransacaoSimples");
            cmd.Connection = conectar;
            cmd.Transaction = Tran;
            return Tran;

        }

        //// Metodo que finaliza uma transação
        public void FinalizarTransacao(Boolean ret)
        {
            if (ret)
            {
                Tran.Commit();
            }
            else
            {
                Tran.Rollback();
            }
        }


        public DataTable ExecDataTable(string pNomeStoredProcedure)
        {
            DataTable dt = new DataTable();
            using (SqlCommand comando = new SqlCommand(pNomeStoredProcedure, conectar))
            {
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                try
                {
                    adapter.Fill(dt);
                }
                catch (InvalidOperationException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return dt;
        }

        public DataTable ExecDataTable(String pNomeStoredProcedure, SqlConnection conn)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand(pNomeStoredProcedure))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(pNomeStoredProcedure, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion Metodos
    }
}
