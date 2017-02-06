using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ad = txtAd.Text;
            ogr.soyad = txtSoyad.Text;
            ogr.telefon = txtTel.Text;

            dataGridView1.Rows.Add(ogr.ad,ogr.soyad,ogr.telefon);
        }
    }
}
