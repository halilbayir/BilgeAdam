using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbKisiSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKisiSec.SelectedIndex.Equals(0))
            {
                OgrenciForm frm = new OgrenciForm();
                frm.ShowDialog();
            }
            else if(cmbKisiSec.SelectedIndex.Equals(1))
            {
                Akademisyen frm = new Akademisyen();
                frm.ShowDialog();
            }
        }
    }
}
