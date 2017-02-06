using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Siparis
    {
        public double f;
        public string Ad { get; set; }
        public int miktar { get; set; }
        public string fiyat {
            get
            {
                return fiyat;
            }
            set
            {

                if (Ad == "Su")
                {
                    f = 1;
                }
                else if (Ad == "Kola")
                {
                    f = 2;
                }
                else if (Ad == "Limonata")
                {
                    f = 3;
                }
                else if (Ad == "Çay")
                {
                    f = 1.5;
                }
                else if (Ad == "Kahve")
                {
                    f = 5;
                }
                else if (Ad == "Kuru Fasulye")
                {
                    f = 5;
                }
                else if (Ad == "Tavuklu Pilav")
                {
                    f = 6;
                }
                else if (Ad == "Simit Tost")
                {
                    f = 4;
                }
                else if (Ad == "Lazanya")
                {
                    f = 2;

                }

            }
        }
        public double fiyatHesapla(int miktar,double siparisFiyat)
        {
            return miktar * f;
        }

        public override string ToString()
        {
            return this.Ad;
        }


    }
}
