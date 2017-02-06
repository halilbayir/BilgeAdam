using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanKaynakları
{
    class SatisTemsilcisi:Calisan
    {
        public double satisMiktari { get; set; }

        public override double ZamYap(double satis)
        {
            if (satis < 10)
            {
                maas += satis * 10;
            }
            else if (satis < 20)
            {
                maas += satis * 20;
            }

            else
            {
                maas += satis * 30;
            }
            return maas;
        }
    }
}
