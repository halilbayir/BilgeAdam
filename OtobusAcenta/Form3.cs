using OtobusAcenta.DBCon;
using OtobusAcenta.DBCon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusAcenta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnYeniUyeKayit_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.MusteriUsername = txtUserName.Text;
            yeniMusteri.MusteriPassword = txtUserPass.Text;

            using (MetroModel context = new MetroModel())
            {
                context.Musteri.Add(yeniMusteri);
                context.SaveChanges();
            }
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
