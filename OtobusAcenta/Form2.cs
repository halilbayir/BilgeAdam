using OtobusAcenta.DBCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtobusAcenta.DBCon.Model;

namespace OtobusAcenta
{
    public partial class Form2 : Form
    {

        public Musteri gelenMusteri { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            using (MetroModel context = new MetroModel())
            {
                
                var result = context.Admin.ToList();
                if (result.Count == 0)
                {
                    context.Admin.Add(new Admin { AdminName = "admin", AdminPassword = "admin", isDeleted = false });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MetroModel context = new MetroModel())
            {
                var result = context.Musteri.FirstOrDefault(m => m.MusteriUsername == txtUserName.Text && m.MusteriPassword == txtUserPass.Text);

                if (result!=null)
                {
                    MusteriForm frm = new MusteriForm();
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Hatalı bir giriş yaptınız lütfen tekrar deneyiniz!");

            }
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
