using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculaora_Windows_Forms
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void SetarText(string text)
        {   
            if(text == string.Empty)
            {
                textResultado.Text = "";
            }
            textResultado.Text += text;

            SetarLabel();
        }
        private void SetarLabel()
        {
            if(operacao != string.Empty)
            {
                labelOperacao.Text = Convert.ToString(valor1) + ' ' + operacao + ' ' + textResultado.Text;
            }
            else
            {
                labelOperacao.Text = Convert.ToString(valor1);
            }
            
        }
        private void SetarOperacao(string operacao_)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            labelOperacao.Text = Convert.ToString(valor1) + ' ' + operacao_;
            operacao = operacao_;
        }
        //Botão %
        private void button1_Click(object sender, EventArgs e)
        {
            SetarOperacao("%");
        }
       
        //Botão APAGAR
        private void button4_Click(object sender, EventArgs e)
        {
            if(textResultado.Text.Length <= 0)
                return;

            textResultado.Text = textResultado.Text.Remove(textResultado.Text.Length - 1, 1);
        }
        // Botão CE
        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            labelOperacao.Text = "";
        }

        //Botão C
        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            labelOperacao.Text = "";
        }

        //Botão =
        private void button16_Click_1(object sender, EventArgs e)
        {
            if(operacao == "") 
                return;

            if(textResultado.Text == "") 
                return;

            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            decimal temp_valor = 0;

            switch (operacao)
            {
                case "+":
                    temp_valor = valor1 + decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    break;
                case "-":
                    temp_valor = valor1 - decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    break;
                case "x":
                    temp_valor = valor1 * decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    break;
                case "*":
                    temp_valor = valor1 * decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    break;
                case "/":
                    temp_valor = valor1 / decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    break;
                case "%":
                    textResultado.Text = "N/A";
                    break;
                default:
                    break;
            }
            labelOperacao.Text += valor2;
            textResultado.Text = temp_valor.ToString();

            valor1 = 0;
            valor2 = 0;
        }

        //Botão ,
        private void button15_Click(object sender, EventArgs e)
        {
            SetarText(",");
        }
        //Botão 0
        private void button18_Click(object sender, EventArgs e)
        {
            SetarText("0");
        }
        private void button22_Click(object sender, EventArgs e)
        {
            SetarText("1");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SetarText("2");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SetarText("3");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SetarText("");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SetarText("5");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetarText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetarText("7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetarText("8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetarText("9");
        }

        //Botão Dividir
        private void button8_Click(object sender, EventArgs e)
        {
            SetarOperacao("/");
        }

        //Botão X
        private void button9_Click(object sender, EventArgs e)
        {
            SetarOperacao("x");
        }

        //Botão +
        private void button11_Click(object sender, EventArgs e)
        {
            SetarOperacao("+");
        }
        //Botão -
        private void button10_Click(object sender, EventArgs e)
        {
            SetarOperacao("-");
        }

        
    }
}
