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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string isim;
        public string soyisim;
        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> yolcular = new List<string>();
            Form2 form = new Form2();
            label1.Text = isim;
            label2.Text = soyisim;
            yolcular.Add(isim);

            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
