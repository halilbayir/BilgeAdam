using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Musteri> MusteriListesi = new List<Musteri>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.Cinsiyet = rdBtnErkek.Checked == false ? true : false;
            musteri.OtobusTuru = cmbOtobusTuru.SelectedItem.ToString();

            MusteriListesi.Add(musteri);
            LboxMusteriler.Items.Add(musteri+"\n");
            
            txtAdSoyad.Clear();
            txtAdSoyad.Focus();
        }

        private void LboxMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LboxMusteriler.Items.RemoveAt(LboxMusteriler.SelectedIndex);
        }
    }
}
