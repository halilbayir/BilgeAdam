using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public enum YolcuTipi
    {
        Tam,
        Ogrenci,
        Ogretmen
    };
    public class Kart
    {
        private double _bakiye;
        public double bakiye {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value <0)
                {
                    System.Windows.Forms.MessageBox.Show("Bakiye Yetersiz!");
                }
                else
                {
                    _bakiye = value;
                }
            }
        }
        public int kartID { get; set; }
        public string okulAdi { get; set; }
        public YolcuTipi kartTuru { get; set; }
        public virtual void Okut()
        {
            System.Windows.Forms.MessageBox.Show("Binis Başarılı");

        }
        public override string ToString()
        {
            return this.kartID + "\t" + this.bakiye+"\t"+this.okulAdi+"\t"+this.kartTuru;
        }
    }
}
