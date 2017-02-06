using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparis
{
    class Masa
    {
        public string masaNo { get; set; }
        public List<Siparis> siparisler = new List<Siparis>();
        public double toplamBorc { get; set; }
        public override string ToString()
        {
            return masaNo;
        }
    }
}
