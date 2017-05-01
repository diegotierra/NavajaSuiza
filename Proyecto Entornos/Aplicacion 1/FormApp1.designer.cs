namespace Proyecto_Entornos.Factorial
{
    partial class FormApp1
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
            this.bCalcularFact = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCalcularFact
            // 
            this.bCalcularFact.Location = new System.Drawing.Point(96, 208);
            this.bCalcularFact.Name = "bCalcularFact";
            this.bCalcularFact.Size = new System.Drawing.Size(110, 51);
            this.bCalcularFact.TabIndex = 0;
            this.bCalcularFact.Text = "Calcular factorial";
            this.bCalcularFact.UseVisualStyleBackColor = true;
            this.bCalcularFact.Click += new System.EventHandler(this.BBoton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 90);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FormApp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bCalcularFact);
            this.Name = "FormApp1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcularFact;
        private System.Windows.Forms.TextBox textBox1;
    }
}

