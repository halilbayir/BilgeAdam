using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        ColorDialog colorDialog = new ColorDialog();
        int kalinlik = 3;
        int basX, basY;
        bool ciz;

        private void cmbRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalinlik = int.Parse((cmbRenkler.SelectedItem.ToString()));
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            basX = e.X;
            basY = e.Y;

        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen p = new Pen(colorDialog.Color,kalinlik);

            Point p1 = new Point(basX, basY);
            Point p2 = new Point();
            if (ciz==true)
            {
                g.DrawLine(p, p1, p2);
                basX = e.X;
                basY = e.Y;
            }
        }

        
    }
}
