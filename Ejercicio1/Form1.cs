using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTransformarAValorAbs_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtNum.Text);

            double valorAbs = num >= 0 ? num : -num;

            labResultado.Text = "El valor absoluto es " + valorAbs;
        }

        private void btnRedondearValor_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtValorDosCifras.Text);

            int valorRedondeado = ((int)num) + ((num % 1) >= 0.5 ? 1 : 0); // Si Num que anteriormente fue declarado como tipo de dato double, le reasignamos el tipo de dato INT para que nos devuelva el numero entero, lo que dice en el ternario es que si el resto de num es mayor o igual a 5 nos retorna 1, si es menor nos retorna 0.. este es el codigo principal para este algoritmo, porque al ser mayor a 0.5 nos devuelve 1, por ende ese 1 se lo suma al num inicial, de esa manera lo redondea al proximo, si es menor a 0.5 devuelve 0 por ende redondea al valor menor.

            labRedondeado.Text = "El valor redondeado es " + valorRedondeado;
        }
    }
}
