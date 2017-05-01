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
/// Namespace de la Aplicacion 4
/// </summary>
namespace Proyecto_Entornos.SumarPares
{
    /// <summary>
    /// Clase de la aplicacion 4
    /// </summary>
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
        /// Evento que obtiene un valor ,lanza el metodo SumarPares y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton </param>
        /// <param name="e">Sin uso</param>
        public void BBoton1_Click(object sender, EventArgs e)
        {
            int Numero = 0;
            bool NumeroValido = true;


            do
            {
                NumeroValido = int.TryParse(textBox1.Text, out Numero);

                if (!NumeroValido || Numero < 0)
                {
                    MessageBox.Show("El valor debe ser positivo");
                }

            } while (!NumeroValido || Numero < 0);

            MessageBox.Show(tApp4Logica.SumarPares(Numero).ToString());            
        }
    }
}
