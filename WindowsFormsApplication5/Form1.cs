using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.DBConnection;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cemalDBContext con=new cemalDBContext())
            {
                var result = con.Urunlers.ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (cemalDBContext con=new cemalDBContext())
            {
                Urunler u = new Urunler();
                u.UrunAdi = txtUrunIsmi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtUrunFiyat.Text);

                con.Urunlers.Add(u);
                con.SaveChanges();
                

            }
        }
    }
}
