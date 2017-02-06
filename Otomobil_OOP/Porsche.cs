using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Porsche:Otomobil
    {
        public Porsche()
        {
            seri = "GT";
            model = "911";
            motorGucu = 400;
            motorHarcmi = 3000;
        }

        public override string Calistir()
        {
            return "VROM VROM PORSCHE";
        }
    }
}
