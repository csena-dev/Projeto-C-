using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoSistema.Controler
{
    public class HospedeModel
    {
        private string nom_hospede;
        private string cpf_hospede;
        private string dat_checkin;
        private string dat_checkout;
        private string num_quart;

        public string Nom_hospede { get; set; }

        public string Cpf_hospede { get; set; }

        public DateTime Dat_checkin { get; set; }

        public DateTime Dat_checkout { get; set; }

        public int Num_quart { get; set; }

    }
}
