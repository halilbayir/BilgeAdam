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

namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList descriptionList;
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");

            XmlNodeList titleList = xmlDoc.SelectNodes("//channel/item/title");
            descriptionList = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList dateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < titleList.Count; i++)
            {
                listBox1.Items.Add(titleList[i].InnerText);
            }

            //Baraj.tarih = Convert.ToDateTime(dateList[0].InnerText);

            //label1.Text = "Tarih : " + Baraj.tarih.ToString("dd/MM/yyyy"); 
            //for (int i = 0; i < titleList.Count; i++)
            //{
            //    Baraj b = new Baraj(titleList[i].InnerText, descriptionList[i].InnerText);
            //    listBox1.Items.Add(b);
            //}

            //while (true)
            //{
            //    for (int i = 0; i < listBox1.Items.Count; i++)
            //    {
            //        listBox1.SelectedItem = listBox1.Items[i];
            //    }
            //}
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            webBrowser1.DocumentText = descriptionList[i].InnerText;
        }
    }
}