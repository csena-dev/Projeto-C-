using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoSistema.Formularios
{
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuario form = new Form_Usuario();
            form.ShowDialog();
            form.Dispose();
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Funcionarios form = new Form_Funcionarios();
            form.ShowDialog();
            form.Dispose();
        }

        private void novoHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hospede form = new Form_Hospede();
            form.ShowDialog();
            form.Dispose();
        }

        private void calculadoraIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Calculadora form = new Form_Calculadora();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
