using CodeFirstSample_2.dbCon;
using CodeFirstSample_2.dbCon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstSample_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MarketContext context=new MarketContext())
            {
                var result = context.Category.ToList();

                if (result.Count == 0)
                {
                    context.Category.Add(new Category { CategoryName = "Oyun Konsolu" });
                    context.Category.Add(new Category { CategoryName = "Dizüstü Bilgisayar" });
                    context.SaveChanges();
                }
                result = context.Category.ToList();

                foreach (var item in result)
                {
                    cmbUrunCategory.Items.Add(item);
                }

            }
            DGridList.Visible = false;
            groupBox1.Enabled = false;

        }

        private void MenuItemTumUrunler_Click(object sender, EventArgs e)
        {
            using (MarketContext context = new MarketContext())
            {
                var res = context.Product.ToList();
                DGridList.DataSource = res;
            }
            DGridList.Visible = true;
           
        }

        private void MenuItemUrunEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtUrunAdi.Clear();
            numUpdownUrunFiyat.Value = 0;

            }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductName = txtUrunAdi.Text;
            urun.ProductPrice = numUpdownUrunFiyat.Value;
            Category c = (Category)cmbUrunCategory.SelectedItem;
            urun.CategoryID = c.CategoryID;

            using (MarketContext context = new MarketContext())
            {
                context.Product.Add(urun);
                context.SaveChanges();
            }
    }

        private void numUpdownUrunFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
