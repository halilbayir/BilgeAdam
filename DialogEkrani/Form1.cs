using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnTikla_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "")
            {
                listBox1.Items.Add(txtAdSoyad.Text);
            }
            txtAdSoyad.Clear();
            txtAdSoyad.Focus();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult resul = MessageBox.Show("Silmek İstermisiniz", "Onay Ekranı", MessageBoxButtons.YesNo);

            if (resul==DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                
            }

        }
    }
}
