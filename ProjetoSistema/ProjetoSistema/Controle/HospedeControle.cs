using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class HospedeControle
    {
        HospedeDAO hospedeDAO = null;

        public HospedeControle()
        {
            hospedeDAO = new HospedeDAO();
        }

        public int IncluirHospedeControle(HospedeModel pHospedeModel)
        {
            try
            {
                return hospedeDAO.IncluirHospedeDAO(pHospedeModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ObterRegistrosHospedes()
        {
            return hospedeDAO.ObterTodosHospedes();
        }


        public DataTable ObterComboQuarto()
        {
            return hospedeDAO.ObterQuartos();
        }
    }
}
