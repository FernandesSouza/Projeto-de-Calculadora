using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        double n1 = 0, n2 = 0;
        string operacao;

        public calculadora()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "0";

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "9";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += ",";
        }
         
        private void btn_igual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {

                txt_Resultado.Text = Convert.ToString( n1 + n2 );


            } else if (operacao == "SUBTRACAO")
            {

                txt_Resultado.Text = Convert.ToString(n1 - n2);

            } else if (operacao == "MULTIPLICACAO")
            {

                txt_Resultado.Text = Convert.ToString(n1 * n2);

            } else if (operacao == "DIVISAO")
            {

                txt_Resultado.Text = Convert.ToString(n1 / n2); 

            } else if (operacao == "PORCENTAGEM")
            {


                txt_Resultado.Text = Convert.ToString((n1 * n2)/100);

            }
            




            
        }
       

        private void btn_1x_Click(object sender, EventArgs e)
        {

            if(txt_Resultado.Text != "")
            {

                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "INVERSO";
                lbl_operacao.Text = "1/x";

            }

        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if(txt_Resultado.Text != "")
            {

                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);

                txt_Resultado.Text = "";
                operacao = "SUBTRACAO";
                lbl_operacao.Text = "-";

            }
            else
            {
                MessageBox.Show("INFORME UM VALOR");
            }

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

            if (txt_Resultado.Text != "")
            {
                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);

                txt_Resultado.Text = "";
                operacao = "MULTIPLICACAO";
                lbl_operacao.Text = "x";

            }
            else
            {
                MessageBox.Show("INFORME UM VALOR");
            }

                
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {

            if (txt_Resultado.Text != "")
            {
                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "DIVISAO";
                lbl_operacao.Text = "/";


            }
            else
            {

                MessageBox.Show("INFORME UM VALOR");

            }


        }


              

        private void btn_soma_Click(object sender, EventArgs e)
        {
           if(txt_Resultado.Text != "")
            {


                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);

                txt_Resultado.Text = "";
                operacao = "SOMA";
                lbl_operacao.Text = "+";


            } else
            {

                MessageBox.Show("INFORME UM VALOR");


            }


        }
        private void btn_raiz_Click(object sender, EventArgs e)
        {
            
            if (txt_Resultado.Text != "")
            {
                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);

                txt_Resultado.Text = Convert.ToString( Math.Sqrt(n1));


            } else
            {

                MessageBox.Show("INFORME UM VALOR");

            } 

        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {

                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);

                txt_Resultado.Text = Convert.ToString(Math.Pow(n1, 2));


            }
            else
            {


                MessageBox.Show("INFORME O VALOR");

            }

        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {

            if (txt_Resultado.Text != "")
            {

                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = Convert.ToString(1.0/n1);



            }
            else
            {

                MessageBox.Show("INFORME O VALOR");

            }



        }
        private void button21_Click(object sender, EventArgs e)
        {

            if (txt_Resultado.Text != "")
            {

                n1 = Convert.ToDouble(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = Convert.ToString(n1 = -n1);



            }
            else
            {

                MessageBox.Show("INFORME O VALOR");

            }

        }


        private void btn_c_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            lbl_operacao.Text = "";
            txt_Resultado.Text = "";
        }

       

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            lbl_operacao.Text = "";
        }
    }
}
