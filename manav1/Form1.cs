using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataManavDataContext dc = new DataManavDataContext("Data Source=ALS-YG39104-J03;Initial Catalog=ManavDB;Persist Security Info=True;User ID=sa;Password=123456789?");
            tbl_Manav manav = new tbl_Manav();

            foreach (var item in manav.ProductName)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
