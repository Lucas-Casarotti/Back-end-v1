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

namespace CalculadoraWF
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            //txtResultado.Text = txtResultado.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            //txtResultado.Text = txtResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            //txtResultado.Text = txtResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            //txtResultado.Text = txtResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            //txtResultado.Text = txtResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            //txtResultado.Text = txtResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            //txtResultado.Text = txtResultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            //txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            //txtResultado.Text = txtResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            //txtResultado.Text = txtResultado.Text + "9";
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }


        // FUNÇÃO DOS BOTÕES
        private void btnadicao_Click(object sender, EventArgs e)
        {
            // CONVERTENDO A STRING RESULTADO EM DECIMAL 
            // CultureInfo.InvariantCulture UTILIZANDO PARA REALIZAR OPERACOES COM PONTO
            //A VARIAVEL VALOR1 TA RECEBENDO O(S) PRIMEIRO NUMERO QUE FOI CLICADO
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
            
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            //A VARIAVEL VALOR2 TA RECEBENDO O(S) SEGUNDO NUMERO QUE FOI CLICADO
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                //CONVERTENDO O A SOMA EM STRING PARA EXIBIR NO TXT
                txtResultado.Text = Convert.ToString(valor1 + valor2);

            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }



        }
    }
}
