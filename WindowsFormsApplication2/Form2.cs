using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        Kart gelenYolcu = new Kart();

        public Form2(Kart yolcu)
        {
            InitializeComponent();
            if (yolcu!=null)
            {
                gelenYolcu = yolcu;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            gelenYolcu.bakiye += int.Parse(txtBakiyeYukle.Text);
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
