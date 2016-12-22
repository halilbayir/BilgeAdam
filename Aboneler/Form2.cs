using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aboneler;

namespace Aboneler
{
    public partial class Form2 : Form
    {

        public Form2(Aboneler aboneForm2)
        {
          
            InitializeComponent();
            txtAbNo.Text = aboneForm2.AboneNo.ToString();
            txtAd.Text = aboneForm2.AdSoyad;
            txtTutar.Text = aboneForm2.OdemeHesapla(aboneForm2.oncekiSayac, aboneForm2.sonSayac, aboneForm2.AboneTuru).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
