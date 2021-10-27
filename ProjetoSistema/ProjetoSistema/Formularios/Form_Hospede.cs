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
    public partial class Form_Hospede : Form
    {

        #region Variaveis

        private enum OPERACAO { INCLUIR }
        private OPERACAO enuAcao;
        public string validacao;

        string[] nomeColuna = { "Hospede", "CPF", "Checkin", "Checkout", "Quarto" };

        bool[] colunaVisivel = { true, true, true, true, true };

        HospedeControle hospedeControle = null;

        #endregion Variaveis

        public Form_Hospede()
        {
            InitializeComponent();
            this.hospedeControle = new HospedeControle();
        }

        private void Form_Hospede_Load(object sender, EventArgs e)
        {
            PreencherComboQuarto();
            TelaInicial(true);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            enuAcao = OPERACAO.INCLUIR;
            //AtribuirValoresDalinhaDoDataGridView();
            TxtNome.Focus();

            //Validãção dos campos obrigatórios
            if (!Validar())
            {
                return;
            }
            int retorno = 0;

            validacao = enuAcao.ToString();
            HospedeModel hospedeModel = new HospedeModel();

            hospedeModel.Nom_hospede  = TxtNome.Text.Trim();
            hospedeModel.Cpf_hospede  = TxtCPF.Text.Trim();
            hospedeModel.Dat_checkin  = Convert.ToDateTime(DatCheckin.Text.Trim());
            hospedeModel.Dat_checkout = Convert.ToDateTime(DatCheckout.Text.Trim());
            hospedeModel.Num_quart    = ComboQuarto.SelectedIndex + 1;


            retorno = hospedeControle.IncluirHospedeControle(hospedeModel);


            if (retorno != 0)
            {
                TelaInicial(true);

                if (validacao == "INCLUIR")
                {
                    MessageBox.Show("Hospede cadastrado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Hospede. Por favor contatar os DEVS.");
            }
        }

        //Inicia a tela de Hospede
        private void TelaInicial(Boolean bolIni)
        {
            LimparCampos();
            //PreencherComboStatus();

            if (bolIni)
            {
                RefreshDataGrid(DtgHospedes, true);
                EstilizarDataGridView.EstiloTituloColuna(DtgHospedes, nomeColuna, colunaVisivel);
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
            List<HospedeModel> listaHospedes = new List<HospedeModel>();
            HospedeControle hospedeControle = new HospedeControle();

            try
            {
                dtg.DataSource = null;
                dtg.Rows.Clear();
                dtg.DataSource = hospedeControle.ObterRegistrosHospedes();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void LimparCampos()
        {

            TxtNome.Text    = string.Empty;
            TxtCPF.Text     = string.Empty;
            DatCheckin.Text = string.Empty;
            DatCheckin.Text = string.Empty;
        }

        private Boolean Validar()
        {
            if (TxtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblNome.Text + " é obrigatório.");
                TxtNome.Focus();
                return false;
            }

            if (TxtCPF.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblCpf.Text + " é obrigatório.");
                TxtCPF.Focus();
                return false;
            }

            if (DatCheckin.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblCheckin.Text + " é obrigatório.");
                DatCheckin.Focus();
                return false;
            }

            if (DatCheckout.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblCheckout.Text + " é obrigatório.");
                DatCheckout.Focus();
                return false;
            }

            if (ComboQuarto.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo " + LblQuarto.Text + " é obrigatório.");
                ComboQuarto.Focus();
                return false;
            }

            return true;
        }

        //Preencher Combo Quarto
        private void PreencherComboQuarto()
        {
            HospedeControle hospedeControle = new HospedeControle();

            ComboQuarto.DataSource = null;
            ComboQuarto.ValueMember = "NOM_QUART";
            ComboQuarto.DataSource = hospedeControle.ObterComboQuarto();

        }
    }
}
