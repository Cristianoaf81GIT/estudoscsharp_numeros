using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 109;
            //if(int.TryParse("1981", out num))
            //{
            //    lbResultado.Text = num.ToString();
            //}
            //else 
            //{
            //    lbResultado.Text = "Não foi possível fazer conversão";
            //}
            //lbResultado.Text = num.ToString("X"); // hexa
            //lbResultado.Text = num.ToString("D"); // decimal
            //lbResultado.Text = num.ToString("C"); // moeda corrente
            //lbResultado.Text = num.ToString("X2"); // hexa com 2 digitos
            //lbResultado.Text = num.ToString("D2"); // decimal com 2 digitos
            //lbResultado.Text = Convert.ToString(num, 2); // base binária
            //lbResultado.Text = Convert.ToString(num, 8); // base octal
            //lbResultado.Text = Convert.ToString(num, 16); // base hexa
            double pi = Math.PI;
            double valorE = Math.E;
            double seno = Math.Sin(3);
            double coseno = Math.Cos(30);
            double potencia = Math.Pow(2, 2);
            double raizQuadrada = Math.Sqrt(49);
            var numero = Math.Round(158.74);
            double inteiro = Math.Truncate(32.57);
            double floor = Math.Floor(4597.739);
            double ceil = Math.Ceiling(3498.399);
            lbResultado.Text = ceil.ToString();
        }

        
    }
}
