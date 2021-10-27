using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class FuncionarioControle
    {
        FuncionarioDAO funcionarioDAO = null;

        public FuncionarioControle()
        {
            funcionarioDAO = new FuncionarioDAO();
        }

        public int IncluirFuncionarioControle(FuncionarioModel pFuncionarioModel)
        {
            try
            {
                return funcionarioDAO.IncluirFuncionarioDAO(pFuncionarioModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ObterRegistrosFuncionarios()
        {
            return funcionarioDAO.ObterTodosFuncionarios();
        }


        public DataTable ObterComboFuncionario()
        {
            return funcionarioDAO.ObterTodosStatus();
        }

    }
}
