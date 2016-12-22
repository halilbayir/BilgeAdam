using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusFirma
{
    class Musteri
    {
        public string AdSoyad { get; set; }
        public bool Cinsiyet { get; set; } //false ise erkek true ise kadın
        public string OtobusTuru { get; set; }

        public override string ToString()
        {
            return this.AdSoyad + "\t" + this.Cinsiyet + "\t" + this.OtobusTuru;
        }
    }
}
