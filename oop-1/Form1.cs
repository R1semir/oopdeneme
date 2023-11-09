using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev evim = new ev();

            evim.turu = "Daire";
            evim.renk = "Beyaz";
            evim.odasayisi = 5;
            evim.kat = 6;

            string turu = evim.evigöster();

            label5.Text = evim.turu;
            label6.Text = evim.renk;
            label7.Text = evim.odasayisi.ToString();
            label8.Text = evim.kat.ToString();
        }
    }
}
