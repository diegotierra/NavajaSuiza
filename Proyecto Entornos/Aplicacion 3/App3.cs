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
/// Namespace de la Aplicacion 3
/// </summary>
namespace Proyecto_Entornos.matrizrotar
{
    public partial class formapp3 : Form
    {
        /// <summary>
        /// Lee uno o varios caracteres y lo devuelve
        /// </summary>
        /// <param name="texto">Los caracteres que introducas</param>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve la cadena de caracteres que hayas introducido</returns>
        private static string InputBox(string texto) { InputBoxDialog ib = new InputBoxDialog(); ib.FormPrompt = texto; ib.DefaultValue = ""; ib.ShowDialog(); string s = ib.InputResponse; ib.Close(); return s; }


        /// <summary>
        /// Constructor de la clase formapp3 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public formapp3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// He creado  2 constantes que definen las filas y columnas y una matriz
        /// </summary>
        const int kfila = 3;
        const int kcol = 4;
        int[,] matriz = new int[kfila, kcol];

        /// <summary>
        /// Lee e introduce datos en una matriz
        /// </summary>
        /// <remarks>Si se introduce un caracter especial o un espacio en blanco salta un mensaje de error</remarks>
        /// <param name="matriz">Matriz que le pasamos</param>
        void LeerMatriz(int [,] matriz)
        {
            bool valido;
            int valor;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    do
                    {
                        valido = int.TryParse(InputBox("Introduczca la posicion: " + f + "," + c + "]"), out valor);
                        if (valido)
                        {
                            matriz[f, c] = valor;
                        }
                        else
                        {
                            MessageBox.Show("Valor Erroneo!!");
                        }
                 } while (valido == false);
                    
                }
            }
        }

        /// <summary>
        /// Funcion que rota las posiciones en una matriz
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="matriz">Matriz que le pasamos</param>
        void RotarPosiciones(int [,] matriz)
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

        /// <summary>
        /// Muestra los datos de la matriz
        /// </summary>
        /// <param name="matriz">Matriz que le pasamos</param>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve un texto con el contenido de la matriz</returns>
        string MostrarMatriz(int[,] matriz)
        {
            int f, c;
            string texto;

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

        /// <summary>
        /// Evento que lee la matriz
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(matriz);
        }

        /// <summary>
        /// Evento que rota la matriz y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            RotarPosiciones(matriz);
            texto = MostrarMatriz(matriz);
            MessageBox.Show(texto);
        }
    }
}
