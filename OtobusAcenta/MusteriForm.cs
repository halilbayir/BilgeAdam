using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusAcenta
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            int counter = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 11) && (i != 5 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += Button_Click;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + ""; // counter.ToString();
                        btn.BackColor = RenkOlustur(counter, "Travego");
                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        panelOtobus.Controls.Add(btn);
                        counter++;
                    }
                }
            }
        }

        private Color RenkOlustur(int counter, string v)
        {
            Color color = Color.Azure;
            return color;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            

        }
    }
}
