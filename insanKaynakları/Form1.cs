using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insanKaynakları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbElemanTuru.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void lstCalisanList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)lstCalisanList.SelectedItem;
            cmbElemanTuru.Enabled = false;
            numSskNo.Enabled = false;
            numMaas.Enabled = false;
            numSatisAdet.Enabled = true;
            btnGuncelle.Enabled = true;

            numSskNo.Value = st.sskNo;
            numMaas.Value = Convert.ToDecimal(st.maas);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)lstCalisanList.SelectedItem;
            st.elemanTuru = cmbElemanTuru.SelectedItem.ToString();
            st.sskNo = Convert.ToInt32(numSskNo.Value);
            st.satisMiktari = Convert.ToInt32(numSatisAdet.Value);
            st.maas = Convert.ToInt32(numMaas.Value);
            
        }
    }
}
