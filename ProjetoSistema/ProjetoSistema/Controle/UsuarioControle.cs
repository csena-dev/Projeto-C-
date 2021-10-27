using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoSistema.Controle
{
    public class UsuarioControle
    {
        UsuarioDAO usuarioDAO = null;

        public UsuarioControle()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public int IncluirUsuarioControle(UsuarioModel pUsuarioModel)
        {
            try
            {
                return usuarioDAO.IncluirUsuarioDAO(pUsuarioModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ObterRegistrosUsuario()
        {
            return usuarioDAO.ObterTodosUsuarios();
        }


        public DataTable ObterComboUsuario()
        {
            return usuarioDAO.ObterTodosStatus();
        }
    }
}
