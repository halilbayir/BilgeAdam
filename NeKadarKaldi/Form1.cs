using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region uzmanlik icin calisma saati
            //bas:
            //int gunlukSaat = Convert.ToInt32(GunlukSaatTxt.Text);

            //int gun = 10000 / gunlukSaat;
            //int ay = gun / 30;
            //int yil = ay / 12;

            //if (gunlukSaat > 24)
            //{
            //    GunlukSaatTxt.Text = " ";
            //    MessageBox.Show("Hatali saat girdiniz Yeni bir saat giriniz");
            //    return;
            //    goto bas;
            //}

            //else { 
            //MessageBox.Show("Gün:\t"+gun+"\nAy:\t"+ay+"\nYıl:\t"+yil);
            //}
            #endregion

            #region uykuHesap

            int kacSeneYasar = Convert.ToInt32(YasamTxt.Text);

            int uykuSaat = Convert.ToInt32(GunlukSaatTxt.Text);

            

            int toplamSaatUyku = (kacSeneYasar * 365 * uykuSaat) ;

            int toplamYil = (toplamSaatUyku / 24) / 365;

            MessageBox.Show("Toplam: "+ toplamYil +"yıl uyuyorsun");

            #endregion

        }
    }
}
