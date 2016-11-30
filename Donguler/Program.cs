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

            //int n = 5, fakto = 1, counter = 1;



            //while (counter <= n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}
            //Console.WriteLine(fakto);
            //Console.ReadLine();
            #endregion

            #region Random sayı tahmini
            //Console.WriteLine("1-10 arasında bir sayı tuttum tahmin et:\t");
            //Random rnd = new Random();
            //int rastgaleSayi = rnd.Next(1, 11);
            //int tahmin=0,sayac=0;

            //while (true)
            //{

            //    sayac++;
            //    Console.WriteLine("Tahmin:");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if(tahmin==rastgaleSayi)
            //    { break; }

            //}
            //Console.WriteLine("{0} adımda bildin",sayac);
            //Console.ReadLine();

            #endregion

            #region 1-100 arası sayı bulup tahmin etme

            //Console.WriteLine("1-100 arasında bir sayı tuttum tahmin et:\t");
            //Random rnd = new Random();
            //int rastgaleSayi = rnd.Next(1, 101);
            //int tahmin = 0, sayac = 0;

            //while (true)
            //{

            //    sayac++;
            //    Console.WriteLine("Tahmin:");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin < rastgaleSayi)
            //    {
            //        Console.WriteLine("Daha büyük");
            //    }
            //    else if (tahmin > rastgaleSayi)
            //    {
            //        Console.WriteLine("Daha küçük");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Tebrikler Buldun\n");
            //Console.WriteLine("{0} adımda bildin", sayac);
            //Console.ReadLine();

            #endregion

            #region 1-100e kadar tek sayıların toplamı

            //int i,toplam = 0;
            //int sum = 1;
            //string tercih = Convert.ToString(Console.ReadLine());

            //if (tercih == "topla")
            //{
            //    for (i = 1; i < 100; i++)
            //    {
            //        toplam += i;
            //    }
            //    Console.WriteLine("Toplam={0}\t", toplam);
            //}

            //else if (tercih == "carp")
            //{

            //    for (i = 1; i < 100; i++)
            //    {

            //        sum *= i;
            //    }
            //    Console.WriteLine("sum={0}\t", sum);
            //}
            //else Console.WriteLine("yanlıs giris");

            //Console.ReadLine();

            //--------------------------------------------------

            //long toplam = 0, carpim = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //string secim = Console.ReadLine();

            //int counter = 1;

            //while(counter<=n)
            //{
            //    if (counter % 2 == 1)
            //    {
            //        toplam += counter;
            //        carpim *= counter;
            //    }
            //    counter++;
            //}

            //if (secim == "topla")
            //{
            //    Console.WriteLine("{0}a kadar tek sayıların toplamı={1}",n,toplam);
            //}
            //else if(secim=="carpim")
            //{
            //    Console.WriteLine("{0}a kadar tek sayıların carpimi={1}", n, carpim);
            //}

            //#endregion

            //else
            //{
            //    Console.WriteLine(secim+"   ne??");
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
