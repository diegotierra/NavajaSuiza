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

        private void button1_Click(object sender, EventArgs e)
        {
            Factorial.formapp1 oApp1 = new Factorial.formapp1();
            oApp1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multiplos3.formapp2 oApp2 = new Multiplos3.formapp2();
            oApp2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matrizrotar.formapp3 oApp3 = new matrizrotar.formapp3();
            oApp3.ShowDialog();
        }
    }
}
