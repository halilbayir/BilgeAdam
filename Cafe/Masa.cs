using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Masa
    {
        public string masaNo { get; set; }
        public List<Siparis> siparisler;
        public Masa()
        {

            siparisler = new List<Siparis>();
            
        }
        public override string ToString()
        {
            return this.masaNo;
        }
    }
}
