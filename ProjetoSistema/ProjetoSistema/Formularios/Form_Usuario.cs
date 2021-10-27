using ProjetoSistema.Controle;
using ProjetoSistema.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoSistema.Formularios
{
    public partial class Form_Usuario : Form
    {
        #region Variaveis

        private enum OPERACAO { INCLUIR }
        private OPERACAO enuAcao;
        public string validacao;

        string[] nomeColuna = { "Login", "Status" };

        bool[] colunaVisivel = { true, true};

        UsuarioControle usuarioControle = null;

        #endregion Variaveis


        public Form_Usuario()
        {
            InitializeComponent();
            this.usuarioControle = new UsuarioControle();
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
            PreencherComboStatus();
            TelaInicial(true);
        }




        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Focus();

            //Validãção dos campos obrigatórios
            if (!Validar())
            {
                return;
            }
            int retorno = 0;

            validacao = enuAcao.ToString();
            UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel.Login_usur = TxtUsuario.Text.Trim();
            usuarioModel.Senha_usur = TxtSenha.Text.Trim();
            usuarioModel.Status_Usur = ComboStatus.SelectedIndex + 1;

            retorno = usuarioControle.IncluirUsuarioControle(usuarioModel);


            if (retorno != 0)
            {
                TelaInicial(true);

                if (validacao == "INCLUIR")
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Usuario. Por favor contatar os DEVS.");
            }
        }


        //Inicia a tela de Funcnionario
        private void TelaInicial(Boolean bolIni)
        {
            LimparCampos();
            //PreencherComboStatus();

            if (bolIni)
            {
                RefreshDataGrid(DtgUsuarios, true);
                EstilizarDataGridView.EstiloTituloColuna(DtgUsuarios, nomeColuna, colunaVisivel);
            }

        }

        //Atualiza DatadrigView
        private void RefreshDataGrid(DataGridView dtg, Boolean bolRefresh)
        {
            if (bolRefresh) { PreencherDataGridView(dtg); }

        }
        //Preenche os dados no DataGridView
        private void PreencherDataGridView(DataGridView dtg)
        {
            List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();
            UsuarioControle usuarioControle = new UsuarioControle();

            try
            {
                dtg.DataSource = null;
                dtg.Rows.Clear();
                dtg.DataSource = usuarioControle.ObterRegistrosUsuario();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void LimparCampos()
        {

            TxtUsuario.Text = string.Empty;
            TxtSenha.Text = string.Empty;
        }

        private Boolean Validar()
        {
            if (TxtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblUsuario.Text + " é obrigatório.");
                TxtUsuario.Focus();
                return false;
            }

            if (TxtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblSenha.Text + " é obrigatório.");
                TxtSenha.Focus();
                return false;
            }


            if (ComboStatus.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblStatus.Text + " é obrigatório.");
                ComboStatus.Focus();
                return false;
            }

            return true;
        }


        //Preencher combo Status
        private void PreencherComboStatus()
        {
            UsuarioControle usuarioControle = new UsuarioControle();

            ComboStatus.DataSource = null;
            ComboStatus.ValueMember = "DESCR_STAT_USUR";
            ComboStatus.DataSource = usuarioControle.ObterComboUsuario();

        }


    }
}
