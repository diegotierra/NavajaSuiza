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
/// Namespace de la Aplicacion 1
/// </summary>
namespace Proyecto_Entornos.Factorial 
{
    public partial class FormApp1 : Form
    {
        /// <summary> 
        /// Constructor de la clase formapp1 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public FormApp1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// En esta funcion calcula el factorial de un numero que le pasamos por parametros
        /// </summary>
        /// <remarks>Si el numero es menor que 0 lanzara una excepcion</remarks>
        /// <param name="Numero">Es el valor que el usuario introduce</param>
        /// <returns>Devuelve el factorial</returns>
        public int CalcularFactorial(int Numero)
        {
            int Resultado = 1;

            if (Numero > 0)
            {
                while (Numero > 0)
                {
                    Resultado = Resultado * Numero;
                    Numero--;
                }
            }
            else
            {
                MessageBox.Show("Error!!");
            }

            return Resultado;
        }

        /// <summary>
        /// Evento que obtiene un valor ,lanza el metodo factorial y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        public void BBoton1_Click(object sender, EventArgs e)
        {
            int Numero,Resultado;
            bool NumeroValido = true;


            do
            {
                NumeroValido = int.TryParse(textBox1.Text, out Numero);

                if (!NumeroValido)
                {
                    MessageBox.Show("Valor no valido!!!");                  
                }

            } while (!NumeroValido);
            
            Resultado = CalcularFactorial(Numero);

            MessageBox.Show(Resultado.ToString());
         
        }


   
    }
}
