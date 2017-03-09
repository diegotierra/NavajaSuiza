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
/// Namespace de la Aplicacion 2
/// </summary>
namespace Proyecto_Entornos.Multiplos3

{
    public partial class FormApp2 : Form
    {
        /// <summary>
        /// Constructor de la clase formapp2 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public FormApp2()
        {
            InitializeComponent();
        }


        /// <summary>
        /// En este metodo se calcula los multiplos de 3 del 1 al valor introducido
        /// </summary>
        /// <remarks>Si el numero es un caracter especial o demasiado grande saltara una excepcion</remarks>
        /// <returns>Devuelve un texto con todos los multiplos</returns>
        public string CalcularMultiplos(int Valor)
        {
            int Numeros;
            string Texto;

            Texto = "Los múltiplos de 3 son: ";
            if (Valor > 0)
            {
                for (Numeros = 1; Numeros <= Valor; Numeros++)
                {

                    if (Numeros % 3 == 0)
                    {
                        Texto = Texto + Numeros + ", ";
                    }

                }
            }
            else
            {
                MessageBox.Show("Error!!");             
            }

            return Texto;
        }

        /// <summary>
        /// Evento que llama a un metodo y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        public void button1_Click(object sender, EventArgs e)
        {
            string Resultado;
            int Valor;
            bool NumeroValido = true;

            do
            {
                NumeroValido = int.TryParse(textBox1.Text, out Valor);

                if (!NumeroValido)
                {
                    MessageBox.Show("Valor no valido!!!");
                }

            } while (!NumeroValido);

            Resultado = CalcularMultiplos(Valor);

            MessageBox.Show(Resultado);
        }
    }
}
