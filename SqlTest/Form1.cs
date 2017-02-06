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

namespace SqlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ALS-YG39104-J03;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=123456789?");
            SqlDataAdapter dap = new SqlDataAdapter("select * from Employees",baglan);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
