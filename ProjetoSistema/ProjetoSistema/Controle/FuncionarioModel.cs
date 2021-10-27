using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class FuncionarioModel
    {
        private int Cod_func;
        private string Nom_Func;
        private DateTime Data_nasc;
        private DateTime Data_contr;
        private int Cod_stat;


        public int cod_func { get; set; }

        public string nom_Func { get; set; }

        public DateTime data_nasc { get; set; }

        public DateTime data_contr { get; set; }

        public int cod_stat { get; set; }

    }
}
