using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           double sayi1 = 0;
        double toplam = 0;
           string islem = "";
        private void button_Click(object sender, EventArgs e)
        {
            textBox1.Text+= (sender as Button).Text;
            int sayi1 = Convert.ToInt32(textBox1.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        

        private void button_islem(object sender, EventArgs e)
        {
            textBox1.Text = "";
            islem= (sender as Button).Text;

        }

        private void button_esittir(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(textBox1.Text);
            switch (islem)
            {
                case "+":
                    toplam = sayi1 + sayi2;
                    break;

                case "-":
                    toplam = sayi1 - sayi2;
                    break;

                case "*":
                    toplam = sayi1 * sayi2;
                    break;

                case "/":
                    toplam = sayi1 / sayi2;
                    break;

                default:
                    MessageBox.Show("Yanlis");
                    break;
            }
        }
    }
}
