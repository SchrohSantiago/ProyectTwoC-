namespace Ejercicio1
{
    partial class FValorAbsYRedondeo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransformarAValorAbs = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labRedondeado = new System.Windows.Forms.Label();
            this.txtValorDosCifras = new System.Windows.Forms.TextBox();
            this.btnRedondearValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un numero";
            // 
            // btnTransformarAValorAbs
            // 
            this.btnTransformarAValorAbs.Location = new System.Drawing.Point(64, 146);
            this.btnTransformarAValorAbs.Name = "btnTransformarAValorAbs";
            this.btnTransformarAValorAbs.Size = new System.Drawing.Size(100, 46);
            this.btnTransformarAValorAbs.TabIndex = 2;
            this.btnTransformarAValorAbs.Text = "Mostrar Valor Absoluto";
            this.btnTransformarAValorAbs.UseVisualStyleBackColor = true;
            this.btnTransformarAValorAbs.Click += new System.EventHandler(this.btnTransformarAValorAbs_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(64, 101);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(211, 104);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(0, 13);
            this.labResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Redondear numero de dos cifras";
            // 
            // labRedondeado
            // 
            this.labRedondeado.AutoSize = true;
            this.labRedondeado.Location = new System.Drawing.Point(608, 104);
            this.labRedondeado.Name = "labRedondeado";
            this.labRedondeado.Size = new System.Drawing.Size(0, 13);
            this.labRedondeado.TabIndex = 6;
            // 
            // txtValorDosCifras
            // 
            this.txtValorDosCifras.Location = new System.Drawing.Point(492, 101);
            this.txtValorDosCifras.Name = "txtValorDosCifras";
            this.txtValorDosCifras.Size = new System.Drawing.Size(100, 20);
            this.txtValorDosCifras.TabIndex = 7;
            // 
            // btnRedondearValor
            // 
            this.btnRedondearValor.Location = new System.Drawing.Point(492, 146);
            this.btnRedondearValor.Name = "btnRedondearValor";
            this.btnRedondearValor.Size = new System.Drawing.Size(100, 46);
            this.btnRedondearValor.TabIndex = 8;
            this.btnRedondearValor.Text = "Redondear Valor";
            this.btnRedondearValor.UseVisualStyleBackColor = true;
            this.btnRedondearValor.Click += new System.EventHandler(this.btnRedondearValor_Click);
            // 
            // FValorAbsYRedondeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRedondearValor);
            this.Controls.Add(this.txtValorDosCifras);
            this.Controls.Add(this.labRedondeado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnTransformarAValorAbs);
            this.Controls.Add(this.label1);
            this.Name = "FValorAbsYRedondeo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransformarAValorAbs;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labRedondeado;
        private System.Windows.Forms.TextBox txtValorDosCifras;
        private System.Windows.Forms.Button btnRedondearValor;
    }
}

