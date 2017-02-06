using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arabax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(numaricYakitDepoKapasite.Value);
            double kaclt = Convert.ToDouble(NumaricOrtTuketim100km.Value);
            double yafit = Convert.ToDouble(numericYakitFiyati.Value);
            Arabax araba = new Arabax(cap,kaclt);
            araba.yakitFiyati = Convert.ToInt32(numericYakitFiyati.Value);
            MessageBox.Show(cap+"\n"+kaclt+"\n"+yafit+"\n"+araba.toplamYol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(numaricYakitDepoKapasite.Value);
            double kaclt = Convert.ToDouble(NumaricOrtTuketim100km.Value);
            double yafit = Convert.ToDouble(numericYakitFiyati.Value);
            Arabax araba = new Arabax(cap, kaclt);
            araba.yakitFiyati = Convert.ToInt32(numericYakitFiyati.Value);
            double km = Convert.ToDouble(numMes.Value);
            lblTopUcret.Text=araba.ucret
        }
    }
}
