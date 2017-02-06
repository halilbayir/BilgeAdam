using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusAcenta.DBCon.Model
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public bool isDeleted { get; set; }
    }
}
