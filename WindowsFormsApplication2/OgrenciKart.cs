using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class OgrenciKart:Kart
    {
        public OgrenciKart()
        {
            
        }


        public override void Okut()
        {
            System.Windows.Forms.MessageBox.Show("1₺ alındı.Kalan bakiye:"+(bakiye-1));
            bakiye--;
        }
    }
}
