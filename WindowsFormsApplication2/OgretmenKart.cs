using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
     class OgretmenKart:Kart
    {

        public override void Okut()
        {
            System.Windows.Forms.MessageBox.Show("2 ₺ alındı. Kalan Bakiye: "+(bakiye-2));
            bakiye-=2;
        }
    }
}
