using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    public class Tofas:Otomobil
    {
        public Tofas()
        {
            seri = "Serçe";
            model = "Murat 131";
            motorGucu = 65;
            motorHarcmi = 1400;
        }

        public override string Calistir()
        {
            return "tır tır Tofaş";
        }
    }
}
