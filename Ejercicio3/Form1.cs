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
        public FColores()
        {
            InitializeComponent();
            BackColor = Color.White; 
            BRojo.Focus();
            BAmarillo.Focus();
            BAzul.Focus();   //La funcion Focus () hara que los botones esten receptivos ante determinados eventos por parte del usuario

        }

        private void FColores_Load(object sender, EventArgs e)
        {
           
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAmarillo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            BCerrar.Visible = true;

            
        }

        private void BRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            BCerrar.Visible = true;
        }

        private void BAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            BCerrar.Visible = true;
        }

        private void BCerrar_Paint(object sender, PaintEventArgs e)
        {
       
        }


        private void BRojo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'r') || (e.KeyChar == 'R')){
                BRojo.PerformClick();
            }
        }
        private void BAmarillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'a') || (e.KeyChar == 'A')) {
                BAmarillo.PerformClick();
            }
        }
        

        private void BAzul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'z') || (e.KeyChar == 'Z'))
            {
                BAzul.PerformClick();
            }
        }

        private void BCerrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'c') || (e.KeyChar == 'C'))
            {
                BCerrar.PerformClick();
            }
        }

        private void BRojo_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.R) {
                BRojo.PerformClick();
            }
        }
    }
}
