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
            #region for donguleri

            //************************for döngüleri
            //int length = 10;
            //int fakto = 1;
            //for (int i = 0; i < length; i++)
            //{
            //    fakto *= i;
            //}
            //Console.WriteLine(fakto);
            //Console.ReadLine();
            #endregion

            #region For icin birden fazla kontrol
            //bool durum = true;
            //for (int i = 0; durum==true&& i < 100; i++)
            //{
            //    if (i * 2 > 20) { durum = false; }
            //   else  Console.WriteLine("{0} iken devam ediyorum",i);
            //}
            //Console.Read();
            #endregion

            #region break&continue

            //for (int i = 0; i < 100; i=i+5)
            //{
            //    if (i * 2 < 20)
            //    {
            //        //break; döngüyü direk sonlandırır ve donguden cıkar
            //        //continue; bir sonraki değere geçirir. yani 0 oluyorsa atlar 1 olursa atla 2 olursa iften çıkar 0 ve 1 işlemlerinde fora geri döner
            //        continue;
            //    }
            //    Console.WriteLine("{0} iken devam ediyorum!",i);
            //}
            //Console.ReadKey();
            #endregion

            #region [1,n} aralığındaki sayıların toplamı

            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 0; i <= n; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("1den {1} kadar olan sayıların TOPLAMI = {0}",toplam,n);
            //Console.ReadLine();

            #endregion

            #region iç içe for

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadLine();

            #endregion

            #region a-z ye kadar yaz

            //for (char c='a'; c <='z';  c++)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine();
            #endregion

            #region Carpim tablosu

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j <=10; j++)
            //    {
            //        Console.WriteLine("{0} x {1} = \t {2}",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion
        }
    }
}
