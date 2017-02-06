using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirincEvYemekleri.Models
{
    public class Menu
    {
        public List<AnaYemek> anayemekler { get; set; }
        public List<Salata> salatalar { get; set; }
        public List<Tatli> tatlilar { get; set; }

    }
}
