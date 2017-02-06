using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    public abstract class Otomobil
    {
        public string seri { get; set; }
        public string model { get; set; }
        public int motorGucu { get; set; }
        public int motorHarcmi { get; set; }

        public string Yazdir()
        {

            return string.Format("Marka:  {0}\t Model={1}\t Motor Gücü:{2}\t Motor Hacmi:{3} ",seri,model,motorGucu,motorHarcmi);
        }
        public abstract string Calistir();
        
    }
}
