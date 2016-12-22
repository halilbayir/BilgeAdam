using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aboneler abone1 = new Aboneler();
        private void button1_Click(object sender, EventArgs e)
        {
            abone1.aboneIsim = textBox1.Text;
            abone1.aboneTip = radioEv.Checked == false ? true : false;
            abone1.aboneBorc = int.Parse(textBox2.Text);
            abone1.aboneOdenecekTutar = int.Parse(textBox3.Text);

            double toplamBorc;
            if (radioEv.Checked == false)
            {
                toplamBorc = ((abone1.aboneBorc - abone1.aboneOdenecekTutar) * 0.25);
            }
            else {
                toplamBorc = ((abone1.aboneBorc - abone1.aboneOdenecekTutar) * 0.50);
            }

            lboxAboneisimler.Items.Add(abone1.aboneIsim+"   "+toplamBorc);
            
        }

        private void lboxAboneisimler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ödemek İstiyormusunuz", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lboxOdenenler.Items.Add(lboxAboneisimler.SelectedItem);
                lboxAboneisimler.Items.RemoveAt(lboxAboneisimler.SelectedIndex);
                
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SonMusteriEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödendi!!!!");
        }
    }
}
