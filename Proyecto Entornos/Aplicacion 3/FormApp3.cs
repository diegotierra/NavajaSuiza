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
namespace Proyecto_Entornos.MatrizRotar
{
    
    public partial class FormApp3 : Form
    {

        /// <summary>
        /// Lee uno o varios caracteres y lo devuelve
        /// </summary>
        /// <param name="Texto">Los caracteres que introduzcas</param>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve la cadena de caracteres que hayas introducido</returns>
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        /// <summary>
        /// Constructor de la clase formapp3 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public FormApp3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// He creado  2 constantes que definen las filas y columnas y una matriz
        /// </summary>
        const int NumeroFilas = 3;
        const int NumeroColumnas = 4;

        int[,] Matriz = new int[NumeroFilas, NumeroColumnas];

        /// <summary>
        /// Lee e introduce datos en una matriz
        /// </summary>
        /// <remarks>Si se introduce un caracter especial o un espacio en blanco salta un mensaje de error</remarks>
        /// <param name="Matriz">Matriz que le pasamos</param>
        public void LeerMatriz(int[,] Matriz)
        {
            bool NumeroValido;
            int Valor;

            for (int Filas = 0; Filas < Matriz.GetLength(0); Filas++)
            {
                for (int Columnas = 0; Columnas < Matriz.GetLength(1); Columnas++)
                {
                    do
                    {

                        NumeroValido = int.TryParse(InputBox("Introduzca la posicion: " + Filas + "," +
                            Columnas + "]"), out Valor);

                        if (NumeroValido)
                        {

                            Matriz[Filas, Columnas] = Valor;

                        }
                        else
                        {

                            MessageBox.Show("Valor Erroneo!!");

                        }

                    } while (NumeroValido == false);
                }
            }
        }

        /// <summary>
        /// Funcion que rota las posiciones en una matriz
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="Matriz">Matriz que le pasamos</param>
        public void RotarPosiciones(int[,] Matriz)
        {
            int Auxiliar;

            for (int Filas = 0; Filas < Matriz.GetLength(0); Filas++)
            {

                Auxiliar = Matriz[Filas, Matriz.GetLength(1) - 1];

                for (int Columnas = Matriz.GetLength(1) - 1; Columnas > 0; Columnas--)
                {

                    Matriz[Filas, Columnas] = Matriz[Filas, Columnas - 1];

                }

                Matriz[Filas, 0] = Auxiliar;
            }
        }

        /// <summary>
        /// Muestra los datos de la matriz
        /// </summary>
        /// <param name="Matriz">Matriz que le pasamos</param>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve un texto con el contenido de la matriz</returns>
        public string MostrarMatriz(int[,] Matriz)
        {
            int Filas, Columnas;
            string Resultado;

            Resultado = "Los valores de la matriz son:\n";

            for (Filas = 0; Filas < Matriz.GetLength(0); Filas++)
            {
                for (Columnas = 0; Columnas < Matriz.GetLength(1); Columnas++)
                {

                    Resultado = Resultado + Matriz[Filas, Columnas] + ", ";

                }

                Resultado = Resultado + "\n";

            }

            return Resultado;
        }

        /// <summary>
        /// Evento que lee la matriz
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(Matriz);
        }

        /// <summary>
        /// Evento que rota la matriz y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string Resultado;

            RotarPosiciones(Matriz);
            Resultado = MostrarMatriz(Matriz);

            MessageBox.Show(Resultado);
        }
    }
}
