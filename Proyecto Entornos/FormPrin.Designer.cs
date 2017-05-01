namespace Proyecto_Entornos
{
    partial class FormPrin
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
            this.bAplicacion1 = new System.Windows.Forms.Button();
            this.bAplicacion2 = new System.Windows.Forms.Button();
            this.bAplicacion3 = new System.Windows.Forms.Button();
            this.bAplicacion4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAplicacion1
            // 
            this.bAplicacion1.Location = new System.Drawing.Point(53, 38);
            this.bAplicacion1.Name = "bAplicacion1";
            this.bAplicacion1.Size = new System.Drawing.Size(101, 48);
            this.bAplicacion1.TabIndex = 0;
            this.bAplicacion1.Text = "Aplicacion 1";
            this.bAplicacion1.UseVisualStyleBackColor = true;
            this.bAplicacion1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bAplicacion2
            // 
            this.bAplicacion2.Location = new System.Drawing.Point(352, 43);
            this.bAplicacion2.Name = "bAplicacion2";
            this.bAplicacion2.Size = new System.Drawing.Size(100, 43);
            this.bAplicacion2.TabIndex = 1;
            this.bAplicacion2.Text = "Aplicacion 2";
            this.bAplicacion2.UseVisualStyleBackColor = true;
            this.bAplicacion2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bAplicacion3
            // 
            this.bAplicacion3.Location = new System.Drawing.Point(53, 154);
            this.bAplicacion3.Name = "bAplicacion3";
            this.bAplicacion3.Size = new System.Drawing.Size(101, 44);
            this.bAplicacion3.TabIndex = 2;
            this.bAplicacion3.Text = "Aplicacion 3";
            this.bAplicacion3.UseVisualStyleBackColor = true;
            this.bAplicacion3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bAplicacion4
            // 
            this.bAplicacion4.Location = new System.Drawing.Point(352, 154);
            this.bAplicacion4.Name = "bAplicacion4";
            this.bAplicacion4.Size = new System.Drawing.Size(100, 44);
            this.bAplicacion4.TabIndex = 3;
            this.bAplicacion4.Text = "Aplicacion 4";
            this.bAplicacion4.UseVisualStyleBackColor = true;
            this.bAplicacion4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 267);
            this.Controls.Add(this.bAplicacion4);
            this.Controls.Add(this.bAplicacion3);
            this.Controls.Add(this.bAplicacion2);
            this.Controls.Add(this.bAplicacion1);
            this.Name = "FormPrin";
            this.Text = "Formularioprin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAplicacion1;
        private System.Windows.Forms.Button bAplicacion2;
        private System.Windows.Forms.Button bAplicacion3;
        private System.Windows.Forms.Button bAplicacion4;
    }
}