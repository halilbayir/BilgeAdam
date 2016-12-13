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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button secilenbuton = sender as Button;
            this.BackColor = secilenbuton.BackColor;
        }

        private void cmbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSec.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (j != 2 && i != 6)
                        {
                            Button button = new Button();
                            button.Click += ButtonClick;
                           


                            button.Width = 30;
                            button.Height = 30;
                            button.Left = button.Width * j;
                            button.Top = button.Width * i;
                            this.Controls.Add(button);
                        }
                    }
                }
                cmbSec.Visible = false;

            }
            else if (cmbSec.SelectedIndex == 1)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j != 2 && i != 6)
                        {
                            Button button = new Button();
                            button.Width = 30;
                            button.Height = 30;
                            button.Left = button.Width * j;
                            button.Top = button.Width * i;
                            this.Controls.Add(button);
                        }

                    }

                }
                cmbSec.Visible = false;

            }
        }
    }
}
