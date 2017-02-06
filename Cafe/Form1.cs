using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIcecekler.Enabled = false;
            cmbYemekler.Enabled = false;
            numaricYemekAdet.Enabled = false;
            numericIcecekAdet.Enabled = false;

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
                        this.Controls.Add(btn);
                        counter++;
                    
                }
            }
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
        Masa secilenMasa = new Masa();
        Siparis yeniSiparis = new Siparis();
        static List<Masa> masa = new List<Masa>();
        private void Button_Click(object sender, EventArgs e)
        {
            cmbIcecekler.Enabled = true;
            cmbYemekler.Enabled = true;
            numaricYemekAdet.Enabled = true;
            numericIcecekAdet.Enabled = true;

            Button secilenKoltuk = sender as Button;

            secilenMasa.masaNo = secilenKoltuk.Text;

            


        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            
            if (cmbIcecekler.SelectedItem!=null)
            {
                secilenMasa.siparisler.Add((Siparis)cmbIcecekler.SelectedItem);
                yeniSiparis.miktar = Convert.ToInt32(numericIcecekAdet.Value);
                
            }
            if (cmbYemekler.SelectedValue!=null)
            {
                secilenMasa.siparisler.Add((Siparis)cmbYemekler.SelectedItem);
                yeniSiparis.miktar = Convert.ToInt32(numaricYemekAdet.Value);

            }
            lboxHesap.Items.Add(secilenMasa);
        }

        private void lboxHesap_DoubleClick(object sender, EventArgs e)
        {
            Masa secilenmasa = (Masa)lboxHesap.SelectedItem;
            MessageBox.Show(secilenmasa.ToString());

        }
    }
}
