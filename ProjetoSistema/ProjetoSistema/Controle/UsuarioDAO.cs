using ProjetoSistema.ConexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema.Controle
{
    public class UsuarioDAO
    {
        #region Variaveis

        private SqlConnection conn = null;
        private AcessoBanco conexao = null;
        private int retorno = 0;

        #endregion Variaveis

        public UsuarioDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConcetarBD();
        }


        #region Metodos

        public int IncluirUsuarioDAO(UsuarioModel pUsuarioModel)
        {

            try
            {
                using (SqlCommand comando = new SqlCommand("uspUsuarioIncluir", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@LOGIN_USUR", pUsuarioModel.Login_usur);
                    comando.Parameters.AddWithValue("@SENHA_USUR", pUsuarioModel.Senha_usur);
                    comando.Parameters.AddWithValue("@COD_STAT", pUsuarioModel.Status_Usur);


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

        public DataTable ObterTodosUsuarios()
        {
            try
            {
                return conexao.ExecDataTable("uspUsuarioLocalizar", conn);
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
                return conexao.ExecDataTable("uspLocalizarUsuarioStatus", conn);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Metodos
    }
}

