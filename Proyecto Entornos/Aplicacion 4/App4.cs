using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace de la aplicacion 4
/// </summary>
namespace Proyecto_Entornos.zigzag
{
    public partial class formapp4 : Form
    {
        /// <summary>
        /// Lee uno o varios caracteres y lo devuelve
        /// </summary>
        /// <param name="texto">Los caracteres que introducas</param>
        /// <returns>Devuelve la cadena de caracteres que hayas introducido</returns>
        private static string InputBox(string texto) { InputBoxDialog ib = new InputBoxDialog(); ib.FormPrompt = texto; ib.DefaultValue = ""; ib.ShowDialog(); string s = ib.InputResponse; ib.Close(); return s; }

        /// <summary>
        /// Constructor de la clase formapp4
        /// </summary>
        public formapp4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// He creado  2 constantes que definen las filas y columnas y una matriz
        /// </summary>
        const int kfila = 4;
        const int kcol = 5;
        int[,] zigzag = new int[kfila, kcol];

        /// <summary>
        /// Rellena la matriz en forma de zigzag con datos internos 
        /// </summary>
        /// <param name="zigzag">Matriz que le pasamos</param>
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

        /// <summary>
        /// Muestra los datos de la matriz
        /// </summary>
        /// <param name="zigzag">Matriz que le pasamos</param>
        /// <returns>Devuelve un texto con el contenido de la matriz</returns>
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

        /// <summary>
        /// Evento que rellena la matriz y muestra el contenido
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            rellenar(zigzag);
            texto = mostrarMatriz(zigzag);

            MessageBox.Show(texto);

        }
    }
}
