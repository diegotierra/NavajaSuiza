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
    /// <summary>
    /// Clase de la aplicacion 2
    /// </summary>
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
        /// Evento que llama a un metodo y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        public void button1_Click(object sender, EventArgs e)
        {
            string Resultado = "";
            int Valor = 0;
            bool NumeroValido = true;
            tApp2Logica Multiplos = new tApp2Logica();

            do
            {
                NumeroValido = int.TryParse(textBox1.Text, out Valor);

                if (!NumeroValido | Valor < 0)
                {
                    MessageBox.Show("El valor debe ser positivo");
                }

            } while (!NumeroValido || Valor < 0);

            Resultado = Multiplos.CalcularMultiplos(Valor);

            MessageBox.Show(Resultado);
        }
    }
}
