using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    
    public partial class FColores : Form
    { 
        int contadorAmarillo, contadorAzul, contadorRojo;
        public FColores()
        {
            InitializeComponent();
            BackColor = Color.White; 

           

        }

        private void FColores_Load(object sender, EventArgs e)
        {
           
        }

      

        public void BAmarillo_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Blue)
            {

                BackColor = Color.Green;
            }
            else if (BackColor == Color.Red)
            {
                BackColor = Color.Orange;
            }
            else if (BackColor == Color.Purple)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Yellow;
            }

            BCerrar.Visible = true;

            contadorAmarillo++;
        }

        public void BRojo_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Blue)
            {

                BackColor = Color.Purple;
            }
            else if (BackColor == Color.Yellow)
            {
                BackColor = Color.Orange;
            }
            else if (BackColor == Color.Green)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Red;
            }
            BCerrar.Visible = true;


            contadorRojo++;
           
        }

        private void BAzul_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red)
            {

                BackColor = Color.Purple;
            }
            else if (BackColor == Color.Yellow)
            {
                BackColor = Color.Green;
            }
            else if (BackColor == Color.Orange)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Blue;
            }
            BCerrar.Visible = true;

            contadorAzul++;
           
        }

        public void BCerrar_Click(object sender, EventArgs e)
        {
            /* Aca tendria que verse el MessageBox.Show con las veces que fue seleccionado cada uno, luego de esto que se 
            ejecute el CLOSE */
            if ((contadorAmarillo == contadorAzul) && (contadorAzul == contadorRojo) && (contadorRojo == contadorAmarillo) && (contadorAmarillo == contadorRojo))
            {
                MessageBox.Show(
                    $"Todos los botones fueron presionados las mismas veces: \n \n Amarillo: {contadorAmarillo} \n Rojo: {contadorRojo} \n Azul: {contadorAzul} ");

                MessageBox.Show(
                    $"1°. - Color “Amarillo”: {contadorAmarillo} veces \n 1°. - Color “Azul”: {contadorAzul} veces \n 1°. - Color “Rojo”: {contadorRojo} vez"
                );


            } else if ((contadorAmarillo > contadorAzul ) && (contadorAmarillo > contadorRojo))
            {
                MessageBox.Show($"El boton Amarillo fue el mas seleccionado: {contadorAmarillo} veces");

               

                if ((contadorAzul < contadorRojo))
                {
                    MessageBox.Show($"1°. - Color “Amarillo”: {contadorAmarillo} veces \n 2°. - Color “Rojo”: {contadorRojo} veces \n 3°. - Color “Azul”: {contadorAzul} vez");
                }
                else if((contadorAzul > contadorRojo))
                {
                    MessageBox.Show($"1°. - Color “Amarillo”: {contadorAmarillo} veces \n 2°. - Color “Azul”: {contadorAzul} veces \n 3°. - Color “Rojo”: {contadorRojo} vez");
                }

            }
            else if ((contadorAzul > contadorAmarillo) && (contadorAzul > contadorRojo))
            {
                MessageBox.Show($"El boton Azul fue el mas seleccionado: {contadorAzul} veces");

                if ((contadorAmarillo < contadorRojo))
                {
                    MessageBox.Show($"1°. - Color “Azul”: {contadorAzul} veces \n 2°. - Color “Rojo”: {contadorRojo} veces \n 3°. - Color “Amarillo”: {contadorAmarillo} vez");
                }
                else if ((contadorAmarillo > contadorRojo))
                {
                    MessageBox.Show($"1°. - Color “Azul”: {contadorAzul} veces \n 2°. - Color “Amarillo”: {contadorAmarillo} veces \n 3°. - Color “Rojo”: {contadorRojo} vez");
                }

            }
            else if ((contadorRojo > contadorAmarillo) && (contadorRojo > contadorAzul) )
            {
                MessageBox.Show($"El boton Rojo fue el mas seleccionado: {contadorRojo} veces");

                if ((contadorAmarillo < contadorAzul))
                {
                    MessageBox.Show($"1°. - Color “Rojo”: {contadorRojo} veces \n 2°. - Color “Azul”: {contadorAzul} veces \n 3°. - Color “Amarillo”: {contadorAmarillo} vez");
                }
                else if ((contadorAmarillo > contadorAzul))
                {
                    MessageBox.Show($"1°. - Color “Rojo”: {contadorRojo} veces \n 2°. - Color “Amarillo”: {contadorAmarillo} veces \n 3°. - Color “Azul”: {contadorAzul} vez");
                }
            }


            Close();
        }

        private void BCerrar_Paint(object sender, PaintEventArgs e)
        {
       
        }

       

    }
}
