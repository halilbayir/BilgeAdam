using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 1;
            int sonuc = 0;
            while (sayi > 0)
            {
                sonuc += (sayi % 2) * basamak;
                basamak *= 10;
                sayi /= 2;
            }
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
