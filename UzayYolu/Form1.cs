using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rocket.Visible = false;
        }

        int genislik = Form1.ActiveForm.Width;
        int yukseklik = Form1.ActiveForm.Height;
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (((pictureBox1.Location.X < genislik - pictureBox1.Width)&& (pictureBox1.Location.X>=0 ))&& ((pictureBox1.Location.Y + pictureBox1.Height < yukseklik)&&(pictureBox1.Location.Y>=0)))
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        pictureBox1.Left -= 10;
                        break;
                    case Keys.Right:
                        pictureBox1.Left += 10;
                        break;
                    case Keys.Up:
                        pictureBox1.Top -= 10;
                        break;
                    case Keys.Down:
                        pictureBox1.Top += 10;
                        break;
                    case Keys.Space:

                        timer1.Start();
                        int x = pictureBox1.Location.X + pictureBox1.Width / 2;
                        int y = pictureBox1.Location.Y + pictureBox1.Height / 2;
                        rocket.Location = new Point(x, y);
                        rocket.Visible = true;

                        break;
                    default:

                        break;
                }
            }
            else
            {
                MessageBox.Show("Uzay Dışına Çıktın!!!");
                pictureBox1.Location = new Point(10, 10);
                //Application.Exit(); applicationi kapatır
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (rocket.Location.X < genislik - rocket.Width * 2)
            {
                rocket.Left += 10;
            }
            else
            {
                timer1.Stop();
            }

        }
    }
}
