using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Entornos
{
    public partial class Formprin : Form
    {
        public Formprin()
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
            Proyecto_Entornos.Factorial.formapp1 oApp1 = new Proyecto_Entornos.Factorial.formapp1();
            oApp1.ShowDialog();
        }

        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 2
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 2</param>
        /// <param name="e">Sin uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Proyecto_Entornos.Multiplos3.formapp2 oApp2 = new Proyecto_Entornos.Multiplos3.formapp2();
            oApp2.ShowDialog();
        }

        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 3
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 3</param>
        /// <param name="e">Sin uso</param>
        private void button3_Click(object sender, EventArgs e)
        {
            Proyecto_Entornos.matrizrotar.formapp3 oApp3 = new Proyecto_Entornos.matrizrotar.formapp3();
            oApp3.ShowDialog();
        }

        /// <summary>
        /// En este evento al hacer click llama a la aplicacion 4
        /// </summary>
        /// <param name="sender">Lanza el evento del boton 4</param>
        /// <param name="e">Sin uso</param>
        private void button4_Click(object sender, EventArgs e)
        {
            Proyecto_Entornos.zigzag.formapp4 oApp4 = new Proyecto_Entornos.zigzag.formapp4();
            oApp4.ShowDialog();
        }
    }
}
