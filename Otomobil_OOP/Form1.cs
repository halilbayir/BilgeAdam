using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomobil_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Porsche superAraba = new Porsche();
            Tofas dulduk = new Tofas();
            Honda hnd = new Honda();

            MessageBox.Show(superAraba.Yazdir());
            MessageBox.Show(superAraba.Calistir());

            MessageBox.Show(dulduk.Yazdir());
            MessageBox.Show(dulduk.Calistir());

            MessageBox.Show(hnd.Yazdir());
            MessageBox.Show(hnd.Calistir());
        }
    }
}
