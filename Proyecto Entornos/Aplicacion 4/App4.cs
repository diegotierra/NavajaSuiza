using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Entornos.zigzag
{
    public partial class formapp4 : Form
    {
        private static string InputBox(string texto) { InputBoxDialog ib = new InputBoxDialog(); ib.FormPrompt = texto; ib.DefaultValue = ""; ib.ShowDialog(); string s = ib.InputResponse; ib.Close(); return s; }


        public formapp4()
        {
            InitializeComponent();
        }
        const int kfila = 4;
        const int kcol = 5;
        int[,] zigzag = new int[kfila, kcol];

        void rellenar (int [,] zigzag)
        {
            int num = 1;
            for (int j = 0; j < zigzag.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < zigzag.GetLength(0); i++)
                    {
                        zigzag[i,j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int i = zigzag.GetLength(0) - 1; i >= 0; i--)
                    {
                        zigzag[i,j] = num;
                        num++;
                    }

                }
                
            }











        }

        string mostrarMatriz(int[,] zigzag)
        {
            int i, j; string texto;

            texto = "Los valores de la matriz son:\n";

            for (i = 0; i < zigzag.GetLength(0); i++)
            {
                for (j = 0; j < zigzag.GetLength(1); j++)
                {
                    texto = texto + zigzag[i, j] + ", ";
                }
                    texto = texto + "\n";
             } 

            return texto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            rellenar(zigzag);
            texto = mostrarMatriz(zigzag);

            MessageBox.Show(texto);

        }
    }
}
