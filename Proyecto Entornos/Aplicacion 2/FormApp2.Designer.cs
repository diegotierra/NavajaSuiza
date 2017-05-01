namespace Proyecto_Entornos.Multiplos3
{
    partial class FormApp2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCalcularMultiplos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BCalcularMultiplos
            // 
            this.BCalcularMultiplos.Location = new System.Drawing.Point(101, 155);
            this.BCalcularMultiplos.Name = "BCalcularMultiplos";
            this.BCalcularMultiplos.Size = new System.Drawing.Size(75, 23);
            this.BCalcularMultiplos.TabIndex = 0;
            this.BCalcularMultiplos.Text = "Calcular";
            this.BCalcularMultiplos.UseVisualStyleBackColor = true;
            this.BCalcularMultiplos.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 81);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FormApp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BCalcularMultiplos);
            this.Name = "FormApp2";
            this.Text = "App21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCalcularMultiplos;
        private System.Windows.Forms.TextBox textBox1;
    }
}