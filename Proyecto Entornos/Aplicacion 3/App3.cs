using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Entornos.matrizrotar
{
    public partial class formapp3 : Form
    {
        private static string InputBox(string texto) { InputBoxDialog ib = new InputBoxDialog(); ib.FormPrompt = texto; ib.DefaultValue = ""; ib.ShowDialog(); string s = ib.InputResponse; ib.Close(); return s; }


        public formapp3()
        {
            InitializeComponent();
        }
        const int kfila = 3;
        const int kcol = 4;
        int[,] matriz = new int[kfila, kcol];

        void leer(int [,] matriz)
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    matriz[f, c] = int.Parse(InputBox("Introduczca la posicion: " + f + "," + c + "]"));
                }
            }
        }

        void rotar(int [,] matriz)
        {
            int aux;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                aux = matriz[f, matriz.GetLength(1)- 1];
                for (int c = matriz.GetLength(1) - 1; c > 0; c--)
                {
                    matriz[f, c] = matriz[f, c -1];
                }
                matriz[f, 0] = aux;
            }
        }


        string mostrarMatriz(int[,] matriz)
        {
            int f, c; string texto;

            texto = "Los valores de la matriz son:\n";
        
            for (f = 0; f < matriz.GetLength(0); f++)
            {
                for (c = 0; c < matriz.GetLength(1); c++)
                {
                    texto = texto + matriz[f, c] + ", ";
                }
                texto = texto + "\n";
            } 

            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leer(matriz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            rotar(matriz);
            texto = mostrarMatriz(matriz);
            MessageBox.Show(texto);
        }
    }
}
