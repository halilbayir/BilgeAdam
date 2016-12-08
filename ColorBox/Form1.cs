using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int red, green, blue;
        private Color RastgeleRenkOlustur()
        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);

            Color rastgeleRenk = Color.FromArgb(red, green, blue);
            return rastgeleRenk;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.Left = btn.Width * i;
                btn.BackColor = RastgeleRenkOlustur();
                btn.Click += ButtonClick;
                
                this.Controls.Add(btn);

            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button secilenButon = sender as Button;
            this.BackColor = secilenButon.BackColor;
            
        }

    }
}
