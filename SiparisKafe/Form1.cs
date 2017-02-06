using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SiparisKafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbIcecekler.Items.Add("Su");
            cmbIcecekler.Items.Add("Kola");
            cmbIcecekler.Items.Add("Limonata");
            cmbIcecekler.Items.Add("Çay");
            cmbIcecekler.Items.Add("Kahve");
            cmbYemekler.Items.Add("Kuru Fasulye");
            cmbYemekler.Items.Add("Tavuklu Pilav");
            cmbYemekler.Items.Add("Simit Tost");
            cmbYemekler.Items.Add("Lazanya");

        }
        XmlDocument xmlDoc;

        private void Form1_Load(object sender, EventArgs e)
        {



            numaricYemekMiktar.Enabled = false;
            numaricIcecekMiktar.Enabled = false;
            cmbIcecekler.Enabled = false;
            cmbYemekler.Enabled = false;
            btnSiparisEkle.Enabled = false;


            int counter = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + "";
                    btn.Left = (btn.Width * j);
                    btn.Top = (btn.Height * i);
                    panelArayuz.Controls.Add(btn);
                    counter++;
                }
            }
        }

        Masa secilenMasa = new Masa();
        static List<Masa> kaliciListe = new List<Masa>();
        Siparis siparisIcecek = new Siparis();
        Siparis siparisYemek = new Siparis();

        private void Button_Click(object sender, EventArgs e)
        {

            numaricYemekMiktar.Enabled = true;
            numaricIcecekMiktar.Enabled = true;
            cmbIcecekler.Enabled = true;
            cmbYemekler.Enabled = true;
            btnSiparisEkle.Enabled = true;
            Button secilmisMasa = sender as Button;
            var result = kaliciListe.FirstOrDefault(x => x.masaNo == secilmisMasa.Text);
            if (result == null)
            {
                Masa masa = new Masa();
                masa.masaNo = secilmisMasa.Text;
                secilenMasa = masa;
            }
            else
            {
                MessageBox.Show("Fazladan Siparis Vermek istermisiniz?");
                secilenMasa = result;

            }


        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {


            int icecekMiktar = Convert.ToInt32(numaricIcecekMiktar.Value);
            int yiyecekMiktar = Convert.ToInt32(numaricYemekMiktar.Value);

            if ((icecekMiktar != 0) && (cmbIcecekler.SelectedItem != null))
            {
                siparisIcecek = new Siparis(icecekMiktar, cmbIcecekler.SelectedItem.ToString());

                siparisIcecek.siparisAd = cmbIcecekler.SelectedItem.ToString();
                siparisIcecek.verilenSiparisinAdi = cmbIcecekler.SelectedItem.ToString();
                secilenMasa.siparisler.Add(siparisIcecek);
            }
            if ((yiyecekMiktar != 0) && (cmbYemekler.SelectedItem != null))
            {
                siparisYemek = new Siparis(yiyecekMiktar, cmbYemekler.SelectedItem.ToString());
                siparisYemek.siparisAd = cmbYemekler.SelectedItem.ToString();
                siparisYemek.verilenSiparisinAdi = cmbYemekler.SelectedItem.ToString();
                secilenMasa.siparisler.Add(siparisYemek);
            }

            var res = kaliciListe.FirstOrDefault(x => x.masaNo == secilenMasa.masaNo);
            if (res == null)
            {
                lstboxHesapBilgileri.Items.Add(secilenMasa);
                kaliciListe.Add(secilenMasa);
                btnSiparisEkle.Enabled = false;
            }
            else
            {

            }

        }
        string[] menu = new string[30];

        private void lstboxHesapBilgileri_DoubleClick(object sender, EventArgs e)
        {


            Masa secilenMasa = (Masa)lstboxHesapBilgileri.SelectedItem;
            int siparisSayisi = secilenMasa.siparisler.Count;



            double toplam = 0;
            for (int i = 0; i < siparisSayisi; i++)
            {
                menu[i] = secilenMasa.siparisler[i].verilenSiparisinAdi;
                toplam += secilenMasa.siparisler[i].siparisleriHesapla(secilenMasa.siparisler[i], secilenMasa.siparisler[i].siparisAdet);
                MessageBox.Show("Hesap Detaylar:\n    " + secilenMasa.siparisler[i].siparisAdet + "\ttane   " + menu[i] + "  sipariş etmişsiniz");

            }
           
            secilenMasa.toplamBorc = toplam;
            DialogResult result = MessageBox.Show("Toplam borcunuz " + toplam + "   kadardır", "Hesap Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Geldiğiniz için Teşekkürler!");
                lstboxHesapBilgileri.Items.Remove(secilenMasa);
                kaliciListe.Remove(secilenMasa);
            }
        }
    }
}
