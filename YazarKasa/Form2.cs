using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazarKasa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.soyisim= txtIsim.Text;
            form.isim=txtSoyisim.Text;
            form.Show();
            this.Hide();


        }
    }
}
