using ProjetoSistema.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ProjetoSistema
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                {
                    return;
                }

                LoginModel loginomodel = new LoginModel();
                List<LoginModel> lista = new List<LoginModel>();

                loginomodel.Login_Usur = TxtLogin.Text.Trim();
                loginomodel.Senha_Usur = TxtSenha.Text.Trim();

                LoginControle usuarioController = new LoginControle();
                lista = usuarioController.ValidarUsuario(loginomodel);

                if (lista.Count == 0)
                {
                    LblMensagem.Visible = true;
                    LblMensagem.Text = "Usuário não encontrado!\n\rVerifique se o nome do usúario ou senha estão corretos.";
                }
                else
                {
                    this.Hide();
                    Form_Cadastro form = new Form_Cadastro();
                    form.ShowDialog();
                    form.Dispose();

                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: => " + ex.Message);
                throw;
            }

        }

        private Boolean Validar()
        {
            try
            {
                if (TxtLogin.Text.Trim().Length == 0)
                {

                    MessageBox.Show("O campo " + LblLogin.Text + " é obrigatório.");
                    TxtLogin.Focus();
                    return false;

                }
                if (TxtSenha.Text.Trim().Length == 0)
                {
                    MessageBox.Show("O campo " + LblSenha.Text + " é obrigatório.");
                    TxtSenha.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
