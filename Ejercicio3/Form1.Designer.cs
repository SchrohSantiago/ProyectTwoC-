namespace Ejercicio3
{
    partial class FColores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAmarillo = new System.Windows.Forms.Button();
            this.BRojo = new System.Windows.Forms.Button();
            this.BAzul = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAmarillo
            // 
            this.BAmarillo.Location = new System.Drawing.Point(126, 136);
            this.BAmarillo.Name = "BAmarillo";
            this.BAmarillo.Size = new System.Drawing.Size(140, 40);
            this.BAmarillo.TabIndex = 0;
            this.BAmarillo.Text = "&Amarillo";
            this.BAmarillo.UseVisualStyleBackColor = true;
            this.BAmarillo.Click += new System.EventHandler(this.BAmarillo_Click);
            // 
            // BRojo
            // 
            this.BRojo.Location = new System.Drawing.Point(324, 136);
            this.BRojo.Name = "BRojo";
            this.BRojo.Size = new System.Drawing.Size(144, 40);
            this.BRojo.TabIndex = 1;
            this.BRojo.Text = "&Rojo";
            this.BRojo.UseVisualStyleBackColor = true;
            this.BRojo.Click += new System.EventHandler(this.BRojo_Click);
            // 
            // BAzul
            // 
            this.BAzul.Location = new System.Drawing.Point(528, 136);
            this.BAzul.Name = "BAzul";
            this.BAzul.Size = new System.Drawing.Size(132, 40);
            this.BAzul.TabIndex = 2;
            this.BAzul.Text = "A&zul";
            this.BAzul.UseVisualStyleBackColor = true;
            this.BAzul.Click += new System.EventHandler(this.BAzul_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.Location = new System.Drawing.Point(543, 231);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(94, 43);
            this.BCerrar.TabIndex = 3;
            this.BCerrar.Text = "&Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Visible = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            this.BCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.BCerrar_Paint);
            // 
            // FColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.BAzul);
            this.Controls.Add(this.BRojo);
            this.Controls.Add(this.BAmarillo);
            this.Name = "FColores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FColores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAmarillo;
        private System.Windows.Forms.Button BRojo;
        private System.Windows.Forms.Button BAzul;
        private System.Windows.Forms.Button BCerrar;
    }
}

