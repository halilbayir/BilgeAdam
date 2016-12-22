using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public void ZarAt()
        {
            Random rnd = new Random();
            int zar1, zar2,tur;
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("Images/"+zar1+".png");
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("Images/"+zar2+".png");

            tur = 1;

            if (tur >=10)
            {
                timer1.Interval = 500;
                tur = 0;
            }
            else
            {
                timer1.Interval = 100;
            }

            if (tur%20==0)
            {
                timer1.Stop();
                tur = 0;
            }
            tur++;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ZarAt();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ZarAt();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                ZarAt();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            ZarAt();

        }
    }
}
