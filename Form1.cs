using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                //Colher valores:

                double peso = double.Parse(txbPeso.Text);
                double haltura = double.Parse(txbAltura.Text);


                double res = (peso / Math.Pow(haltura, 2));

                //Especificações das condições:

                if (res <= 18.5)
                {

                    lblCondicao.Text = "Abaixo do peso";
                    lblCondicao.ForeColor = Color.LightSalmon;
                }
                else if (res >= 18.6 && res <= 24.9)
                {
                    lblCondicao.Text = "Peso ideal";
                    lblCondicao.ForeColor = Color.Green;
                }
                else if (res >= 25 && res <= 29.9)
                {
                    lblCondicao.Text = "Levimento acima";
                    lblCondicao.ForeColor = Color.Orange;
                }
                else if (res >= 30 && res <= 34.9)
                {
                    lblCondicao.Text = "Obsidade grau I";
                    lblCondicao.ForeColor = Color.DarkOrange;
                }
                else if (res >= 35 && res <= 39.9)
                {
                    lblCondicao.Text = "Obsidade severa";
                    lblCondicao.ForeColor = Color.OrangeRed;
                }
                else if (res >= 40)

                {
                    lblCondicao.Text = "Obsidade morbida";
                    lblCondicao.ForeColor = Color.Red;
                }

                //Obter resultados:

                txbIMC.Text = Math.Round(res, 2).ToString();
            }
            catch
            {
                MessageBox.Show("Resultado inválido, não ouve dados informados!");
                //Limpar os dados:
               txbIMC.Clear();
               txbPeso.Clear();
               txbAltura.Clear();


            }
        }
            
            
     
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbIMC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
