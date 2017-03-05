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
namespace Proyecto_Entornos.ZigZag
{
    public partial class FormApp4 : Form
    {

        /// <summary>
        /// Constructor de la clase formapp4 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public FormApp4()
        {
            InitializeComponent();
        }


        /// <summary>
        /// He creado  2 constantes que definen las filas y columnas y una matriz
        /// </summary>
        const int NumeroFilas = 4;
        const int NumeroColumnas = 5;

        int[,] ZigZag = new int[NumeroFilas, NumeroColumnas];

        /// <summary>
        /// Rellena la matriz en forma de zigzag con datos internos 
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="ZigZag">Matriz que le pasamos</param>
        void RellenarMatriz (int [,] ZigZag)
        {
            int Numero = 1;

            for (int Columnas = 0; Columnas < ZigZag.GetLength(1); Columnas++)
            {
                if (Columnas % 2 == 0)
                {
                    for (int Filas = 0; Filas < ZigZag.GetLength(0); Filas++)
                    {

                        ZigZag[Filas,Filas] = Numero;
                        Numero++;

                    }
                }
                else
                {
                    for (int Filas = ZigZag.GetLength(0) - 1; Filas >= 0; Filas--)
                    {

                        ZigZag[Filas,Filas] = Numero;
                        Numero++;

                    }
                }               
            }
        }

        /// <summary>
        /// Muestra los datos de la matriz
        /// </summary>
        /// <param name="ZigZag">Matriz que le pasamos</param>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve un texto con el contenido de la matriz</returns>
        string MostrarMatriz(int[,] ZigZag)
        {
            int Filas, Columnas; string Resultado;

            Resultado = "Los valores de la matriz son:\n";

            for (Filas = 0; Filas < ZigZag.GetLength(0); Filas++)
            {
                for (Columnas = 0; Columnas < ZigZag.GetLength(1); Columnas++)
                {

                    Resultado = Resultado + ZigZag[Filas, Columnas] + ", ";

                }

                    Resultado = Resultado + "\n";

             } 

            return Resultado;
        }

        /// <summary>
        /// Evento que rellena la matriz y muestra el contenido
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string Resultado;

            RellenarMatriz(ZigZag);
            Resultado = MostrarMatriz(ZigZag);

            MessageBox.Show(Resultado);

        }
    }
}
