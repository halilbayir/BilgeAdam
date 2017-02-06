using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Honda:Otomobil
    {
        
        public Honda()
        {
            seri = "Vtec";
            model = "s2000";
            motorGucu = 250;
            motorHarcmi = 2000;
        }
        public override string Calistir()
        {
            return "hand hand";
        }
    }
}
