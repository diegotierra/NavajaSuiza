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
        /// En este metodo se calcula los multiplos de 3 del 1 al 100
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve un texto con todos los multiplos</returns>
        string CalcularMultiplos()
        {
            int Numeros;
            string Texto;

            Texto = "Los múltiplos de 3 son: ";

            for (Numeros = 1; Numeros <= 100; Numeros++)
            {

                if (Numeros % 3 == 0)
                {
                    Texto = Texto + Numeros + ", ";
                }

            }

            return Texto;
        }

        /// <summary>
        /// Evento que llama a un metodo y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        private void BBoton1_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = CalcularMultiplos();
            MessageBox.Show(Resultado);
                      


        }
    }
}
