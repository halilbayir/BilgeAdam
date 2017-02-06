using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class OgretimGorevlisi:IKisiBilgileri,ICalisanBilgileri
    {
        private string _ad;
        private string _soyad;
        private string _tel;
        public string _gorev;
        public string _bolum;
        public string ad
        {


            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string bolum
        {
            get
            {
                return _bolum;
            }

            set
            {
                _bolum = value;
            }
        }

        public string gorevi
        {
            get
            {
                return _gorev;
            }

            set
            {
                _gorev = value;
            }
        }

        public string soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string telefon
        {
            get
            {
                return _tel;
            }

            set
            {
                _tel = value;
            }
        }

        public string bilgiGoster()
        {
            return string.Format("Ad:{0} /t Soyad:{1} /t Tel:{2}/t Bölüm:  {3} /t Görev:{4}\t ", ad, soyad, telefon,bolum,gorevi);
        }
    }
}
