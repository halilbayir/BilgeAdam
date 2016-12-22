using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aboneler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Aboneler _abone = new Aboneler();
            _abone.AboneNo = int.Parse(txtAboneNo.Text);
            _abone.AdSoyad = txtAdSoyad.Text;
            _abone.oncekiSayac =int.Parse(txtOncekiIndex.Text);
            _abone.sonSayac = int.Parse(txtSonIndex.Text);

            string aboneTuru = radioButton1.Checked == true ? "Ev" : "Kurum";
            _abone.AboneTuru = aboneTuru;
            listBox1.Items.Add(_abone);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Aboneler _abone = new Aboneler();
            double odeme = _abone.OdemeHesapla(_abone.oncekiSayac, _abone.sonSayac, _abone.AboneTuru);
            DialogResult result = MessageBox.Show("Ödemek istermisin" + odeme, "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result==DialogResult.Yes)
            {
                listBox2.Items.Add(_abone.AboneNo);
                listBox1.Items.Remove(_abone);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static string mesaj = "";
        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Aboneler _abone = (Aboneler)listBox2.SelectedItem;
            Form2 frm = new Form2(_abone);
            
            frm.Show();
            
        }
    }
}
