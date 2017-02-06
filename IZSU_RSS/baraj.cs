using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    public class baraj
    {
        public string ad { get; set; }
        public string dolulukYuzde { get; set; }
       

       

        static public DateTime tarih { get; set; }

        public baraj(string ad,string dolulukYuzde)
        {
            this.ad = ad;
            this.dolulukYuzde = dolulukYuzde;
        }

        public override string ToString()
        {
            return this.ad+"\t"+"%  "+this.dolulukYuzde;
        }
    }
}
