using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
   public class Haberler
    {
        public string haberler { get; set; }
        public string haberLink { get; set; }

        public Haberler(string haberler,string haberLink)
        {
            this.haberler = haberler;
            this.haberLink = haberLink;
            
        }
        public override string ToString()
        {
            return this.haberler+"\t"+ "http://www.izsu.gov.tr/" + this.haberLink;
        }
    }
}
