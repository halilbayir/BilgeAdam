using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         ogrenci ogr1 = new ogrenci();
        ogrenci ogr2 = new ogrenci();
        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.AdSoyad = "Halil Bayır";
            ogr1.ogrenciNo = 123;

            ogr2.AdSoyad = "Hasan Sn";
            ogr2.ogrenciNo = 234;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyad+" "+ogr1.ogrenciNo);
            MessageBox.Show(ogr2.AdSoyad+" "+ogr2.ogrenciNo);
        }
    }
}
