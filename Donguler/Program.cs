using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basit While Dongusu
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //Console.Read();
            #endregion

            #region 1-10 arası sayıları toplama

            //int i = 0;
            //int toplam = 0;
            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam={0}",toplam);
            //Console.Read();
            #endregion

            #region Faktoriyel [5! bul]

            int n = 5, fakto = 1, counter = 1;

            

            while (counter <= n)
            {
                fakto *= counter;
                counter++;
            }
            Console.WriteLine(fakto);
            Console.ReadLine();
            #endregion


        }
    }
}
