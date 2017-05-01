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
namespace Proyecto_Entornos.Notas
{
    /// <summary>
    /// Clase de la aplicacion 3
    /// </summary>
    public partial class FormApp3 : Form
    {
        /// <summary> 
        /// Constructor de la clase formapp3 que inicializa los componentes
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        public FormApp3()
        {
            InitializeComponent();
        }  

        /// <summary>
        /// Evento que obtiene un valor , lanza el metodo CalificarNota y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        public void BBoton1_Click(object sender, EventArgs e)
        {
            double Nota = 0;
            bool NumeroValido = false;
            string Resultado = "";

            do
            {
                NumeroValido = double.TryParse(textBox1.Text, out Nota);

                if (!NumeroValido || Nota < 0 || Nota > 10)
                {
                    MessageBox.Show("El valor debe estar entre 0 y 10");
                }
                else
                {
                    Resultado = tApp3Logica.CalificarNota(Nota);
                    MessageBox.Show(Resultado);
                }

            } while (NumeroValido == false || Nota < 0 || Nota > 10);         

        }
    }
}
