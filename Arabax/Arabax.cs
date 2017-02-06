using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabax
{
    class Arabax
    {
        private int cap;
        private double kaclt;

        public int yakitDepoKapasitesi  { get; set; }
        public double kacLtOrtBenzin100km { get; set; }
        public double yakitFiyati { get; set; }
        public  double  toplamYol {
            get
            {
                return (yakitDepoKapasitesi * kacLtOrtBenzin100km) * 100;
            }
        }

        public Arabax(int yakdeop,double kaclt100kmde)
        {
            yakitDepoKapasitesi = yakdeop;
            kacLtOrtBenzin100km = kaclt100kmde;
            
        }

       
    }
}
