using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos3
{
    public partial class formapp2 : Form
    {
        public formapp2()
        {
            InitializeComponent();
        }

        private void BBoton1_Click(object sender, EventArgs e)
        {
            int num;
            string texto;

            texto = "Los múltiplos de 3 son: ";
            for (num = 1; num <= 100; num++)
            {
                if (num % 3 == 0)
                    texto = texto + num + ", ";
            }
            MessageBox.Show(texto);
                      


        }
    }
}
