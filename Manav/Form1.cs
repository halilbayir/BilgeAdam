using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav
{
    public partial class Form1 : Form
    {
        public partial Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=ALS-YG39104-J03;Initial Catalog=ManavDB;Persist Security Info=True;User ID=sa");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_Manav", con);
            kmt.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            SqlDataAdapter dbp = new SqlDataAdapter("select * from tbl_Manav", con);
            dbp.Fill(tbl);
            listBox1.DataSource = tbl;
        }
    }
}
