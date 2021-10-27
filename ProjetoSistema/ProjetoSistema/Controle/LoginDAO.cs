using ProjetoSistema.ConexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema.Formularios.Controle
{
    public class LoginDAO
    {
        private SqlConnection conn = null;
        private AcessoBanco conexao = null;
        private int retorno = 0;

        public LoginDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConcetarBD();
        }

        public int IncluirUsuarioDAO(LoginModel pLoginModel)
        {

            try
            {
                using (SqlCommand comando = new SqlCommand("uspUsuarioIncluir", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOM_USUR", pLoginModel.Login_Usur);
                    comando.Parameters.AddWithValue("@SENHA_USUR", pLoginModel.Senha_Usur);

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



        public DataTable LocalizarUsuario(LoginModel pLoginModel)
            {
                DataTable dt = new DataTable();
                using (SqlCommand comando = new SqlCommand("uspUsuarioLocalizarLogin", this.conn))
                {
                    try
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(comando);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Prepare();
                        comando.Parameters.AddWithValue("@LOGIN_USUR", pLoginModel.Login_Usur);
                        comando.Parameters.AddWithValue("@SENHA_USUR", pLoginModel.Senha_Usur);
                        adapter.Fill(dt);

                    }
                    catch (InvalidCastException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw;
                    }

                }
                return dt;
            }
    }
}
