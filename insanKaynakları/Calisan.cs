using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanKaynakları
{
    class Calisan
    {
        public int sskNo { get; set; }
        public double maas { get; set; }
        public string elemanTuru { get; set; }

        public override string ToString()
        {
            return string.Format("SSK No:\t{0}\nMaas:\t:{1}", sskNo, maas);
        }

        public virtual double ZamYap(double satis)
        {
            return maas;
        }

    }
}
