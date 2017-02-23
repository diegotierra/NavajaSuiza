using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class formapp1 : Form
    {

        public formapp1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// En esta funcion calcula el factorial de un numero que le pasamos por parametros
        /// </summary>
        /// <remarks>Si el numero es menor que 0 lanzara una excepcion</remarks>
        /// <param name="num">Es el valor que el usuario introduce</param>
        /// <returns>Devuelve el factorial</returns>
        int factorial(int num)
        {
            int factorial = 1;
            while (num > 0)
            {
                factorial = factorial * num;
                num--;
            }

            return factorial;
        }

        /// <summary>
        /// Evento que obtiene un valor ,lanza el metodo factorial y muestra el resultado
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 1</param>
        /// <param name="e">Sin uso</param>
        private void BBoton1_Click(object sender, EventArgs e)
        {
            int num,res;

            num = int.Parse(textBox1.Text);
            res = factorial(num);

            MessageBox.Show(res.ToString());

            
           
        }


   
    }
}
