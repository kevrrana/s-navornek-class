using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavortalam_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sinav matematik1 = new Sinav();

            matematik1.yazili1 = Convert.ToDouble(txtYazili1.Text);
            matematik1.yazili2 = Convert.ToDouble(txtYazili2.Text);

            lblOrtalama.Text = "Ortalamanız: " + matematik1.OrtalamaHesapla();

            if(matematik1.OrtalamaHesapla() < 50)
            {
                label4.Text = "Kaldı";
            }
            else
            {
                label4.Text = "Geçti";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
