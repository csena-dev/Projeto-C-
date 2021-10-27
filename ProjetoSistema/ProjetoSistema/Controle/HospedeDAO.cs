using ProjetoSistema.ConexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class HospedeDAO
    {
        #region Variaveis

        private SqlConnection conn = null;
        private AcessoBanco conexao = null;
        private int retorno = 0;

        #endregion Variaveis

        public HospedeDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConcetarBD();
        }


        #region Metodos

        public int IncluirHospedeDAO(HospedeModel pHospedeModel)
        {

            try
            {
                using (SqlCommand comando = new SqlCommand("uspHospedeIncluir", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOM_HOSPEDE", pHospedeModel.Nom_hospede);
                    comando.Parameters.AddWithValue("@CPF_HOSPEDE", pHospedeModel.Cpf_hospede);
                    comando.Parameters.AddWithValue("@DAT_CHECKIN", pHospedeModel.Dat_checkin);
                    comando.Parameters.AddWithValue("@DAT_CHECKOUT", pHospedeModel.Dat_checkout);
                    comando.Parameters.AddWithValue("@NUM_QUART", pHospedeModel.Num_quart);

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

        public DataTable ObterTodosHospedes()
        {
            try
            {
                return conexao.ExecDataTable("uspHospedeLocalizar", conn);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ObterQuartos()
        {
            try
            {
                return conexao.ExecDataTable("uspLocalizarQuartos", conn);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Metodos
    }

}
