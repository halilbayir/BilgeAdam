using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    interface IKisiBilgileri
    {
         string ad { get; set; }
         string soyad { get; set; }
         string telefon { get; set; }

        string bilgiGoster();
    }
}
