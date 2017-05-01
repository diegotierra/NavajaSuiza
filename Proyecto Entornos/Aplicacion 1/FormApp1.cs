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
    /// <summary>
    /// Clase de la aplicacion 1
    /// </summary>
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
        /// Evento que obtiene un valor ,llama al metodo factorial y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton</param>
        /// <param name="e">Sin uso</param>
        public void BBoton1_Click(object sender, EventArgs e)
        {
            int Numero, Resultado;
            bool NumeroValido = true;
            tApp1Logica Factorial = new tApp1Logica();


            do
            {
                NumeroValido = int.TryParse(textBox1.Text, out Numero);

                if (!NumeroValido || Numero < 0 || Numero > 32)
                {
                    MessageBox.Show("El valor debe estar entre 0 y 32");
                }

            } while (!NumeroValido || Numero < 0 || Numero > 32);

            Resultado = Factorial.CalcularFactorial(Numero);

            MessageBox.Show(Resultado.ToString());
        }
    }
}
