using ProjetoSistema.Formularios.Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoSistema
{
    public class LoginControle
    {
        LoginDAO loginDAO = null;

        public LoginControle()
        {
            loginDAO = new LoginDAO();
        }

        public int IncluirUsuarioControler(LoginModel pLoginModel)
        {
            try
            {
                return loginDAO.IncluirUsuarioDAO(pLoginModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<LoginModel> ValidarUsuario(LoginModel pLoginModel)
        {
            List<LoginModel> listaUsuario = new List<LoginModel>();
            LoginModel loginModel = new LoginModel();

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = loginDAO.LocalizarUsuario(pLoginModel);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        loginModel.Login_Usur = dr["login_usur"].ToString();
                        loginModel.Senha_Usur = dr["senha_usur"].ToString();

                        listaUsuario.Add(loginModel);
                    }
                }
                return listaUsuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }


}
