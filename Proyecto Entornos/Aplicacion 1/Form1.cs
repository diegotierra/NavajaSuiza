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

        private void BBoton1_Click(object sender, EventArgs e)
        {
            int i;
            int factorial;

            i = int.Parse(textBox1.Text);
            factorial = 1;
            while (i > 0)
            {
                factorial = factorial * i;
                i--;
            }
            MessageBox.Show(factorial.ToString());
        }
    }
}
