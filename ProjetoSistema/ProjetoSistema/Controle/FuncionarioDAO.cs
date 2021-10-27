using ProjetoSistema.ConexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class FuncionarioDAO
    {
        #region Variaveis

        private SqlConnection conn = null;
        private AcessoBanco conexao = null;
        private int retorno = 0;

        #endregion Variaveis

        public FuncionarioDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConcetarBD();
        }


        #region Metodos

        public int IncluirFuncionarioDAO(FuncionarioModel pFuncionarioModel)
        {

            try
            {
                using (SqlCommand comando = new SqlCommand("uspFuncionarioIncluir", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOM_FUNC",        pFuncionarioModel.nom_Func);
                    comando.Parameters.AddWithValue("@DAT_NASC",        pFuncionarioModel.data_nasc);
                    comando.Parameters.AddWithValue("@DAT_CONTRATADO",  pFuncionarioModel.data_contr);
                    comando.Parameters.AddWithValue("@COD_STAT",        pFuncionarioModel.cod_stat);

                    conexao.AbrirConexao();
                    retorno = comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.FecharConexao();
            }

            return retorno;
        }

        public DataTable ObterTodosFuncionarios()
        {
            try
            {
                return conexao.ExecDataTable("uspFuncionarioLocalizar", conn);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ObterTodosStatus()
        {
            try
            {
                return conexao.ExecDataTable("uspLocalizarFuncionarioStatus", conn);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Metodos
    }
}
