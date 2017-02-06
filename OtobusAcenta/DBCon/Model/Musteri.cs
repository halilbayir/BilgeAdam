using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusAcenta.DBCon.Model
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriUsername { get; set; }
        public string MusteriPassword { get; set; }
        public bool isDeleted { get; set; }

    }
}
