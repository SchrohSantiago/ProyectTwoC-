using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Ejercicio2
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();

            BackColor = Color.Gray;

            Text = "GRIS";
        }

        private void FMovedizo_Load(object sender, EventArgs e)
        {
            
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {
            switch (BackColor.Name) 
            {
                case "Green":
                case "Gray":
                    BackColor = Color.Red;
                    Text = "ROJO";
                    Location = new Point( Location.X + 10,Location.Y + 10);
                    Width -= 15;
                    Height += 10;
                    break;
                case "Red":
                    BackColor = Color.Blue;
                    Text = "AZUL";
                    Location = new Point(Location.X - 15, Location.Y + 0);
                    Width += 20;
                    Height += 5;
                    break;
                case "Blue":
                    BackColor = Color.Green;
                    Text = "VERDE";
                    Location = new Point( Location.X + 15,Location.Y  -5);
                    Width -= 5;
                    Height -= 15;
                    break;
                default:
                    break;
            }
        }
    }
}
