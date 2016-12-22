using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Oyuncu
    {
        public string adi;
        public string takim;
        public byte formaNo;
        public string pozisyon;

        public Oyuncu(string Ad,string Takim,byte FormaNo,string Pozisyon)
        {
            adi = Ad;
            takim = Takim;
            formaNo = FormaNo;
            pozisyon = Pozisyon;
        }
        public override string ToString()
        {
            return this.adi+this.takim+this.formaNo + this.pozisyon;
        }
    }
   
}
