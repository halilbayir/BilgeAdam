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
    public partial class Akademisyen : Form
    {
        public Akademisyen()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgretimGorevlisi a = new OgretimGorevlisi();
            a.ad = txtAd.Text;
            a.soyad = txtSoyad.Text;
            a.telefon = txtTel.Text;
            a.bolum = txtTel.Text;
            a.gorevi = txtGorev.Text;

            dataGridView1.Rows.Add(a.ad, a.soyad, a.telefon, a.bolum, a.gorevi);
            MessageBox.Show(a.bilgiGoster());
        }
    }
}
