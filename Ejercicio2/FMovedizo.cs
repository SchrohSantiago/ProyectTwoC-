using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();

            this.BackColor = Color.Gray;

            this.Text = "GRIS";
        }

        private void FMovedizo_Load(object sender, EventArgs e)
        {
            
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {
            switch (this.BackColor.Name) 
            {
                case "Green":
                case "Gray":
                    this.BackColor = Color.Red;
                    this.Text = "ROJO";
                    //this.Left += 10;
                    //this.Top += 10;
                    Location = new Point( + 10,+ 10);
                    this.Width -= 15;
                    this.Height += 10;
                    break;
                case "Red":
                    this.BackColor = Color.Blue;
                    this.Text = "AZUL";
                    //this.Left -= 15;
                    Location = new Point(- 15, 0);
                    this.Width += 20;
                    this.Height += 5;
                    break;
                case "Blue":
                    this.BackColor = Color.Green;
                    this.Text = "VERDE";
                    //this.Left -= 5;
                    //this.Top -= 15;
                    Location = new Point( + 20,  -15);
                    this.Width -= 5;
                    this.Height -= 15;
                    break;
                default:
                    break;
            }
        }
    }
}
