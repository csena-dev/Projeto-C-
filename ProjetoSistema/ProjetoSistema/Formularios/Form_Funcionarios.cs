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
    public partial class Form_Funcionarios : Form
    {
        #region Variaveis

        private enum OPERACAO { INCLUIR}
        private OPERACAO enuAcao;
        public string validacao;

        string[] nomeColuna = { "Funcionario", "Dt Nascimento", "Dt Contratação", "Status"};

        bool[] colunaVisivel = { true, true, true, true};

        FuncionarioControle funcionarioControle = null;

        #endregion Variaveis


        public Form_Funcionarios()
        {
            InitializeComponent();
            this.funcionarioControle = new FuncionarioControle();
        }

        private void Form_Funcionarios_Load(object sender, EventArgs e)
        {
            PreencherComboStatus();
            TelaInicial(true);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TxtNome.Focus();

            //Validãção dos campos obrigatórios
            if (!Validar())
            {
                return;
            }
            int retorno = 0;

            validacao = enuAcao.ToString();
            FuncionarioModel funcionarioModel = new FuncionarioModel();

            funcionarioModel.nom_Func = TxtNome.Text.Trim();
            funcionarioModel.data_nasc = Convert.ToDateTime(TxtDataNascimento.Text.Trim());
            funcionarioModel.data_contr = Convert.ToDateTime(TxtDataContratado.Text.Trim());
            funcionarioModel.cod_stat = ComboStatus.SelectedIndex + 1;


            retorno = funcionarioControle.IncluirFuncionarioControle(funcionarioModel);


            if (retorno != 0)
            {
                TelaInicial(true);

                if (validacao == "INCLUIR")
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionario. Por favor contatar os DEVS.");
            }
        }

        //Inicia a tela de Funcnionario
        private void TelaInicial(Boolean bolIni)
        {
            LimparCampos();
            //PreencherComboStatus();

            if (bolIni)
            {
                RefreshDataGrid(DtgFuncionarios, true);
                EstilizarDataGridView.EstiloTituloColuna(DtgFuncionarios, nomeColuna, colunaVisivel);
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
            List<FuncionarioModel> listaFuncionarios = new List<FuncionarioModel>();
            FuncionarioControle funcionarioControle = new FuncionarioControle();

            try
            {
                dtg.DataSource = null;
                dtg.Rows.Clear();
                dtg.DataSource = funcionarioControle.ObterRegistrosFuncionarios();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void LimparCampos()
        {

            TxtNome.Text = string.Empty;
            TxtDataNascimento.Text = string.Empty;
            TxtDataContratado.Text = string.Empty;
            //ComboStatus.Text = string.Empty;
        }

        private Boolean Validar()
        {
            if (TxtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblNome.Text + " é obrigatório.");
                TxtNome.Focus();
                return false;
            }

            if (TxtDataNascimento.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblDataNascimento.Text + " é obrigatório.");
                TxtDataNascimento.Focus();
                return false;
            }

            if (TxtDataContratado.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblDataContratado.Text + " é obrigatório.");
                TxtDataContratado.Focus();
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
            FuncionarioControle funcionarioControle = new FuncionarioControle();

            ComboStatus.DataSource = null;
            ComboStatus.ValueMember = "DESCR_STAT";
            ComboStatus.DataSource = funcionarioControle.ObterComboFuncionario();

        }


    }
}
