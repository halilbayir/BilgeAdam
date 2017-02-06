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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ALS-YG39104-J03;Initial Catalog=Ogrenciler;Persist Security Info=True;User ID=sa;Password=123456789?");

        public Form1()
        {
            InitializeComponent();
            DatagridYenile();
        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into OgrenciBilgi Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();

        }

        public void DatagridYenile()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select OgrenciId,OgrenciAd,OgrenciNo,OgrenciNotu from OgrenciBilgi ", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("Delete OgrenciBilgi Where  OgrenciId=" + dataGridView1.CurrentRow.Cells["OgrenciId"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("Update OgrenciBilgi  Where OgrenciId=" + dataGridView1.CurrentRow.Cells["OgrenciId"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }
    }
}
