using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GunlukDovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
           

        }
        XmlDocument xmlDoc;
        DateTime tarih = new DateTime();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           





            if (comboBox1.SelectedItem.ToString() == "Dolar")
            {
                string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yy"), USD);

            }
            else if (comboBox1.SelectedItem.ToString() == "Euro")
            {
                string Euro = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yy"), Euro);


            }
            else
            {
                string Sterlin = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Sterlin", tarih.ToString("dd/MM/yy"), Sterlin);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
        }
    }
}
