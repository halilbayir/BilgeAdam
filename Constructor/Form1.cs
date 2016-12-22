using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

             Oyuncu _oyuncu = new Oyuncu("Şehmuz","GS",10,"Orta");

            MessageBox.Show(_oyuncu.adi+_oyuncu.takim+_oyuncu.formaNo+_oyuncu.pozisyon);
        }
    }
}
