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
/// Namespace de la aplicacion principal
/// </summary>
namespace Proyecto_Entornos
{
    /// <summary>
    /// Clase del formulario principal
    /// </summary>
    public partial class FormPrin : Form
    {
        /// <summary>
        /// Constructor de la clase Formprin que inicializa los componentes
        /// </summary>
        public FormPrin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 1
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion te calcula el factorial del numero introducido");

            Proyecto_Entornos.Factorial.FormApp1 oApp1 = new Proyecto_Entornos.Factorial.FormApp1();
            oApp1.ShowDialog();
        }


        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 2
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion te calcula los multiplos de 3 hasta el numero introducido");

            Proyecto_Entornos.Multiplos3.FormApp2 oApp2 = new Proyecto_Entornos.Multiplos3.FormApp2();
            oApp2.ShowDialog();
        }

        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 3
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 3</param>
        /// <param name="e">Sin uso</param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion obtiene una nota y nos la califica");

            Proyecto_Entornos.Notas.FormApp3 oApp3 = new Proyecto_Entornos.Notas.FormApp3();
            oApp3.ShowDialog();
        }

        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 4
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 4</param>
        /// <param name="e">Sin uso</param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion obtiene la suma de los pares del 1 al numero introducido");

            Proyecto_Entornos.SumarPares.FormApp4 oApp4 = new Proyecto_Entornos.SumarPares.FormApp4();
            oApp4.ShowDialog();
        }
    }
}
