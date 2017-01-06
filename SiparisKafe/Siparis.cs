using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisKafe
{
    class Siparis
    {
        public int siparisAdet { get; set; }
        public Siparis(int siparisAdet, string siparisAd)
        {
            this.siparisAdet = siparisAdet;
            this.siparisAd = siparisAd;
        }
        public string siparisFiyat;

        public double siparisleriHesapla(Siparis siparisFiyat, int miktar)
        {
            double toplam = 0;
            toplam = Convert.ToInt32(siparisFiyat.siparisFiyat) * miktar;
            return toplam;
        }

        public string verilenSiparisinAdi { get; set; }
        public Siparis()
        {

        }
        public string siparisAd
        {
            get
            {
                return siparisFiyat;
            }
            set
            {
                if (value == "Kuru Fasulye")
                {
                    siparisFiyat = "5";
                }
                else if (value == "Tavuklu Pilav")
                {
                    siparisFiyat = "6";
                }
                else if (value == "Simit Tost")
                {
                    siparisFiyat = "4";
                }
                else if (value == "Lazanya")
                {
                    siparisFiyat = "2";
                }
                else if (value == "Su")
                {
                    siparisFiyat = "1";
                }
                else if (value == "Kola")
                {
                    siparisFiyat = "2";
                }
                else if (value == "Limonata")
                {
                    siparisFiyat = "3";
                }
                else if (value == "Çay")
                {
                    siparisFiyat = "1";
                }
                else if (value == "Kahve")
                {
                    siparisFiyat = "5";
                }

            }
        }

        public override string ToString()
        {
            return this.siparisAd + " " + this.siparisFiyat;
        }



    }
}
