using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobüs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                #region Koltuklar trevago
                panelTravego.Visible = true;
                panelSetra.Visible = false;
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
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.DarkBlue;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelTravego.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
                #endregion
            }
            else
            {
                #region Koltuklar Setra

                panelSetra.Visible = true;
                panelTravego.Visible = false;
                int counter = 1;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 12) && (i != 6 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.DarkBlue;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelSetra.Controls.Add(btn);
                            counter++;
                        }
                    }
                }

                #endregion
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button SecilenKoltuk = sender as Button;
            lblKoltukNo.Text = SecilenKoltuk.Text;
            lblOtobusTuru.Text = cmbOtobusTuru.SelectedItem.ToString();

            if (lblOtobusTuru.Text=="Travego")
            {
                string yolcu=
            }
            else
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSetra.Visible = false;
            panelTravego.Visible = false;
        }

        string[] travegoYolcularIsim = new string[60];
        string[] setraYolcularIsim = new string[60];
        string[] travegoYolcularCinsiyet = new string[60];
        string[] setraYolcularCinsiyet = new string[60];


        private void btnMusteriBilgiKaydet_Click(object sender, EventArgs e)
        {
            if (lblOtobusTuru.Text == "Travego")
            {
                travegoYolcularIsim[int.Parse(lblKoltukNo.Text) - 1] = txtYolcuIsim.Text;
                string cinsiyet;
                if (rbErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else { cinsiyet = "Kadın"; }
                travegoYolcularCinsiyet[int.Parse(lblKoltukNo.Text) - 1] = cinsiyet;
            }
            else
            {
                setraYolcularIsim[int.Parse(lblKoltukNo.Text) - 1] = txtYolcuIsim.Text;
                string cinsiyet;
                if (rbErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else { cinsiyet = "Kadın"; }
                setraYolcularCinsiyet[int.Parse(lblKoltukNo.Text) - 1] = cinsiyet;
            }
            txtYolcuIsim.Text = " ";
            lblKoltukNo.Text = "0";
            lblOtobusTuru.Text = "0";
        }
    }
}
