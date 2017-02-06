using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;
        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            if (radioOgrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(txtBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogrenci.kartTuru = YolcuTipi.Ogrenci;
                ogrenci.okulAdi = txtOkulAdi.Text;
                lstBoxKartListe.Items.Add(ogrenci);
            }
            else if (radioOgretmen.Checked == true)
            {
                ogretmen.bakiye = Convert.ToDouble(txtBakiye.Text);
                ogretmen.kartID = kartid;
                ogretmen.kartTuru = YolcuTipi.Ogretmen;
                kartid++;
                lstBoxKartListe.Items.Add(ogretmen);
            }
            else
            {
                tam.bakiye = Convert.ToDouble(txtBakiye.Text);
                tam.kartID = kartid;
                tam.kartTuru = YolcuTipi.Tam;
                kartid++;
                lstBoxKartListe.Items.Add(tam);
            }
            Temizle();
        }

        private void radioOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxOkulAdi.Enabled = radioOgrenci.Checked == true ? true : false;

        }

        private void lstBoxKartListe_DoubleClick(object sender, EventArgs e)
        {
            var yolcu =(Kart) lstBoxKartListe.SelectedItem;
             
            if (yolcu.kartTuru==YolcuTipi.Ogrenci && (yolcu.bakiye-1>=0))
            {
                lstBoxKartListe.Items.RemoveAt(lstBoxKartListe.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut();
                lstBoxKartListe.Items.Add(ogrenci);
            }
            else if (yolcu.kartTuru==YolcuTipi.Ogretmen && (yolcu.bakiye - 2 >= 0))
            {
                lstBoxKartListe.Items.RemoveAt(lstBoxKartListe.SelectedIndex);
                ogretmen = (OgretmenKart)yolcu;
                ogretmen.Okut();
                lstBoxKartListe.Items.Add(ogretmen);
            }
            else if (yolcu.kartTuru == YolcuTipi.Tam && (yolcu.bakiye - 3 >= 0))
            {
                lstBoxKartListe.Items.RemoveAt(lstBoxKartListe.SelectedIndex);
                tam = (Kart)yolcu;
                tam.Okut();
                lstBoxKartListe.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Bakiye Yetersiz!");
                DialogResult res = MessageBox.Show("Bakiye Yüklemek istermisiniz","Bildirim Ekranı",MessageBoxButtons.YesNo);
                if (res==DialogResult.Yes)
                {
                    Form2 frm = new Form2(yolcu);
                    frm.Show();
                    this.Hide();
                   
                }
                else
                {

                }
            }

        }

        private void Temizle()
        {
            txtBakiye.Clear();
            txtOkulAdi.Clear();
        }
    }
}
