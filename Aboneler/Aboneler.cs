using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aboneler
{
    public class Aboneler
    {
        public int AboneNo;
        public string AdSoyad;
        public string AboneTuru;
        public double oncekiSayac;
        public double sonSayac;
        public double aboneUcret;
        public double OdemeHesapla(double ilk,double son, string a_turu)
        {
            double resul = 0;
            if (AboneTuru=="Ev")
            {
                resul=0.25 * (son - ilk);
                return resul;
            }
            else
            {
                resul= 0.50 * (son - ilk);
                return resul;
            }
        }
        public override string ToString()
        {
            return this.AdSoyad ;
        }
    }
    
   

}
