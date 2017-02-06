using CodeFirst.Context;
using CodeFirst.Context.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (CodeFirstContext con=new CodeFirstContext())
            {
                Product p = new Product();
                p.ProductName = "Erikli 19lt";
                p.ProductPrice = 11.5;
                con.Product.Add(p);

                con.Product.Add(new Product { ProductName = "Saka", ProductPrice = 23 });
            }
        }
    }
}
