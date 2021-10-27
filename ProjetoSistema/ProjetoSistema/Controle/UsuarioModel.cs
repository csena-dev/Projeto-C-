using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoSistema.Controle
{
    public class UsuarioModel
    {
        private string login_usur;
        private string senha_usur;
        private string status_usur;

        public string Login_usur { get; set; }

        public string Senha_usur { get; set; }

        public int Status_Usur { get; set; }

    }
}
