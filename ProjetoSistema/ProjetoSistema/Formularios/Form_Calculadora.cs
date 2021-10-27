using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoSistema.Formularios
{
    public partial class Form_Calculadora : Form
    {
        public Form_Calculadora()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(TxtPeso.Text);
            altura = Convert.ToDouble(TxtAltura.Text);
            imc = peso / (altura * altura);
            if (imc < 20) { 
                LblResultado.Text = "IMC abaixo do Peso \n Seu IMC: " + imc;
                LblResultado.ForeColor = Color.Yellow;
            }
            else
                if (imc >= 20 && imc < 25) { 
                LblResultado.Text = "Peso Normal\n Seu IMC: " + imc;
                LblResultado.ForeColor = Color.Green;
            }
            else
                if (imc >= 25 && imc < 30) { 
                LblResultado.Text = "Sobre Peso\n Seu IMC: " + imc;
                LblResultado.ForeColor = Color.Red;
            }
            else
                if (imc >= 30 && imc < 40) { 
                LblResultado.Text = "Obeso\n Seu IMC: " + imc;
                LblResultado.ForeColor = Color.Red;
            }
            else
                LblResultado.Text = "Obeso Mórbido!\nSeu IMC :" + imc;
                LblResultado.ForeColor = Color.DarkRed;
        }
    }
}
